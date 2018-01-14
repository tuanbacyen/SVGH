using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVGH
{
    public partial class frmTkMainMenu : Form
    {
        public frmTkMainMenu()
        {
            InitializeComponent();
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
            if ((Application.OpenForms["frmTKSVH"] as frmTKSVH) == null)
            {
                frmTKSVHmn.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmTKTV frmTKTVmn = new frmTKTV();
            if ((Application.OpenForms["frmTKTV"] as frmTKTV) == null)
            {
                frmTKTVmn.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSHC frmSHCmn = new frmSHC();
            if ((Application.OpenForms["frmSHC"] as frmSHC) == null)
            {
                frmSHCmn.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmBHC frmBHCmn = new frmBHC();
            if ((Application.OpenForms["frmBHC"] as frmBHC) == null)
            {
                frmBHCmn.Show();
            }
        }
    }
}
