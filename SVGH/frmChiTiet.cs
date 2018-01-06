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
    public partial class frmChiTiet : Form
    {
        #region
        DataTable db;
        string ten = "";
        string vitriPL = "";
        string phanbo = "";
        string tachai = "";
        string mdxh = "";
        string dd = "";
        string gdbq = "";
        string ls = "";
        string tailieu = "";
        string id = "";
        enum myTextTitle { tenloai, vtpl, phanbo, tachai, mucdoxh, dacdiemnd, gdbq, lsphvn, tlphvn };
        string[] textTitle = { "Tên Loài", "Vị trí phân loại", "Phân bố", "Tác hại", "Mức độ xuất hiện", "Đặc điểm chỉnh của pha trưởng thành để nhận dạng", "Giám định bảo quản", "Lịch sử phát hiện ở Việt Nam", "Tài liệu công bố phát hiện ở việt nam" };
        enum myTextContent { tenvn, tenvnk, tenkh, tenkhk, ho, bo, lop, nganh, ttph, tgph, ddht, ddsh, bppt, nguyennhan };
        string[] textContent = { "Tên Việt Nam: ", "Tên Việt Nam khác: ", "Tên khoa học: ", "Tên khoa học khác: ", "Họ: ", "Bộ: ", "Lớp: ", "Ngành: ", "Tình trạng phát hiện: ", "Thời gian phát hiện: ", "Đặc điểm hình thái: ", "Đặc điểm sinh học: ", "Biện Pháp Phòng tránh: ", "Nguyên nhân: " };
        int loai = 0;
        int[] old = { 0, 5, 5, 2, 2, 1, 1, 1, 3, 1 };
        int[] test = { 0, 5, 10, 12, 14, 15, 16, 17, 20 };
        #endregion

        public frmChiTiet(string id, int loai)
        {
            InitializeComponent();
            this.id = id;
            this.loai = loai;
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            if (loai == 0)
            {
                string sql = "SELECT * FROM tblSVH where ID_SVH = " + id;
                db = database_helper.GetDataTable(sql);
            }
            else if (loai == 1)
            {
                string sql = "SELECT * FROM tblSHChinh where ID_SHChinh = " + id;
                db = database_helper.GetDataTable(sql);
            }
            else if (loai == 2)
            {
                string sql = "SELECT * FROM tblBHChinh where ID_BHChinh = " + id;
                db = database_helper.GetDataTable(sql);
            }
            getData();
        }

        private void getData()
        {
            if (this.loai == 0)
            {
                //string sql = "SELECT * FROM tblSVH where ID_SVH = " + id;
                //DataTable db = database_helper.GetDataTable(sql);

                ten = textTitle[(int)myTextTitle.tenloai] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvn] + db.Rows[0][3].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvnk] + db.Rows[0][4].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkh] + db.Rows[0][5].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkh] + db.Rows[0][6].ToString() + Environment.NewLine;

                vitriPL = textTitle[(int)myTextTitle.vtpl] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.ho] + db.Rows[0][12].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.bo] + db.Rows[0][13].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.lop] + db.Rows[0][14].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.nganh] + db.Rows[0][15].ToString() + Environment.NewLine;

                phanbo = textTitle[(int)myTextTitle.phanbo] + Environment.NewLine;
                if (db.Rows[0][9].ToString() != "")
                {
                    phanbo += "    " + db.Rows[0][9].ToString() + Environment.NewLine;
                }

                tachai = textTitle[(int)myTextTitle.tachai] + Environment.NewLine;
                if (db.Rows[0][8].ToString() != "")
                {
                    tachai += "    " + db.Rows[0][8].ToString() + Environment.NewLine;
                }

                mdxh = textTitle[(int)myTextTitle.mucdoxh] + Environment.NewLine;

                dd = textTitle[(int)myTextTitle.dacdiemnd] + Environment.NewLine;

                gdbq = textTitle[(int)myTextTitle.gdbq] + Environment.NewLine;

                ls = textTitle[(int)myTextTitle.lsphvn] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.ttph] + db.Rows[0][11].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tgph] + db.Rows[0][10].ToString() + Environment.NewLine;

                tailieu = textTitle[(int)myTextTitle.tlphvn] + Environment.NewLine;

                img.Image = Properties.Resources.imgdefault;
                lblTB.Text = "Chưa có ảnh";
                btnA.Enabled = false;

                show();
            }
            else if (this.loai == 1)
            {
                //string sql = "SELECT * FROM tblSHChinh where ID_SHChinh = " + id;
                //DataTable db = database_helper.GetDataTable(sql);

                ten = textTitle[(int)myTextTitle.tenloai] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvn] + db.Rows[0][1].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvnk] + "" + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkh] + db.Rows[0][2].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkh] + "" + Environment.NewLine;

                vitriPL = textTitle[(int)myTextTitle.vtpl] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.ho] + db.Rows[0][4].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.bo] + db.Rows[0][3].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.lop] + "" + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.nganh] + "" + Environment.NewLine;

                phanbo = textTitle[(int)myTextTitle.phanbo] + Environment.NewLine;
                if (db.Rows[0][5].ToString() != "")
                {
                    phanbo += "    " + db.Rows[0][5].ToString() + Environment.NewLine;
                }

                tachai = textTitle[(int)myTextTitle.tachai] + Environment.NewLine;
                if (db.Rows[0][6].ToString() != "")
                {
                    tachai += "    " + db.Rows[0][6].ToString() + Environment.NewLine;
                }


                mdxh = textTitle[(int)myTextTitle.mucdoxh] + Environment.NewLine;



                dd = textTitle[(int)myTextTitle.dacdiemnd] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.ddht] + db.Rows[0][7].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.ddsh] + db.Rows[0][8].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.bppt] + db.Rows[0][9].ToString() + Environment.NewLine; ;

                gdbq = textTitle[(int)myTextTitle.gdbq] + Environment.NewLine;

                ls = textTitle[(int)myTextTitle.lsphvn] + Environment.NewLine;

                tailieu = textTitle[(int)myTextTitle.tlphvn] + Environment.NewLine;

                string sqlAnh = "SELECT Img_data, Img_Name from tblAnhSHC WHERE ID_SHChinh = " + id + " and IsShow = 1";
                DataTable dbA = database_helper.GetDataTable(sqlAnh);
                if (dbA.Rows.Count > 0)
                {
                    try
                    {
                        DataRowView drv = dbA.DefaultView[0];

                        Byte[] i = (byte[])drv[0];
                        MemoryStream stmBLOBData = new MemoryStream(i);
                        img.Image = Image.FromStream(stmBLOBData);

                        lblTB.Text = dbA.Rows[0][1].ToString();
                        btnA.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        img.Image = Properties.Resources.imgdefault;
                        lblTB.Text = "Không load được ảnh";
                        btnA.Enabled = false;
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    img.Image = Properties.Resources.imgdefault;
                    lblTB.Text = "Chưa có ảnh";
                    btnA.Enabled = false;
                }
                show();
            }
            else if (this.loai == 2)
            {
                //string sql = "SELECT * FROM tblBHChinh where ID_BHChinh = " + id;
                //DataTable db = database_helper.GetDataTable(sql);

                ten = textTitle[(int)myTextTitle.tenloai] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvn] + db.Rows[0][1].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvnk] + "" + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkh] + "" + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkh] + "" + Environment.NewLine;

                vitriPL = textTitle[(int)myTextTitle.vtpl] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.ho] + "" + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.bo] + "" + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.lop] + "" + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.nganh] + "" + Environment.NewLine;

                phanbo = textTitle[(int)myTextTitle.phanbo] + Environment.NewLine;

                tachai = textTitle[(int)myTextTitle.tachai] + Environment.NewLine;
                if (db.Rows[0][3].ToString() != "")
                {
                    tachai += "    " + db.Rows[0][3].ToString() + Environment.NewLine;
                }


                mdxh = textTitle[(int)myTextTitle.mucdoxh] + Environment.NewLine;



                dd = textTitle[(int)myTextTitle.dacdiemnd] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.nguyennhan] + db.Rows[0][2].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.ddht] + db.Rows[0][4].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.bppt] + db.Rows[0][5].ToString() + Environment.NewLine; ;

                gdbq = textTitle[(int)myTextTitle.gdbq] + Environment.NewLine;

                ls = textTitle[(int)myTextTitle.lsphvn] + Environment.NewLine;

                tailieu = textTitle[(int)myTextTitle.tlphvn] + Environment.NewLine;

                string sqlAnh = "SELECT Img_data, Img_Name from tblAnhBHC WHERE ID_BHChinh = " + id + " and IsShow = 1";
                DataTable dbA = database_helper.GetDataTable(sqlAnh);
                if (dbA.Rows.Count > 0)
                {
                    try
                    {
                        DataRowView drv = dbA.DefaultView[0];

                        Byte[] i = (byte[])drv[0];
                        MemoryStream stmBLOBData = new MemoryStream(i);
                        img.Image = Image.FromStream(stmBLOBData);

                        lblTB.Text = dbA.Rows[0][1].ToString();
                        btnA.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        img.Image = Properties.Resources.imgdefault;
                        lblTB.Text = "Không load được ảnh";
                        btnA.Enabled = false;
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    img.Image = Properties.Resources.imgdefault;
                    lblTB.Text = "Chưa có ảnh";
                    btnA.Enabled = false;
                }
                show();
            }
        }

        private void show()
        {
            string data = "";
            if (cbTL.Checked)
                data += ten;
            if (cbPL.Checked)
                data += vitriPL;
            if (cbPB.Checked)
                data += phanbo;
            if (cbTH.Checked)
                data += tachai;
            if (cbXH.Checked)
                data += mdxh;
            if (cbDD.Checked)
                data += dd;
            if (cbBQ.Checked)
                data += gdbq;
            if (cbLSVN.Checked)
                data += ls;
            if (cbPHVN.Checked)
                data += tailieu;

            txt.Text = data;

            //int[] newar = new int[10];
            //bool check = true;
            //for (int i = 0; i < textTitle.Length; i++)
            //{
            //    int start = data.IndexOf(textTitle[i]);
            //    if (start != -1)
            //    {
            //        if (check)
            //            newar[i] = 0;
            //        else
            //            newar[i] = newar[i-1] + old[i];

            //        check = false;

            //        MessageBox.Show(newar[i].ToString());

            //        if (start != 0)
            //            start -= newar[i];
            //        txt.Select(start, textTitle[i].Length);
            //        txt.SelectionColor = Color.Red;
            //        txt.SelectionFont = new Font(txt.Font.Name, 20, FontStyle.Bold);
            //    }
            //    else
            //    {
            //        old[i + 1] -= old[i];
            //    }
            //}

            //for (int i = 0; i < textContent.Length; i++)
            //{
            //    int start = data.IndexOf(textContent[i]);
            //    if (start != -1)
            //    {
            //        txt.Select(start, textContent[i].Length);
            //        txt.SelectionColor = Color.Blue;
            //        txt.SelectionFont = new Font(txt.Font.Name, 15, FontStyle.Bold);
            //    }
            //}
        }

        private void getAll()
        {
            cbTL.Checked = cbPL.Checked = cbPB.Checked = cbTH.Checked = cbXH.Checked = cbDD.Checked = cbBQ.Checked = cbLSVN.Checked = cbPHVN.Checked = cb.Checked;
        }

        private void checkGetAll()
        {
            if (!cb.Checked)
            {
                if (!cbTL.Checked || !cbPL.Checked || !cbBQ.Checked || !cbDD.Checked || !cbLSVN.Checked || !cbPB.Checked || !cbPHVN.Checked || !cbTH.Checked || !cbXH.Checked)
                {
                    cb.Text = "Chọn tất cả";
                    cb.Checked = false;
                }
            }
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if (cb.Checked)
            {
                cb.Text = "Bỏ chọn hết";
                getAll();
            }
            else
            {
                cb.Text = "Chọn tất cả";
                getAll();
                cbTL.Checked = true;
                cbPL.Checked = true;
            }
        }
        private void cbItem_CheckedChanged(object sender, EventArgs e)
        {
            txt.Text = "";
            show();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            frmViewImage mfrmViewImage = new frmViewImage(this.id, this.loai);
            mfrmViewImage.ShowDialog();
        }
    }
}
