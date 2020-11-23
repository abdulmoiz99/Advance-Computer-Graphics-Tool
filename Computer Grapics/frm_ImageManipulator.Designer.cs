namespace Computer_Grapics
{
    partial class frm_ImageManipulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ImageManipulator));
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.pb_imageA = new System.Windows.Forms.PictureBox();
            this.btn_browseImage1 = new XanderUI.XUIButton();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.pb_imageB = new System.Windows.Forms.PictureBox();
            this.btn_browseImage2 = new XanderUI.XUIButton();
            this.btn_MultiplyImage = new XanderUI.XUISuperButton();
            this.btn_SubtractImage = new XanderUI.XUISuperButton();
            this.btn_DivideImage = new XanderUI.XUISuperButton();
            this.btn_AddImage = new XanderUI.XUISuperButton();
            this.xuiCustomGroupbox3 = new XanderUI.XUICustomGroupbox();
            this.pb_ImageResults = new System.Windows.Forms.PictureBox();
            this.xuiSuperButton3 = new XanderUI.XUISuperButton();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageA)).BeginInit();
            this.xuiCustomGroupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageB)).BeginInit();
            this.xuiCustomGroupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageResults)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.pb_imageA);
            this.xuiCustomGroupbox1.Controls.Add(this.btn_browseImage1);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(24, 12);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(430, 357);
            this.xuiCustomGroupbox1.TabIndex = 0;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Image A";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // pb_imageA
            // 
            this.pb_imageA.BackColor = System.Drawing.Color.White;
            this.pb_imageA.Location = new System.Drawing.Point(6, 25);
            this.pb_imageA.Name = "pb_imageA";
            this.pb_imageA.Size = new System.Drawing.Size(418, 270);
            this.pb_imageA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imageA.TabIndex = 3;
            this.pb_imageA.TabStop = false;
            // 
            // btn_browseImage1
            // 
            this.btn_browseImage1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_browseImage1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_browseImage1.ButtonImage")));
            this.btn_browseImage1.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.btn_browseImage1.ButtonText = "Browse Image A";
            this.btn_browseImage1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_browseImage1.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_browseImage1.CornerRadius = 5;
            this.btn_browseImage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_browseImage1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_browseImage1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_browseImage1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_browseImage1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_browseImage1.Location = new System.Drawing.Point(113, 304);
            this.btn_browseImage1.Name = "btn_browseImage1";
            this.btn_browseImage1.Size = new System.Drawing.Size(198, 47);
            this.btn_browseImage1.TabIndex = 2;
            this.btn_browseImage1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_browseImage1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_browseImage1.Click += new System.EventHandler(this.btn_browseImage1_Click);
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.pb_imageB);
            this.xuiCustomGroupbox2.Controls.Add(this.btn_browseImage2);
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(24, 375);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(430, 357);
            this.xuiCustomGroupbox2.TabIndex = 1;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Image B";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // pb_imageB
            // 
            this.pb_imageB.BackColor = System.Drawing.Color.White;
            this.pb_imageB.Location = new System.Drawing.Point(6, 25);
            this.pb_imageB.Name = "pb_imageB";
            this.pb_imageB.Size = new System.Drawing.Size(418, 270);
            this.pb_imageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imageB.TabIndex = 3;
            this.pb_imageB.TabStop = false;
            // 
            // btn_browseImage2
            // 
            this.btn_browseImage2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btn_browseImage2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_browseImage2.ButtonImage")));
            this.btn_browseImage2.ButtonStyle = XanderUI.XUIButton.Style.Dark;
            this.btn_browseImage2.ButtonText = "Browse Image B";
            this.btn_browseImage2.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btn_browseImage2.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btn_browseImage2.CornerRadius = 5;
            this.btn_browseImage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_browseImage2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_browseImage2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btn_browseImage2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btn_browseImage2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_browseImage2.Location = new System.Drawing.Point(113, 303);
            this.btn_browseImage2.Name = "btn_browseImage2";
            this.btn_browseImage2.Size = new System.Drawing.Size(198, 47);
            this.btn_browseImage2.TabIndex = 2;
            this.btn_browseImage2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btn_browseImage2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_browseImage2.Click += new System.EventHandler(this.btn_browseImage2_Click);
            // 
            // btn_MultiplyImage
            // 
            this.btn_MultiplyImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btn_MultiplyImage.ButtonImage = null;
            this.btn_MultiplyImage.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_MultiplyImage.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_MultiplyImage.ButtonText = "x";
            this.btn_MultiplyImage.CornerRadius = 5;
            this.btn_MultiplyImage.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MultiplyImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_MultiplyImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btn_MultiplyImage.HoverTextColor = System.Drawing.Color.White;
            this.btn_MultiplyImage.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_MultiplyImage.Location = new System.Drawing.Point(601, 285);
            this.btn_MultiplyImage.Name = "btn_MultiplyImage";
            this.btn_MultiplyImage.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btn_MultiplyImage.SelectedTextColor = System.Drawing.Color.White;
            this.btn_MultiplyImage.Size = new System.Drawing.Size(64, 40);
            this.btn_MultiplyImage.SuperSelected = false;
            this.btn_MultiplyImage.TabIndex = 4;
            this.btn_MultiplyImage.TextColor = System.Drawing.Color.White;
            this.btn_MultiplyImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_MultiplyImage.Click += new System.EventHandler(this.btn_MultiplyImage_Click);
            // 
            // btn_SubtractImage
            // 
            this.btn_SubtractImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btn_SubtractImage.ButtonImage = null;
            this.btn_SubtractImage.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_SubtractImage.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_SubtractImage.ButtonText = "-";
            this.btn_SubtractImage.CornerRadius = 5;
            this.btn_SubtractImage.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubtractImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_SubtractImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btn_SubtractImage.HoverTextColor = System.Drawing.Color.White;
            this.btn_SubtractImage.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_SubtractImage.Location = new System.Drawing.Point(531, 331);
            this.btn_SubtractImage.Name = "btn_SubtractImage";
            this.btn_SubtractImage.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btn_SubtractImage.SelectedTextColor = System.Drawing.Color.White;
            this.btn_SubtractImage.Size = new System.Drawing.Size(64, 40);
            this.btn_SubtractImage.SuperSelected = false;
            this.btn_SubtractImage.TabIndex = 5;
            this.btn_SubtractImage.TextColor = System.Drawing.Color.White;
            this.btn_SubtractImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_SubtractImage.Click += new System.EventHandler(this.btn_SubtractImage_Click);
            // 
            // btn_DivideImage
            // 
            this.btn_DivideImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btn_DivideImage.ButtonImage = null;
            this.btn_DivideImage.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_DivideImage.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_DivideImage.ButtonText = "/";
            this.btn_DivideImage.CornerRadius = 5;
            this.btn_DivideImage.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DivideImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_DivideImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btn_DivideImage.HoverTextColor = System.Drawing.Color.White;
            this.btn_DivideImage.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_DivideImage.Location = new System.Drawing.Point(601, 377);
            this.btn_DivideImage.Name = "btn_DivideImage";
            this.btn_DivideImage.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btn_DivideImage.SelectedTextColor = System.Drawing.Color.White;
            this.btn_DivideImage.Size = new System.Drawing.Size(64, 40);
            this.btn_DivideImage.SuperSelected = false;
            this.btn_DivideImage.TabIndex = 7;
            this.btn_DivideImage.TextColor = System.Drawing.Color.White;
            this.btn_DivideImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btn_AddImage.ButtonImage = null;
            this.btn_AddImage.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btn_AddImage.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btn_AddImage.ButtonText = "+";
            this.btn_AddImage.CornerRadius = 5;
            this.btn_AddImage.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btn_AddImage.HoverTextColor = System.Drawing.Color.White;
            this.btn_AddImage.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btn_AddImage.Location = new System.Drawing.Point(671, 331);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btn_AddImage.SelectedTextColor = System.Drawing.Color.White;
            this.btn_AddImage.Size = new System.Drawing.Size(64, 40);
            this.btn_AddImage.SuperSelected = false;
            this.btn_AddImage.TabIndex = 8;
            this.btn_AddImage.TextColor = System.Drawing.Color.White;
            this.btn_AddImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // xuiCustomGroupbox3
            // 
            this.xuiCustomGroupbox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xuiCustomGroupbox3.BorderWidth = 1;
            this.xuiCustomGroupbox3.Controls.Add(this.pb_ImageResults);
            this.xuiCustomGroupbox3.Location = new System.Drawing.Point(793, 126);
            this.xuiCustomGroupbox3.Name = "xuiCustomGroupbox3";
            this.xuiCustomGroupbox3.ShowText = true;
            this.xuiCustomGroupbox3.Size = new System.Drawing.Size(430, 520);
            this.xuiCustomGroupbox3.TabIndex = 9;
            this.xuiCustomGroupbox3.TabStop = false;
            this.xuiCustomGroupbox3.Text = "Results";
            this.xuiCustomGroupbox3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // pb_ImageResults
            // 
            this.pb_ImageResults.BackColor = System.Drawing.Color.White;
            this.pb_ImageResults.Location = new System.Drawing.Point(6, 25);
            this.pb_ImageResults.Name = "pb_ImageResults";
            this.pb_ImageResults.Size = new System.Drawing.Size(418, 344);
            this.pb_ImageResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_ImageResults.TabIndex = 5;
            this.pb_ImageResults.TabStop = false;
            // 
            // xuiSuperButton3
            // 
            this.xuiSuperButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.xuiSuperButton3.ButtonImage = null;
            this.xuiSuperButton3.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton3.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton3.ButtonText = "=";
            this.xuiSuperButton3.CornerRadius = 5;
            this.xuiSuperButton3.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSuperButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton3.Location = new System.Drawing.Point(601, 331);
            this.xuiSuperButton3.Name = "xuiSuperButton3";
            this.xuiSuperButton3.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton3.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.Size = new System.Drawing.Size(64, 40);
            this.xuiSuperButton3.SuperSelected = false;
            this.xuiSuperButton3.TabIndex = 6;
            this.xuiSuperButton3.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // frm_ImageManipulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 771);
            this.Controls.Add(this.xuiCustomGroupbox3);
            this.Controls.Add(this.btn_AddImage);
            this.Controls.Add(this.btn_DivideImage);
            this.Controls.Add(this.xuiSuperButton3);
            this.Controls.Add(this.btn_SubtractImage);
            this.Controls.Add(this.btn_MultiplyImage);
            this.Controls.Add(this.xuiCustomGroupbox2);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ImageManipulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ImageManipulator";
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageA)).EndInit();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imageB)).EndInit();
            this.xuiCustomGroupbox3.ResumeLayout(false);
            this.xuiCustomGroupbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.PictureBox pb_imageA;
        private XanderUI.XUIButton btn_browseImage1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private System.Windows.Forms.PictureBox pb_imageB;
        private XanderUI.XUIButton btn_browseImage2;
        private XanderUI.XUISuperButton btn_MultiplyImage;
        private XanderUI.XUISuperButton btn_SubtractImage;
        private XanderUI.XUISuperButton btn_DivideImage;
        private XanderUI.XUISuperButton btn_AddImage;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox3;
        private System.Windows.Forms.PictureBox pb_ImageResults;
        private XanderUI.XUISuperButton xuiSuperButton3;
    }
}