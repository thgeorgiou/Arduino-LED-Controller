namespace Arduino_Control {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.colorWheel = new Cyotek.Windows.Forms.ColorWheel();
            this.labelBlue = new MetroFramework.Controls.MetroLabel();
            this.labelGreen = new MetroFramework.Controls.MetroLabel();
            this.labelRed = new MetroFramework.Controls.MetroLabel();
            this.buttonApply = new MetroFramework.Controls.MetroButton();
            this.blueTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.greenTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.redTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lampToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.refreshButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.colorWheel);
            this.metroPanel1.Controls.Add(this.labelBlue);
            this.metroPanel1.Controls.Add(this.labelGreen);
            this.metroPanel1.Controls.Add(this.labelRed);
            this.metroPanel1.Controls.Add(this.buttonApply);
            this.metroPanel1.Controls.Add(this.blueTrackBar);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.greenTrackBar);
            this.metroPanel1.Controls.Add(this.redTrackBar);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(541, 132);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // colorWheel
            // 
            this.colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel.Location = new System.Drawing.Point(293, 3);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(135, 126);
            this.colorWheel.TabIndex = 16;
            this.colorWheel.ColorChanged += new System.EventHandler(this.colorWheel_ColorChanged);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.CustomBackground = false;
            this.labelBlue.CustomForeColor = false;
            this.labelBlue.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.labelBlue.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.labelBlue.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labelBlue.Location = new System.Drawing.Point(502, 38);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(30, 19);
            this.labelBlue.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelBlue.StyleManager = null;
            this.labelBlue.TabIndex = 20;
            this.labelBlue.Text = "255";
            this.labelBlue.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labelBlue.UseStyleColors = true;
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.CustomBackground = false;
            this.labelGreen.CustomForeColor = false;
            this.labelGreen.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.labelGreen.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.labelGreen.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labelGreen.Location = new System.Drawing.Point(473, 38);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(30, 19);
            this.labelGreen.Style = MetroFramework.MetroColorStyle.Green;
            this.labelGreen.StyleManager = null;
            this.labelGreen.TabIndex = 19;
            this.labelGreen.Text = "255";
            this.labelGreen.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labelGreen.UseStyleColors = true;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.CustomBackground = false;
            this.labelRed.CustomForeColor = false;
            this.labelRed.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.labelRed.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.labelRed.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labelRed.Location = new System.Drawing.Point(444, 38);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(30, 19);
            this.labelRed.Style = MetroFramework.MetroColorStyle.Red;
            this.labelRed.StyleManager = null;
            this.labelRed.TabIndex = 18;
            this.labelRed.Text = "255";
            this.labelRed.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labelRed.UseStyleColors = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Highlight = false;
            this.buttonApply.Location = new System.Drawing.Point(444, 65);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(89, 23);
            this.buttonApply.Style = MetroFramework.MetroColorStyle.Blue;
            this.buttonApply.StyleManager = null;
            this.buttonApply.TabIndex = 16;
            this.buttonApply.Text = "Apply";
            this.buttonApply.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.blueTrackBar.CustomBackground = false;
            this.blueTrackBar.LargeChange = ((uint)(5u));
            this.blueTrackBar.Location = new System.Drawing.Point(56, 84);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Minimum = 0;
            this.blueTrackBar.MouseWheelBarPartitions = 10;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(231, 23);
            this.blueTrackBar.SmallChange = ((uint)(1u));
            this.blueTrackBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.blueTrackBar.StyleManager = null;
            this.blueTrackBar.TabIndex = 8;
            this.blueTrackBar.Text = "blueTrackbar";
            this.blueTrackBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.blueTrackBar.Value = 50;
            this.blueTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueTrackBar_Scroll);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(3, 84);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Blue:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.greenTrackBar.CustomBackground = false;
            this.greenTrackBar.LargeChange = ((uint)(5u));
            this.greenTrackBar.Location = new System.Drawing.Point(56, 55);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Minimum = 0;
            this.greenTrackBar.MouseWheelBarPartitions = 10;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(231, 23);
            this.greenTrackBar.SmallChange = ((uint)(1u));
            this.greenTrackBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.greenTrackBar.StyleManager = null;
            this.greenTrackBar.TabIndex = 7;
            this.greenTrackBar.Text = "greenTrackbar";
            this.greenTrackBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.greenTrackBar.Value = 50;
            this.greenTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenTrackBar_Scroll);
            // 
            // redTrackBar
            // 
            this.redTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.redTrackBar.CustomBackground = false;
            this.redTrackBar.LargeChange = ((uint)(5u));
            this.redTrackBar.Location = new System.Drawing.Point(56, 26);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Minimum = 0;
            this.redTrackBar.MouseWheelBarPartitions = 10;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(231, 23);
            this.redTrackBar.SmallChange = ((uint)(1u));
            this.redTrackBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.redTrackBar.StyleManager = null;
            this.redTrackBar.TabIndex = 6;
            this.redTrackBar.Text = "redTrackbar";
            this.redTrackBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.redTrackBar.Value = 50;
            this.redTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redTrackBar_Scroll);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(3, 55);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Green:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(3, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Red:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(3, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "LED Backlight";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // lampToggle
            // 
            this.lampToggle.AutoSize = true;
            this.lampToggle.CustomBackground = false;
            this.lampToggle.DisplayStatus = true;
            this.lampToggle.FontSize = MetroFramework.MetroLinkSize.Small;
            this.lampToggle.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lampToggle.Location = new System.Drawing.Point(127, 206);
            this.lampToggle.Name = "lampToggle";
            this.lampToggle.Size = new System.Drawing.Size(80, 17);
            this.lampToggle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lampToggle.StyleManager = null;
            this.lampToggle.TabIndex = 1;
            this.lampToggle.Text = "Off";
            this.lampToggle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lampToggle.UseStyleColors = false;
            this.lampToggle.UseVisualStyleBackColor = true;
            this.lampToggle.CheckedChanged += new System.EventHandler(this.buttonApply_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.CustomForeColor = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(26, 201);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Desk Lamp";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // closeButton
            // 
            this.closeButton.Highlight = false;
            this.closeButton.Location = new System.Drawing.Point(489, 206);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.closeButton.StyleManager = null;
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Highlight = false;
            this.refreshButton.Location = new System.Drawing.Point(408, 206);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.refreshButton.StyleManager = null;
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 238);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lampToggle);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 760);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Arduino Control";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTrackBar blueTrackBar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTrackBar greenTrackBar;
        private MetroFramework.Controls.MetroTrackBar redTrackBar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroToggle lampToggle;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroButton refreshButton;
        private MetroFramework.Controls.MetroButton buttonApply;
        private MetroFramework.Controls.MetroLabel labelGreen;
        private MetroFramework.Controls.MetroLabel labelRed;
        private MetroFramework.Controls.MetroLabel labelBlue;
        private Cyotek.Windows.Forms.ColorWheel colorWheel;
    }
}

