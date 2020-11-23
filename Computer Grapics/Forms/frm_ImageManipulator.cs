using Computer_Grapics.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Grapics
{
    public partial class frm_ImageManipulator : Form
    {
        bool isImageALoaded = false, isImageBLoaded = false;
        private string imageAPath = "", imageBPath = "";
        public frm_ImageManipulator()
        {
            InitializeComponent();
        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            if (isImageALoaded == false) MessageBox.Show("Please load image A first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (isImageBLoaded == false) MessageBox.Show("Please load image B first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                pb_ImageResults.Image = ManipulateImage.AddImages(imageAPath, imageBPath);
            }
        }
        private void btn_SubtractImage_Click(object sender, EventArgs e)
        {
            if (isImageALoaded == false) MessageBox.Show("Please load image A first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (isImageBLoaded == false) MessageBox.Show("Please load image B first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                pb_ImageResults.Image = ManipulateImage.SubtractImages(imageAPath, imageBPath);
            }
        }
        private void btn_MultiplyImage_Click(object sender, EventArgs e)
        {
            if (isImageALoaded == false) MessageBox.Show("Please load image A first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (isImageBLoaded == false) MessageBox.Show("Please load image B first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                pb_ImageResults.Image = ManipulateImage.MultiplyImage(imageAPath, imageBPath);
            }
        }

        private void btn_browseImage1_Click(object sender, EventArgs e)
        {
            isImageALoaded = false;

            var open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_imageA.Image = new Bitmap(open.FileName);
                imageAPath = open.FileName;
                isImageALoaded = true;
            }
        }

        private void btn_browseImage2_Click(object sender, EventArgs e)
        {
            isImageBLoaded = false;

            var open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_imageB.Image = new Bitmap(open.FileName);
                imageBPath = open.FileName;
                isImageBLoaded = true;
            }
        }
    }
}
