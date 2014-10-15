using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Arduino_Control {
    public partial class MainForm : MetroForm {
        private const String Server = "http://192.168.1.112/";

        public MainForm() {
            InitializeComponent();
            // Refresh data
            RefreshData();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Sends current data to the Arduino
        /// </summary>
        /// <param name="red">Red color value (0-255)</param>
        /// <param name="green">Green color value (0-255)</param>
        /// <param name="blue">Blue color value (0-255)</param>
        /// <param name="relay">Relay status, 0 for off, 1 for on</param>
        private void SendData(byte red, byte green, byte blue, byte relay) {
            // Store our data in an integer
            uint rgbr = red;
            rgbr = (rgbr << 8) + green;
            rgbr = (rgbr << 8) + blue;
            rgbr = (rgbr << 8) + relay;

            // Send our data
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Server + rgbr);
            request.Method = "GET";

            using (WebResponse response = request.GetResponse()) {
            }
        }

        /// <summary>
        /// Grabs remote data from the Arduino
        /// </summary>
        private void RefreshData() {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Server);
            request.Method = "GET";

            JSONResponse response;

            using (Stream stream = request.GetResponse().GetResponseStream()) {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();
                response = JsonConvert.DeserializeObject<JSONResponse>(responseString);
            }

            redTrackBar.Value = response.r;
            greenTrackBar.Value = response.g;
            blueTrackBar.Value = response.b;

            if (response.d == 0) lampToggle.Checked = false;
            else lampToggle.Checked = true;

            labelRed.Text = redTrackBar.Value.ToString();
            labelGreen.Text = greenTrackBar.Value.ToString();
            labelBlue.Text = blueTrackBar.Value.ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            RefreshData();
        }

        private void buttonApply_Click(object sender, EventArgs e) {
            SendData((byte) redTrackBar.Value,
                (byte) greenTrackBar.Value,
                (byte) blueTrackBar.Value, 
                lampToggle.Checked ? (byte) 1 : (byte) 0);
        }

        private void redTrackBar_Scroll(object sender, ScrollEventArgs e) {
            labelRed.Text = redTrackBar.Value.ToString();
            SetColorWheel();
        }

        private void greenTrackBar_Scroll(object sender, ScrollEventArgs e) {
            labelGreen.Text = greenTrackBar.Value.ToString();
            SetColorWheel();
        }

        private void blueTrackBar_Scroll(object sender, ScrollEventArgs e) {
            labelBlue.Text = blueTrackBar.Value.ToString();
            SetColorWheel();
        }

        private void colorWheel_ColorChanged(object sender, EventArgs e) {
            Color color = colorWheel.Color;

            redTrackBar.Value = color.R;
            greenTrackBar.Value = color.G;
            blueTrackBar.Value = color.B;

            labelRed.Text = redTrackBar.Value.ToString();
            labelGreen.Text = greenTrackBar.Value.ToString();
            labelBlue.Text = blueTrackBar.Value.ToString();
        }

        private void SetColorWheel() {
            Color color = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);

            colorWheel.Color = color;
        }

    }
}
