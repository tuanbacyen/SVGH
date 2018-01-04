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
            frmTKSVHmn.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            database_helper.openCon();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSHC frmSHCmn = new frmSHC();
            frmSHCmn.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmBHC frmBHCmn = new frmBHC();
            frmBHCmn.ShowDialog();
        }
    }
}
