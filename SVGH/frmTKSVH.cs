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

namespace SVGH
{
    public partial class frmTKSVH : Form
    {
        public frmTKSVH()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkShowColumn();
        }

        private void checkShowColumn()
        {
            if (rdvn.Checked)
            {
                dtgSVH.Columns["TenVN"].Visible = false;
                dtgSVH.Columns["TenKH"].Visible = true;
            }
            else if (rdkh.Checked)
            {
                dtgSVH.Columns["TenVN"].Visible = true;
                dtgSVH.Columns["TenKH"].Visible = false;
            }
            else if (rdch.Checked)
            {
                dtgSVH.Columns["TenVN"].Visible = true;
                dtgSVH.Columns["TenKH"].Visible = true;
            }
        }

        private void frmTKSVH_Load(object sender, EventArgs e)
        {
            showdata();
        }

        #region
        private void xemct()
        {

        }

        private void showdata()
        {
            string sql = "SELECT TenVN,TenKH FROM tblSVH;";
            dtgSVH.DataSource = database_helper.GetDataTable(sql);
        }
        #endregion
    }
}
