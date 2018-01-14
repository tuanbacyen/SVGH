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
    public partial class frmSHC : Form
    {
        #region
        int showName = 0;
        int idex = 0;
        #endregion

        public frmSHC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idex != -1)
            {
                xemct(idex);
            }
        }

        private void cbPVKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPVKC.Items.Count > 0)
            {
                showdata();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            checkShowColumn();
        }

        private void checkShowColumn()
        {
            if (rdvn.Checked)
            {
                dtgSHC.Columns["TenVN"].Visible = true;
                dtgSHC.Columns["TenKH"].Visible = false;
                showName = 0;
            }
            else if (rdkh.Checked)
            {
                dtgSHC.Columns["TenVN"].Visible = false;
                dtgSHC.Columns["TenKH"].Visible = true;
                showName = 1;
            }
            else if (rdch.Checked)
            {
                dtgSHC.Columns["TenVN"].Visible = true;
                dtgSHC.Columns["TenKH"].Visible = true;
                showName = 2;
            }
            showdata();
        }

        private void frmSHC_Load(object sender, EventArgs e)
        {
            showdata();
            loadPhamVi();
        }

        private void dtgBHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgSHC.Rows.Count > 0 && e.RowIndex != -1)
            {
                getImageToShow(dtgSHC.Rows[e.RowIndex].Cells["ID_SHChinh"].Value.ToString());
                idex = e.RowIndex;
            }
        }

        private void dtgSHC_Sorted(object sender, EventArgs e)
        {
            getImageToShow(dtgSHC.Rows[idex].Cells["ID_SHChinh"].Value.ToString());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showdata();
        }

        #region
        private void xemct(int iex)
        {
            frmChiTietSHC mfrmChiTiet = new frmChiTietSHC(dtgSHC.Rows[iex].Cells["ID_SHChinh"].Value.ToString());
            mfrmChiTiet.ShowDialog();
        }

        private void showdata()
        {
            string idCay = "";

            if (cbPVKC.Items.Count > 0)
            {
                idCay = cbPVKC.SelectedValue.ToString();
            }

            string sql = "SELECT ID_SHChinh,TenVN,TenKH FROM tblSHChinh ";
            bool check = false;

            if (idCay != "all" && idCay != "")
            {
                sql = sql + " where ID_Cay = '" + idCay + "' ";
                check = true;
            }

            sql = sql + getSearch(check, showName);

            if (showName == 0)
            {
                sql = sql + " ORDER BY TenKH ASC";
            }
            else if (showName == 1)
            {
                sql = sql + " ORDER BY TenKH ASC";
            }
            else if (showName == 2)
            {
                sql = sql + " ORDER BY TenVN ASC";
            }

            dtgSHC.DataSource = database_helper.GetDataTable(sql);
            if (dtgSHC.Rows.Count > 0)
            {
                dtgSHC.Rows[0].Selected = true;
                idex = 0;
                getImageToShow(dtgSHC.Rows[0].Cells["ID_SHChinh"].Value.ToString());
            }
            else
            {
                imgLoad.Image = null;
            }
        }

        private string getSearch(bool c, int l)
        {
            string sql = "";
            if (txtSearch.Text != "")
            {
                if (l == 0)
                {
                    sql = " TenVN like '%" + txtSearch.Text.Trim() + "%' or TenKH like '%" + txtSearch.Text.Trim() + "%' ";
                }
                else if (l == 1)
                {
                    sql = " TenKH like '%" + txtSearch.Text.Trim() + "%' ";
                }
                else if (l == 2)
                {
                    sql = " TenVN like '%" + txtSearch.Text.Trim() + "%' ";
                }

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
            string sql = "SELECT img_Data from tblAnhSHC where ID_SHChinh = " + id + " and isShow = 1";
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

        private void dtgSHC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgSHC.Rows.Count > 0 && e.RowIndex != -1)
            {
                xemct(e.RowIndex);
            }
        }

    }
}
