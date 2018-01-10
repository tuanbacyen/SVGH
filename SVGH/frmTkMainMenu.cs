using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVGH.Database;
using SVGH.MySystem;

namespace SVGH
{
    public partial class frmTkMainMenu : Form
    {
        public frmTkMainMenu()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            mySys.ExitApp();
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmTKSVH frmTKSVHmn = new frmTKSVH();
            this.TopMost = false;
            frmTKSVHmn.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmTKTV frmTKTVmn = new frmTKTV();
            this.TopMost = false;
            frmTKTVmn.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSHC frmSHCmn = new frmSHC();
            this.TopMost = false;
            frmSHCmn.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmBHC frmBHCmn = new frmBHC();
            this.TopMost = false;
            frmBHCmn.Show();
        }
    }
}
