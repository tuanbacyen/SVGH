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
    public partial class frmChiTietSHC : Form
    {
        #region
        DataTable db;
        string ten = "";
        string vitriPL = "";
        string phanbo = "";
        string ddgh = "";
        string ddht = "";
        string ddsh = "";
        string bppc = "";


        string id = "";

        enum myTextTitle { tenloai, vtpl, phanbo, ddgh, ddht, ddsh, bppc };
        string[] textTitle = { "Tên Loài", "Vị trí phân loại", "Phân bố", "Đặc điểm gây hại", "Đặc điểm hình thái", "Đặc điểm sinh học, sinh thái", "Biện pháp phòng chống" };
        enum myTextContent { tenvn, tenvnk, tenkh, tenkhk, tenen, ho, bo, lop, nganh };
        string[] textContent = { "Tên Việt Nam: ", "Tên Việt Nam khác: ", "Tên khoa học: ", "Tên khoa học khác: ", "Tên tiếng anh: ", "Họ: ", "Bộ: ", "Lớp: ", "Ngành: " };

        int[] old = { 0, 5, 5, 2, 2, 1, 1, 1, 3, 1 };
        int[] test = { 0, 5, 10, 12, 14, 15, 16, 17, 20 };
        #endregion

        public frmChiTietSHC(string id)
        {
            InitializeComponent();
            this.id = id;
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

        private void frmChiTietSHC_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblSHChinh where ID_SHChinh = " + id;
            db = database_helper.GetDataTable(sql);
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            frmViewImage mfrmViewImage = new frmViewImage(this.id, 1);
            mfrmViewImage.ShowDialog();
        }

        private void cbItem_CheckedChanged(object sender, EventArgs e)
        {
            txt.Text = "";
            show();
        }

        private void getData()
        {
            ten = textTitle[(int)myTextTitle.tenloai] + Environment.NewLine +
                "    " + textContent[(int)myTextContent.tenvn] + db.Rows[0][1].ToString() + Environment.NewLine +
                "    " + textContent[(int)myTextContent.tenvnk] + "" + Environment.NewLine +
                "    " + textContent[(int)myTextContent.tenkh] + db.Rows[0][2].ToString() + Environment.NewLine +
                "    " + textContent[(int)myTextContent.tenkh] + "" + Environment.NewLine +
                "    " + textContent[(int)myTextContent.tenen] + "" + Environment.NewLine;

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

            ddgh = textTitle[(int)myTextTitle.ddgh] + Environment.NewLine;
            if (db.Rows[0][6].ToString() != "")
            {
                ddgh += "    " + db.Rows[0][6].ToString() + Environment.NewLine;
            }

            ddht = textTitle[(int)myTextTitle.ddht] + Environment.NewLine;
            if (db.Rows[0][7].ToString() != "")
            {
                ddht += "    " + db.Rows[0][7].ToString() + Environment.NewLine;
            }

            ddsh = textTitle[(int)myTextTitle.ddsh] + Environment.NewLine;
            if (db.Rows[0][8].ToString() != "")
            {
                ddsh += "    " + db.Rows[0][8].ToString() + Environment.NewLine;
            }

            bppc = textTitle[(int)myTextTitle.bppc] + Environment.NewLine;
            if (db.Rows[0][9].ToString() != "")
            {
                bppc += "    " + db.Rows[0][9].ToString() + Environment.NewLine;
            }

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

        private void show()
        {
            string data = "";
            if (cbTL.Checked)
                data += ten;
            if (cbPL.Checked)
                data += vitriPL;
            if (cbPB.Checked)
                data += phanbo;
            if (cbDDGH.Checked)
                data += ddgh;
            if (cbDDHT.Checked)
                data += ddht;
            if (cbDDSHST.Checked)
                data += ddsh;
            if (cbBPPC.Checked)
                data += bppc;

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
            cbTL.Checked = cbPL.Checked = cbPB.Checked = cbDDGH.Checked = cbDDHT.Checked = cbDDSHST.Checked = cbBPPC.Checked = cb.Checked;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (txt.Text.Trim().Length > 0)
            {
                //e.Graphics.DrawString(txt.Text.Trim(), new Font("Time New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100), StringFormat.GenericTypographic);
                Graphics gf = e.Graphics;
                SizeF sf = gf.MeasureString(txt.Text.Trim(),
                                new Font(new FontFamily("Arial"), 10F), 700);
                gf.DrawString(txt.Text.Trim(),
                                new Font(new FontFamily("Arial"), 10F), Brushes.Black,
                                new RectangleF(new PointF(100, 100), sf),
                                StringFormat.GenericTypographic);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để in");
            }
        }
    }
}
