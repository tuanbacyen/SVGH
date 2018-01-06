using SVGH.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVGH
{
    public partial class frmBHC : Form
    {
        int idex = 0;

        public frmBHC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xemct(idex);
        }

        private void cbPVKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPVKC.Items.Count > 0)
            {
                showdata();
            }
        }

        private void frmBHC_Load(object sender, EventArgs e)
        {
            showdata();
            loadPhamVi();
        }

        private void dtgBHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgBHC.Rows.Count > 0 && e.RowIndex != -1)
            {
                getImageToShow(dtgBHC.Rows[e.RowIndex].Cells["ID_BHChinh"].Value.ToString());
                idex = e.RowIndex;
            }
        }

        private void dtgBHC_Sorted(object sender, EventArgs e)
        {
            getImageToShow(dtgBHC.Rows[idex].Cells["ID_BHChinh"].Value.ToString());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showdata();
        }

        #region
        private void xemct(int iex)
        {
            frmChiTiet mfrmChiTiet = new frmChiTiet(dtgBHC.Rows[iex].Cells["ID_BHChinh"].Value.ToString(), 2);
            mfrmChiTiet.ShowDialog();
        }

        private void showdata()
        {
            string idCay = "";

            if (cbPVKC.Items.Count > 0)
            {
                idCay = cbPVKC.SelectedValue.ToString();
            }

            string sql = "SELECT ID_BHChinh,TenVN FROM tblBHChinh ";
            bool check = false;

            if (idCay != "all" && idCay != "")
            {
                sql = sql + " where ID_Cay = '" + idCay + "' ";
                check = true;
            }

            sql = sql + getSearch(check);

            sql = sql + " ORDER BY TenVN ASC";

            dtgBHC.DataSource = database_helper.GetDataTable(sql);
            if (dtgBHC.Rows.Count > 0)
            {
                dtgBHC.Rows[0].Selected = true;
                idex = 0;
                getImageToShow(dtgBHC.Rows[0].Cells["ID_BHChinh"].Value.ToString());
            }
            else
            {
                imgLoad.Image = Properties.Resources.imgdefault;
            }
        }

        private string getSearch(bool c)
        {
            string sql = "";
            if (txtSearch.Text != "")
            {
                sql = " TenVN like '%" + txtSearch.Text.Trim() + "%' ";

                if (c == true)
                {
                    sql = " and " + sql;
                }
                else
                {
                    sql = " where " + sql;
                }
            }
            return sql;
        }

        private void loadPhamVi()
        {
            string sql = "SELECT ID_Cay,TenCay FROM tblCay ;";
            DataTable db = database_helper.GetDataTable(sql);
            DataRow dr = db.NewRow();
            dr[0] = "all";
            dr[1] = "Chọn tất cả";
            db.Rows.InsertAt(dr, 0);
            cbPVKC.DataSource = db;
            cbPVKC.ValueMember = "ID_Cay";
            cbPVKC.DisplayMember = "TenCay";
        }

        private void getImageToShow(string id)
        {
            string sql = "SELECT img_Data from tblAnhBHC where ID_BHChinh = " + id + " and isShow = 1";
            DataTable db = database_helper.GetDataTable(sql);
            if (db.Rows.Count > 0)
            {
                try
                {
                    DataRow dr = db.NewRow();
                    DataRowView drv = db.DefaultView[0];

                    Byte[] i = (byte[])drv[0];
                    MemoryStream stmBLOBData = new MemoryStream(i);
                    imgLoad.Image = Image.FromStream(stmBLOBData);
                }
                catch (Exception ex)
                {
                    imgLoad.Image = Properties.Resources.imgdefault;
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                imgLoad.Image = Properties.Resources.imgdefault;
            }
        }
        #endregion

        private void dtgBHC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xemct(e.RowIndex);
        }
    }
}
