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
                frmTKSVHmn.FormClosed += FrmTKSVHmn_FormClosed;
                frmTKSVHmn.Show();
            }
        }

        private void FrmTKSVHmn_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].GetType() == typeof(frmChiTietSVH) || Application.OpenForms[i].GetType() == typeof(frmViewImage))
                {
                    Application.OpenForms[i].Close();
                }
            }
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(frmChiTietSVH) || form.GetType() == typeof(frmViewImage))
            //    {
            //        form.Close();
            //    }
            //}
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
                frmTKTV frmTKTVmn = new frmTKTV();
                frmTKTVmn.FormClosed += FrmTKSVHmn_FormClosed;
                frmTKTVmn.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
                frmSHCmn.FormClosed += FrmSHCmn_FormClosed;
                frmSHCmn.Show();
            }
        }

        private void FrmSHCmn_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].GetType() == typeof(frmChiTietSHC) || Application.OpenForms[i].GetType() == typeof(frmViewImage))
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
                frmBHCmn.FormClosed += FrmBHCmn_FormClosed;
                frmBHCmn.Show();
            }
        }

        private void FrmBHCmn_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].GetType() == typeof(frmChiTietBHC) || Application.OpenForms[i].GetType() == typeof(frmViewImage))
                {
                    Application.OpenForms[i].Close();
                }
            }
        }
    }
}
