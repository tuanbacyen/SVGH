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
    public partial class frmTKTV : Form
    {
        int idex = 0;
        enum myCheck { trungtam, trungdumnpb, dongbangsh, duyenhaibtb, taynguyen, taynambo, duyenhaintb, dongnambo, dongbangscl };
        string[] textCheck = { "Trung tâm", "Trung du miền núi phía Bắc", "Đồng bằng sông Hồng", "Duyên hải Bắc Trung Bộ", "Tây Nguyên", "Tây Nam Bộ", "Duyên hải Nam Trung Bộ", "Đông Nam Bộ", "Đồng bằng sông Cửu Long" };

        public frmTKTV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xemct(int iex)
        {
            if(idex != -1)
            {
                frmChiTietSVH mfrmChiTiet = new frmChiTietSVH(dtg.Rows[iex].Cells["ID_SVH"].Value.ToString());
                mfrmChiTiet.ShowDialog();
            }
        }

        private void frmTKTV_Load(object sender, EventArgs e)
        {
            loadData();
            loadPhamVi();
            loadNhom();
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

        private void loadData()
        {
            string idnhom = "";
            string idCay = "";

            clearText();

            if (cbNhom.Items.Count > 0)
            {
                idnhom = cbNhom.SelectedValue.ToString();
            }
            if (cbPVKC.Items.Count > 0)
            {
                idCay = cbPVKC.SelectedValue.ToString();
            }

            string sql = "SELECT TenVN,TenKH,ID_SVH FROM tblSVH ";
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

            if (txtSearch.Text.Trim() == "")
            {
                DataTable dbSVH = database_helper.GetDataTable(sql);
                dtg.DataSource = dbSVH;
            }
            else
            {
                if (check == true)
                {
                    sql += " and ";
                }
                else
                {
                    sql += " where ";
                }

                string[] textSearch = txtSearch.Text.Trim().Split(',');
                string keySearchSVH = "";
                string keySearchName = "";

                for (int i = 0; i < textSearch.Length; i++)
                {
                    if (i == 0)
                    {
                        keySearchSVH += "DIA_DIEM_PH like '%" + textSearch[i] + "%' ";
                        keySearchName += "OR TenVN like '%" + textSearch[i] + "%' or TenKH like '%" + textSearch[i] + "%'";
                    }
                    else
                    {
                        keySearchSVH += " OR DIA_DIEM_PH like '%" + textSearch[i] + "%' ";
                        keySearchName += "OR TenVN like '%" + textSearch[i] + "%' or TenKH like '%" + textSearch[i] + "%'";
                    }
                }

                sql += keySearchSVH + " " + keySearchName;
            }

            dtg.DataSource = database_helper.GetDataTable(sql);

            if (dtg.Rows.Count > 0)
            {
                dtg.Rows[0].Selected = true;
                idex = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void clearText()
        {
            string textNew = txtSearch.Text.Trim();

            while (true)
            {
                if (textNew.IndexOf(",,") != -1)
                {
                    textNew = textNew.Replace(",,", ",");
                }
                else
                {
                    break;
                }
            }
            if (textNew.Length > 0)
            {
                if (textNew[0] == ',')
                {
                    textNew = textNew.Remove(0, 1);
                }
            }
            if (textNew.Length > 1)
            {
                if (textNew[textNew.Length - 1] == ',')
                {
                    textNew = textNew.Remove(textNew.Length - 1, 1);
                }
            }
            txtSearch.Text = textNew.Trim();
        }

        private void dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtg.Rows.Count > 0 && e.RowIndex != -1)
            {
                xemct(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idex != -1)
            {
                xemct(idex);
            }
        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg.Rows.Count > 0 && e.RowIndex != -1)
            {
                idex = e.RowIndex;
            }
        }

        private void cbLTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void cbPVKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPVKC.Items.Count > 0)
            {
                loadData();
            }
        }

        private void cbNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhom.Items.Count > 0)
            {
                loadData();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                loadData();
            }
        }
    }
}
