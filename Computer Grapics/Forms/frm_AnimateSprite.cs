using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Grapics
{
    public partial class Form1 : Form
    {
        static string path = @"C:\Users\moiza\Desktop\SpriteSheets\image1.png";
        static Image sourceImage;
        static int noOfObjects = 6;
        static int width = 0;// sourceImage.Width / noOfObjects;
        static int height = 0;// sourceImage.Height;
        static int count = 0;
        Thread t;
        bool animationStarted = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Animation()
        {
            while (true)
            {
                // Create a drawing target
                Bitmap bitmap = new Bitmap(width, height, sourceImage.PixelFormat);
                Graphics graphics = Graphics.FromImage(bitmap);
                // Draw a portion of the source image.
                Rectangle sourceRect = new Rectangle(width * count, height * 0, width, height);
                graphics.DrawImage(sourceImage, 0, 0, sourceRect, GraphicsUnit.Pixel);
             
                pictureBox1.Image = bitmap;
                count++;
                if (count >= noOfObjects) count = 0;
                Thread.Sleep(GetAnimationSpeed()); //m
            }
        }
        private int GetAnimationSpeed()
        {
            return animationSpeedSlider.Percentage * 10;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {

            if (animationStarted == false)
            {
                if (cb_Enablebackground.Checked == true)
                {
                    pictureBox1.Size = new Size(118, 193);
                    pictureBox1.Location = new Point(225, 540);
                }
                else
                {
                    pictureBox1.Size = new Size(505, 702);
                    pictureBox1.Location = new Point(200, 44);
                }
                t = new Thread(Animation);
                t.Start();
                animationStarted = true;
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (animationStarted == true)
            {
                t.Suspend();
                animationStarted = false;
            }
        }

        private void xuiSuperButton3_Click(object sender, EventArgs e)
        {
            var image = new Bitmap(@"C:\Users\moiza\Desktop\13179.jpg");
            panel2.BackgroundImage = image;
        }

        private void btn_UploadSprite_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpeg; *.gif; *.bmp)|*.png; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open.FileName);
                path = open.FileName;
                sourceImage =  Image.FromFile(path);
                width = sourceImage.Width / noOfObjects;
                height = sourceImage.Height;
            }
        }
    }
}
