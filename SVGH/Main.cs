using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVGH.MySystem;

namespace SVGH
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen;
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;

            //
            openNewForm();
        }

        private void openNewForm()
        {
            //this.Hide();
            frmTkMainMenu tkMainMenu1 = new frmTkMainMenu();
            //tkMainMenu1.Closed += (s, args) => this.Close();
            tkMainMenu1.Show();
        }

        private void thoátKhỏiTrươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySys.ExitApp();
        }

        private void thựcĐơnChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewForm();
        }

        private void tìmKiếmSâuHạiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSHC frmSHCmn = new frmSHC();
            frmSHCmn.ShowDialog();
        }

        private void tìmKiếmBệnhHạiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBHC frmBHCmn = new frmBHC();
            frmBHCmn.ShowDialog();
        }

        private void tìmKiếmSinhVậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKSVH frmTKSVHmn = new frmTKSVH();
            frmTKSVHmn.ShowDialog();
        }

        private void tìmKiếmTheoVùngPhânBốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKTV frmTKSVHmn = new frmTKTV();
            frmTKSVHmn.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
