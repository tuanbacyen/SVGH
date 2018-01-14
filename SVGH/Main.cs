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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            openNewForm();
        }

        private void openNewForm()
        {
            frmTkMainMenu tkMainMenu1 = new frmTkMainMenu();
            if ((Application.OpenForms["frmTkMainMenu"] as frmTkMainMenu) == null)
            {
                tkMainMenu1.Show(this);
            }
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
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmSHC))
                {
                    form.Close();
                    break;
                }
            }
            if ((Application.OpenForms["frmSHC"] as frmSHC) == null)
            {
                frmSHC frmSHCmn = new frmSHC();
                frmSHCmn.Show();
            }
        }

        private void tìmKiếmBệnhHạiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmBHC))
                {
                    form.Close();
                    break;
                }
            }
            if ((Application.OpenForms["frmBHC"] as frmBHC) == null)
            {
                frmBHC frmBHCmn = new frmBHC();
                frmBHCmn.Show();
            }
        }

        private void tìmKiếmSinhVậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmTKSVH))
                {
                    form.Close();
                    break;
                }
            }
            if ((Application.OpenForms["frmTKSVH"] as frmTKSVH) == null)
            {
                frmTKSVH frmTKSVHmn = new frmTKSVH();
                frmTKSVHmn.Show();
            }
        }

        private void tìmKiếmTheoVùngPhânBốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmTKTV))
                {
                    form.Close();
                    break;
                }
            }
            if ((Application.OpenForms["frmTKTV"] as frmTKTV) == null)
            {
                frmTKTV frmTKSVHmn = new frmTKTV();
                frmTKSVHmn.Show();
            }
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saoLưuHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
