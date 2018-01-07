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
using System.IO;

namespace SVGH
{
    public partial class frmTKSVH : Form
    {
        #region
        int showName = 0;
        int idex = 0;
        #endregion

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
            if (idex != -1)
            {
                xemct(idex);
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
                dtgSVH.Columns["TenVN"].Visible = true;
                dtgSVH.Columns["TenKH"].Visible = false;
                showName = 0;
            }
            else if (rdkh.Checked)
            {
                dtgSVH.Columns["TenVN"].Visible = false;
                dtgSVH.Columns["TenKH"].Visible = true;
                showName = 1;
            }
            else if (rdch.Checked)
            {
                dtgSVH.Columns["TenVN"].Visible = true;
                dtgSVH.Columns["TenKH"].Visible = true;
                showName = 2;
            }
            showdata();
        }

        private void frmTKSVH_Load(object sender, EventArgs e)
        {
            showdata();
            loadNhom();
            loadPhamVi();
        }

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhom.Items.Count > 0)
            {
                showdata();
            }
        }

        private void dtgSVH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtgSVH.Rows.Count > 0 && e.RowIndex != -1)
            {
                getImageToShow(dtgSVH.Rows[e.RowIndex].Cells["ID_SVH"].Value.ToString());
                idex = e.RowIndex;
            }

        }

        private void dtgSVH_Sorted(object sender, EventArgs e)
        {
            getImageToShow(dtgSVH.Rows[idex].Cells["ID_SVH"].Value.ToString());
        }

        private void cbPVKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPVKC.Items.Count > 0)
            {
                showdata();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showdata();
        }

        #region
        private void xemct(int iex)
        {
            frmChiTietSVH mfrmChiTiet = new frmChiTietSVH(dtgSVH.Rows[iex].Cells["ID_SVH"].Value.ToString());
            mfrmChiTiet.ShowDialog();
        }

        private void showdata()
        {
            string idnhom = "";
            string idCay = "";

            if (cbNhom.Items.Count > 0)
            {
                idnhom = cbNhom.SelectedValue.ToString();
            }
            if (cbPVKC.Items.Count > 0)
            {
                idCay = cbPVKC.SelectedValue.ToString();
            }

            string sql = "SELECT ID_SVH,TenVN,TenKH FROM tblSVH ";
            bool check = false;

            if (idnhom != "all" && idnhom != "")
            {
                sql = sql + " where ID_NhomSVH = '" + idnhom + "' ";
                check = true;
            }

            if (idCay != "all" && idCay != "" && check == false)
            {
                sql = sql + " where ID_Cay = '" + idCay + "' ";
                check = true;
            }
            else if (idCay != "all" && idCay != "" && check == true)
            {
                sql = sql + " and ID_Cay = '" + idCay + "' ";
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

            dtgSVH.DataSource = database_helper.GetDataTable(sql);
            if (dtgSVH.Rows.Count > 0)
            {
                dtgSVH.Rows[0].Selected = true;
                getImageToShow(dtgSVH.Rows[0].Cells["ID_SVH"].Value.ToString());
            }
            else
            {
                txtTVN.Text = txtTKH.Text = txtTVN.Text = txtTVN.Text = txtTD.Text = "";
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

        private void loadNhom()
        {
            string sql = "SELECT ID_NhomSVH,TenNhom FROM tblNhomSVH";
            DataTable db = database_helper.GetDataTable(sql);
            DataRow dr = db.NewRow();
            dr[0] = "all";
            dr[1] = "Chọn tất cả";
            db.Rows.InsertAt(dr, 0);
            cbNhom.DataSource = db;
            cbNhom.ValueMember = "ID_NhomSVH";
            cbNhom.DisplayMember = "TenNhom";
        }

        private void getImageToShow(string id)
        {
            string sqlSVH = "SELECT TenVN,TenKH,ID_Cay,ID_NhomSVH,Tac_Dong FROM tblSVH where ID_SVH =" + id;
            DataTable db = database_helper.GetDataTable(sqlSVH);
            txtTVN.Text = db.Rows[0][0].ToString();
            txtTKH.Text = db.Rows[0][1].ToString();

            DataTable dbC = database_helper.GetDataTable("SELECT TenCay FROM tblCay where ID_Cay = '" + db.Rows[0][2].ToString() + "'");

            txtKC.Text = dbC.Rows[0][0].ToString();

            DataTable dbN = database_helper.GetDataTable("SELECT TenNhom FROM tblNhomSVH where ID_NhomSVH = '" + db.Rows[0][3].ToString() + "'");
            txtN.Text = dbN.Rows[0][0].ToString();

            txtTD.Text = db.Rows[0][4].ToString();
        }
        #endregion

        private void dtgSVH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgSVH.Rows.Count > 0 && e.RowIndex != -1)
            {
                xemct(e.RowIndex);
            }
        }
    }
}
