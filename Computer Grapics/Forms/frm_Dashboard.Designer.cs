﻿namespace Computer_Grapics
{
    partial class frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.PanelFloat = new System.Windows.Forms.Panel();
            this.Panel_SideBar = new System.Windows.Forms.Panel();
            this.btn_AnimateSprite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_systemInfo = new System.Windows.Forms.Button();
            this.btn_Manipulate = new System.Windows.Forms.Button();
            this.btn_Minimizesd = new System.Windows.Forms.Button();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.Toppannel = new XanderUI.XUIGradientPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.Panel_SideBar.SuspendLayout();
            this.Toppannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFloat
            // 
            this.PanelFloat.BackColor = System.Drawing.Color.White;
            this.PanelFloat.Location = new System.Drawing.Point(5, 188);
            this.PanelFloat.Name = "PanelFloat";
            this.PanelFloat.Size = new System.Drawing.Size(5, 49);
            this.PanelFloat.TabIndex = 4;
            // 
            // Panel_SideBar
            // 
            this.Panel_SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.Panel_SideBar.Controls.Add(this.btn_AnimateSprite);
            this.Panel_SideBar.Controls.Add(this.label1);
            this.Panel_SideBar.Controls.Add(this.btn_Setting);
            this.Panel_SideBar.Controls.Add(this.button1);
            this.Panel_SideBar.Controls.Add(this.btn_systemInfo);
            this.Panel_SideBar.Controls.Add(this.PanelFloat);
            this.Panel_SideBar.Controls.Add(this.btn_Manipulate);
            this.Panel_SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_SideBar.ForeColor = System.Drawing.Color.DarkCyan;
            this.Panel_SideBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_SideBar.Name = "Panel_SideBar";
            this.Panel_SideBar.Size = new System.Drawing.Size(368, 899);
            this.Panel_SideBar.TabIndex = 10;
            // 
            // btn_AnimateSprite
            // 
            this.btn_AnimateSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_AnimateSprite.FlatAppearance.BorderSize = 0;
            this.btn_AnimateSprite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_AnimateSprite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnimateSprite.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AnimateSprite.ForeColor = System.Drawing.Color.White;
            this.btn_AnimateSprite.Image = ((System.Drawing.Image)(resources.GetObject("btn_AnimateSprite.Image")));
            this.btn_AnimateSprite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AnimateSprite.Location = new System.Drawing.Point(21, 260);
            this.btn_AnimateSprite.Name = "btn_AnimateSprite";
            this.btn_AnimateSprite.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_AnimateSprite.Size = new System.Drawing.Size(344, 57);
            this.btn_AnimateSprite.TabIndex = 9;
            this.btn_AnimateSprite.Text = "Animate Sprite";
            this.btn_AnimateSprite.UseVisualStyleBackColor = false;
            this.btn_AnimateSprite.Click += new System.EventHandler(this.btn_AnimateSprite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(41, 862);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log Out";
            // 
            // btn_Setting
            // 
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_Setting.Image")));
            this.btn_Setting.Location = new System.Drawing.Point(3, 855);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(38, 40);
            this.btn_Setting.TabIndex = 7;
            this.btn_Setting.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 172);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_systemInfo
            // 
            this.btn_systemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_systemInfo.FlatAppearance.BorderSize = 0;
            this.btn_systemInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_systemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_systemInfo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_systemInfo.ForeColor = System.Drawing.Color.White;
            this.btn_systemInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_systemInfo.Image")));
            this.btn_systemInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_systemInfo.Location = new System.Drawing.Point(21, 332);
            this.btn_systemInfo.Name = "btn_systemInfo";
            this.btn_systemInfo.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_systemInfo.Size = new System.Drawing.Size(344, 57);
            this.btn_systemInfo.TabIndex = 6;
            this.btn_systemInfo.Text = "About";
            this.btn_systemInfo.UseVisualStyleBackColor = false;
            // 
            // btn_Manipulate
            // 
            this.btn_Manipulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Manipulate.FlatAppearance.BorderSize = 0;
            this.btn_Manipulate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(60)))), ((int)(((byte)(114)))));
            this.btn_Manipulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Manipulate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Manipulate.ForeColor = System.Drawing.Color.White;
            this.btn_Manipulate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Manipulate.Image")));
            this.btn_Manipulate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Manipulate.Location = new System.Drawing.Point(21, 188);
            this.btn_Manipulate.Name = "btn_Manipulate";
            this.btn_Manipulate.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btn_Manipulate.Size = new System.Drawing.Size(344, 57);
            this.btn_Manipulate.TabIndex = 1;
            this.btn_Manipulate.Text = "Manipulate";
            this.btn_Manipulate.UseVisualStyleBackColor = false;
            this.btn_Manipulate.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // btn_Minimizesd
            // 
            this.btn_Minimizesd.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimizesd.FlatAppearance.BorderSize = 0;
            this.btn_Minimizesd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizesd.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizesd.Image")));
            this.btn_Minimizesd.Location = new System.Drawing.Point(715, 0);
            this.btn_Minimizesd.Name = "btn_Minimizesd";
            this.btn_Minimizesd.Size = new System.Drawing.Size(35, 37);
            this.btn_Minimizesd.TabIndex = 11;
            this.btn_Minimizesd.UseVisualStyleBackColor = false;
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 20;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // Toppannel
            // 
            this.Toppannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Toppannel.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(212)))), ((int)(((byte)(104)))));
            this.Toppannel.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.Toppannel.Controls.Add(this.btn_close);
            this.Toppannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppannel.Location = new System.Drawing.Point(368, 0);
            this.Toppannel.Name = "Toppannel";
            this.Toppannel.PrimerColor = System.Drawing.Color.White;
            this.Toppannel.Size = new System.Drawing.Size(1287, 37);
            this.Toppannel.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.Toppannel.TabIndex = 13;
            this.Toppannel.TopLeft = System.Drawing.Color.DeepSkyBlue;
            this.Toppannel.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1228, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 35);
            this.btn_close.TabIndex = 9;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 899);
            this.Controls.Add(this.Toppannel);
            this.Controls.Add(this.Panel_SideBar);
            this.Controls.Add(this.btn_Minimizesd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Panel_SideBar.ResumeLayout(false);
            this.Panel_SideBar.PerformLayout();
            this.Toppannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFloat;
        private System.Windows.Forms.Panel Panel_SideBar;
        private System.Windows.Forms.Button btn_AnimateSprite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_systemInfo;
        private System.Windows.Forms.Button btn_Manipulate;
        private System.Windows.Forms.Button btn_Minimizesd;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIGradientPanel Toppannel;
        private System.Windows.Forms.Button btn_close;
    }
}