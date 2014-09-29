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
        String server = "http://192.168.1.112/";

        public MainForm() {
            InitializeComponent();
            // Refresh data
            RefreshData();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void sendColor(String color, int value) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(server + "exec?" + color + "=" + value);
            request.Method = "GET";

            using (WebResponse response = request.GetResponse()) {
            }
        }

        private void RefreshData() {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(server);
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

        private void lampToggle_CheckedChanged(object sender, EventArgs e) {
            HttpWebRequest request;

            if (lampToggle.Checked) request = (HttpWebRequest)WebRequest.Create(server + "?d=1");
            else request = (HttpWebRequest)WebRequest.Create(server + "?d=0");

            request.Method = "GET";
            using (WebResponse response = request.GetResponse()) {
            }
        }

        private void buttonApply_Click(object sender, EventArgs e) {
            sendColor("r", redTrackBar.Value);
            sendColor("g", greenTrackBar.Value);
            sendColor("b", blueTrackBar.Value);
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
