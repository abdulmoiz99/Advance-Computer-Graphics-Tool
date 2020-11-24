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
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            PanelFloat.Height = btn_Manipulate.Height;
            PanelFloat.Top = btn_Manipulate.Top;
            var NEW = new frm_ImageManipulator();
            NEW.MdiParent = this;
            NEW.Dock = DockStyle.Fill;
            NEW.Show();
        }

        private void btn_AnimateSprite_Click(object sender, EventArgs e)
        {
            PanelFloat.Height = btn_AnimateSprite.Height;
            PanelFloat.Top = btn_AnimateSprite.Top;
            var NEW = new Form1();
            NEW.MdiParent = this;
            NEW.Dock = DockStyle.Fill;
            NEW.Show();
        }
    }
}
