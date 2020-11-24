namespace Computer_Grapics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiCustomGroupbox3 = new XanderUI.XUICustomGroupbox();
            this.label2 = new System.Windows.Forms.Label();
            this.animationSpeedSlider = new XanderUI.XUISlider();
            this.btn_Stop = new XanderUI.XUISuperButton();
            this.btn_Start = new XanderUI.XUISuperButton();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.cb_Enablebackground = new XanderUI.XUICheckBox();
            this.xuiSuperButton3 = new XanderUI.XUISuperButton();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_UploadSprite = new XanderUI.XUISuperButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.xuiCustomGroupbox3.SuspendLayout();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.xuiCustomGroupbox3);
            this.panel1.Controls.Add(this.xuiCustomGroupbox2);
            this.panel1.Controls.Add(this.xuiCustomGroupbox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(741, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 759);
            this.panel1.TabIndex = 4;
            // 
            // xuiCustomGroupbox3
            // 
            this.xuiCustomGroupbox3.BorderColor = System.Drawing.Color.White;
            this.xuiCustomGroupbox3.BorderWidth = 1;
            this.xuiCustomGroupbox3.Controls.Add(this.label2);
            this.xuiCustomGroupbox3.Controls.Add(this.animationSpeedSlider);
            this.xuiCustomGroupbox3.Controls.Add(this.btn_Stop);
            this.xuiCustomGroupbox3.Controls.Add(this.btn_Start);
            this.xuiCustomGroupbox3.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox3.Location = new System.Drawing.Point(10, 485);
            this.xuiCustomGroupbox3.Name = "xuiCustomGroupbox3";
            this.xuiCustomGroupbox3.ShowText = true;
            this.xuiCustomGroupbox3.Size = new System.Drawing.Size(304, 236);
            this.xuiCustomGroupbox3.TabIndex = 10;
            this.xuiCustomGroupbox3.TabStop = false;
            this.xuiCustomGroupbox3.Text = "Animation";
            this.xuiCustomGroupbox3.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delay";
            // 
            // animationSpeedSlider
            // 
            this.animationSpeedSlider.BarThickness = 4;
            this.animationSpeedSlider.BigStepIncrement = 10;
            this.animationSpeedSlider.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.animationSpeedSlider.KnobColor = System.Drawing.Color.Gray;
            this.animationSpeedSlider.KnobImage = null;
            this.animationSpeedSlider.Location = new System.Drawing.Point(18, 81);
            this.animationSpeedSlider.Name = "animationSpeedSlider";
            this.animationSpeedSlider.Percentage = 50;
            this.animationSpeedSlider.QuickHopping = false;
            this.animationSpeedSlider.Size = new System.Drawing.Size(272, 20);
            this.animationSpeedSlider.SliderStyle = XanderUI.XUISlider.Style.Windows10;
            this.animationSpeedSlider.TabIndex = 5;
            this.animationSpeedSlider.Text = "xuiSlider1";
            this.animationSpeedSlider.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.btn_Stop.ButtonImage = null;
            this.btn_Stop.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_Stop.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_Stop.ButtonText = "Stop";
            this.btn_Stop.CornerRadius = 5;
            this.btn_Stop.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Stop.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btn_Stop.HoverTextColor = System.Drawing.Color.White;
            this.btn_Stop.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_Stop.Location = new System.Drawing.Point(161, 132);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btn_Stop.SelectedTextColor = System.Drawing.Color.White;
            this.btn_Stop.Size = new System.Drawing.Size(129, 40);
            this.btn_Stop.SuperSelected = false;
            this.btn_Stop.TabIndex = 7;
            this.btn_Stop.TextColor = System.Drawing.Color.White;
            this.btn_Stop.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.btn_Start.ButtonImage = null;
            this.btn_Start.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_Start.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_Start.ButtonText = "Start";
            this.btn_Start.CornerRadius = 5;
            this.btn_Start.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Start.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btn_Start.HoverTextColor = System.Drawing.Color.White;
            this.btn_Start.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_Start.Location = new System.Drawing.Point(18, 132);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btn_Start.SelectedTextColor = System.Drawing.Color.White;
            this.btn_Start.Size = new System.Drawing.Size(129, 40);
            this.btn_Start.SuperSelected = false;
            this.btn_Start.TabIndex = 5;
            this.btn_Start.TextColor = System.Drawing.Color.White;
            this.btn_Start.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.White;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.cb_Enablebackground);
            this.xuiCustomGroupbox2.Controls.Add(this.xuiSuperButton3);
            this.xuiCustomGroupbox2.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(10, 311);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(304, 153);
            this.xuiCustomGroupbox2.TabIndex = 9;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Background";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.White;
            // 
            // cb_Enablebackground
            // 
            this.cb_Enablebackground.CheckboxCheckColor = System.Drawing.Color.White;
            this.cb_Enablebackground.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.cb_Enablebackground.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.cb_Enablebackground.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.cb_Enablebackground.Checked = false;
            this.cb_Enablebackground.ForeColor = System.Drawing.Color.White;
            this.cb_Enablebackground.Location = new System.Drawing.Point(18, 38);
            this.cb_Enablebackground.Name = "cb_Enablebackground";
            this.cb_Enablebackground.Size = new System.Drawing.Size(250, 21);
            this.cb_Enablebackground.TabIndex = 12;
            this.cb_Enablebackground.Text = "Enable background";
            this.cb_Enablebackground.TickThickness = 2;
            // 
            // xuiSuperButton3
            // 
            this.xuiSuperButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.xuiSuperButton3.ButtonImage = null;
            this.xuiSuperButton3.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton3.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton3.ButtonText = "Add Background";
            this.xuiSuperButton3.CornerRadius = 5;
            this.xuiSuperButton3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSuperButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.xuiSuperButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton3.Location = new System.Drawing.Point(18, 89);
            this.xuiSuperButton3.Name = "xuiSuperButton3";
            this.xuiSuperButton3.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.xuiSuperButton3.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.Size = new System.Drawing.Size(272, 40);
            this.xuiSuperButton3.SuperSelected = false;
            this.xuiSuperButton3.TabIndex = 5;
            this.xuiSuperButton3.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton3.Click += new System.EventHandler(this.xuiSuperButton3_Click);
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.White;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.pictureBox2);
            this.xuiCustomGroupbox1.Controls.Add(this.btn_UploadSprite);
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("Century Gothic", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox1.ForeColor = System.Drawing.Color.White;
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(10, 92);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(304, 215);
            this.xuiCustomGroupbox1.TabIndex = 8;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Sprite Info";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.White;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(18, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btn_UploadSprite
            // 
            this.btn_UploadSprite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.btn_UploadSprite.ButtonImage = null;
            this.btn_UploadSprite.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_UploadSprite.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_UploadSprite.ButtonText = "Upload Sprite";
            this.btn_UploadSprite.CornerRadius = 5;
            this.btn_UploadSprite.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadSprite.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_UploadSprite.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btn_UploadSprite.HoverTextColor = System.Drawing.Color.White;
            this.btn_UploadSprite.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_UploadSprite.Location = new System.Drawing.Point(18, 26);
            this.btn_UploadSprite.Name = "btn_UploadSprite";
            this.btn_UploadSprite.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(155)))), ((int)(((byte)(225)))));
            this.btn_UploadSprite.SelectedTextColor = System.Drawing.Color.White;
            this.btn_UploadSprite.Size = new System.Drawing.Size(272, 40);
            this.btn_UploadSprite.SuperSelected = false;
            this.btn_UploadSprite.TabIndex = 5;
            this.btn_UploadSprite.TextColor = System.Drawing.Color.White;
            this.btn_UploadSprite.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_UploadSprite.Click += new System.EventHandler(this.btn_UploadSprite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.77358F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Control Panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(101, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 702);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 759);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 759);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xuiCustomGroupbox3.ResumeLayout(false);
            this.xuiCustomGroupbox3.PerformLayout();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUISuperButton btn_UploadSprite;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox3;
        private XanderUI.XUISuperButton btn_Stop;
        private XanderUI.XUISuperButton btn_Start;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private XanderUI.XUISuperButton xuiSuperButton3;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUISlider animationSpeedSlider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUICheckBox cb_Enablebackground;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

