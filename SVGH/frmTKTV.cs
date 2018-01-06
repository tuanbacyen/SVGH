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
            //frmChiTiet mfrmChiTiet = new frmChiTiet(dtgSHC.Rows[iex].Cells["ID_SHChinh"].Value.ToString(), 1);
            //mfrmChiTiet.ShowDialog();
        }

        private void frmTKTV_Load(object sender, EventArgs e)
        {
            loaitimkiem();
            loadData();
        }

        private void loadData()
        {
            if (txtSearch.Text.Trim() == "")
            {
                if (cbLTK.SelectedIndex == 0)
                {
                    string sqlSVH = "SELECT TenVN,TenKH,ID_SVH as ID,0 as LOAI FROM tblSVH ";
                    string sqlSHC = "SELECT TenVN,TenKH,ID_SHChinh as ID,1 as LOAI FROM tblSHChinh ";
                    string sqlBHC = "SELECT TenVN,'' as TenKH,ID_BHChinh as ID,2 as LOAI FROM tblBHChinh ";

                    DataTable dbSVH = database_helper.GetDataTable(sqlSVH);
                    DataTable dbSHC = database_helper.GetDataTable(sqlSHC);
                    DataTable dbBHC = database_helper.GetDataTable(sqlBHC);

                    DataTable dbAll = new DataTable();
                    dbAll.Merge(dbSVH);
                    dbAll.Merge(dbSHC);
                    dbAll.Merge(dbBHC);

                    dtg.DataSource = dbAll;

                }
                else if (cbLTK.SelectedIndex == 1)
                {
                    string sqlSVH = "SELECT TenVN,TenKH,ID_SVH as ID,0 as LOAI FROM tblSVH ";
                    DataTable dbSVH = database_helper.GetDataTable(sqlSVH);
                    dtg.DataSource = dbSVH;
                }
                else if (cbLTK.SelectedIndex == 2)
                {
                    string sqlSHC = "SELECT TenVN,TenKH,ID_SHChinh as ID,1 as LOAI FROM tblSHChinh ";
                    DataTable dbSHC = database_helper.GetDataTable(sqlSHC);
                    dtg.DataSource = dbSHC;
                }
                else if (cbLTK.SelectedIndex == 3)
                {
                    string sqlBHC = "SELECT TenVN,'' as TenKH,ID_BHChinh as ID,2 as LOAI FROM tblBHChinh ";
                    DataTable dbBHC = database_helper.GetDataTable(sqlBHC);
                    dtg.DataSource = dbBHC;
                }
            }
            else
            {
                string[] textSearch = txtSearch.Text.Trim().Split(',');
                string keySearchSVH = " WHERE ";
                string keySearchSHC = " WHERE ";
                string keySearchBHC = " WHERE ";

                for (int i = 0; i < textSearch.Length; i++)
                {
                    if (i == 0)
                    {
                        keySearchSVH += "DIA_DIEM_PH like '%" + textSearch[i] + "%' ";
                        keySearchSHC += "Phan_Bo like '%" + textSearch[i] + "%' ";
                    }
                    else
                    {
                        keySearchSVH += " OR DIA_DIEM_PH like '%" + textSearch[i] + "%' ";
                        keySearchSHC += " OR Phan_Bo like '%" + textSearch[i] + "%' ";
                    }
                }

                if (cbLTK.SelectedIndex == 0)
                {
                    string sqlSVH = "SELECT TenVN,TenKH,ID_SVH as ID,0 as LOAI FROM tblSVH " + keySearchSVH;
                    string sqlSHC = "SELECT TenVN,TenKH,ID_SHChinh as ID,1 as LOAI FROM tblSHChinh ";
                    string sqlBHC = "SELECT TenVN,'' as TenKH,ID_BHChinh as ID,2 as LOAI FROM tblBHChinh ";

                    DataTable dbSVH = database_helper.GetDataTable(sqlSVH);
                    DataTable dbSHC = database_helper.GetDataTable(sqlSHC);
                    DataTable dbBHC = database_helper.GetDataTable(sqlBHC);

                    DataTable dbAll = new DataTable();
                    dbAll.Merge(dbSVH);
                    dbAll.Merge(dbSHC);
                    dbAll.Merge(dbBHC);

                    dtg.DataSource = dbAll;

                }
                else if (cbLTK.SelectedIndex == 1)
                {
                    string sqlSVH = "SELECT TenVN,TenKH,ID_SVH as ID,0 as LOAI FROM tblSVH " + keySearchSVH;
                    DataTable dbSVH = database_helper.GetDataTable(sqlSVH);
                    dtg.DataSource = dbSVH;
                }
                else if (cbLTK.SelectedIndex == 2)
                {
                    string sqlSHC = "SELECT TenVN,TenKH,ID_SHChinh as ID,1 as LOAI FROM tblSHChinh " + keySearchSHC;
                    DataTable dbSHC = database_helper.GetDataTable(sqlSHC);
                    dtg.DataSource = dbSHC;
                }
                else if (cbLTK.SelectedIndex == 3)
                {
                    string sqlBHC = "SELECT TenVN,'' as TenKH,ID_BHChinh as ID,2 as LOAI FROM tblBHChinh ";
                    DataTable dbBHC = database_helper.GetDataTable(sqlBHC);
                    dtg.DataSource = dbBHC;
                }
            }

            if (dtg.Rows.Count > 0)
            {
                dtg.Rows[0].Selected = true;
                idex = 0;
                getImageToShow(dtg.Rows[0].Cells["ID"].Value.ToString(), dtg.Rows[0].Cells["LOAI"].Value.ToString());
            }
            else
            {
                imgLoad.Image = Properties.Resources.imgdefault;
            }
        }

        private void loaitimkiem()
        {
            cbLTK.Items.Clear();
            cbLTK.Items.Insert(0, "Chọn tất cả");
            cbLTK.Items.Insert(1, "Sinh vật hại");
            cbLTK.Items.Insert(2, "Sâu hại chính");
            cbLTK.Items.Insert(3, "Bệnh hại chính");
            cbLTK.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadData();
        }

        #region check box
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

        private void cbtrungtam_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // trung tam
            if (cbtrungtam.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.trungtam]) == -1)
                {
                    textS += textCheck[(int)myCheck.trungtam] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.trungtam]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.trungtam], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }

        private void cbtaynguyen_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // tay nguyen
            if (cbtaynguyen.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.taynguyen]) == -1)
                {
                    textS += textCheck[(int)myCheck.taynguyen] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.taynguyen]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.taynguyen], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }

        private void cbtaynambo_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // tay nam bo
            if (cbtaynambo.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.taynambo]) == -1)
                {
                    textS += textCheck[(int)myCheck.taynambo] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.taynambo]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.taynambo], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }

        private void cbdbsonghong_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // dong bang song hong
            if (cbdbsonghong.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.dongbangsh]) == -1)
                {
                    textS += textCheck[(int)myCheck.dongbangsh] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.dongbangsh]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.dongbangsh], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }

        private void cbdongnambo_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // dong nam bo
            if (cbdongnambo.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.dongnambo]) == -1)
                {
                    textS += textCheck[(int)myCheck.dongnambo] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.dongnambo]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.dongnambo], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }

        private void cbtrungdumnpb_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // trung du mien nui phia bac
            if (cbtrungdumnpb.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.trungdumnpb]) == -1)
                {
                    textS += textCheck[(int)myCheck.trungdumnpb] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.trungdumnpb]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.trungdumnpb], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }

        private void cbduyenhaintb_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // duyen hai nam trung bo
            if (cbduyenhaintb.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.duyenhaintb]) == -1)
                {
                    textS += textCheck[(int)myCheck.duyenhaintb] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.duyenhaintb]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.duyenhaintb], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }

        private void cbduyenhaibtb_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // duyen hai ba trung bo
            if (cbduyenhaibtb.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.duyenhaibtb]) == -1)
                {
                    textS += textCheck[(int)myCheck.duyenhaibtb] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.duyenhaibtb]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.duyenhaibtb], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }

        private void cbdbsongcuulong_CheckedChanged(object sender, EventArgs e)
        {
            string textS = txtSearch.Text.Trim() + ",";
            // dong bang song cuu long
            if (cbdbsongcuulong.Checked)
            {
                if (textS.IndexOf(textCheck[(int)myCheck.dongbangscl]) == -1)
                {
                    textS += textCheck[(int)myCheck.dongbangscl] + ",";
                }
            }
            else
            {
                if (textS.IndexOf(textCheck[(int)myCheck.dongbangscl]) != -1)
                {
                    textS = textS.Replace(textCheck[(int)myCheck.dongbangscl], "");
                }
            }
            txtSearch.Text = textS;
            clearText();
        }
        #endregion

        private void dtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg.Rows.Count > 0 && e.RowIndex != -1)
            {
                getImageToShow(dtg.Rows[e.RowIndex].Cells["ID"].Value.ToString(), dtg.Rows[e.RowIndex].Cells["LOAI"].Value.ToString());
                idex = e.RowIndex;
            }
        }

        private void getImageToShow(string id, string loai)
        {
            if (loai == "0")
            {
                imgLoad.Image = Properties.Resources.imgdefault;
            }
            else if (loai == "1")
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
            else if (loai == "2")
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

        }

        private void dtg_Sorted(object sender, EventArgs e)
        {
            getImageToShow(dtg.Rows[idex].Cells["ID"].Value.ToString(), dtg.Rows[idex].Cells["LOAI"].Value.ToString());
        }

        private void cbLTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
