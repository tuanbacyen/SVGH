using SVGH.Database;
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
    public partial class frmChiTietSVH : Form
    {
        #region
        DataTable db;
        string ten = "";
        string vitriPL = "";
        string phanbo = "";
        string ttph = "";
        string tgph = "";
        string tacdong = "";
        string tenNhom = "";

        string id = "";
        enum myTextTitle { tenloai, vtpl, phanbo, ttph, tgph, bophanbihai, qhddvsh, nsh };
        string[] textTitle = { "Tên Loài", "Vị trí phân loại", "Phân bố", "Tình trạng phát hiện", "Thời gian phát hiện", "Bộ phận bị hại", "Quan hệ dinh dưỡng với sâu hại", "Nhóm sâu hại" };

        enum myTextContent { tenvn, tenvnk, tenkh, tenkhk, tenen };
        string[] textContent = { "Tên Việt Nam: ", "Tên Việt Nam khác: ", "Tên khoa học: ", "Tên khoa học khác: ", "Tên tiếng anh: " };

        int[] old = { 0, 6, 5, 2, 2, 2, 2, 2, 2, 2 };
        int[] oldContent = { 0, 1, 1, 1, 1, 1, 2 };
        #endregion

        public frmChiTietSVH(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Size = new System.Drawing.Size((int)Screen.PrimaryScreen.Bounds.Width / 3 * 2,
            Screen.PrimaryScreen.Bounds.Height - 100);
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.5;

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
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



        private void btnA_Click(object sender, EventArgs e)
        {
            frmViewImage mfrmViewImage = new frmViewImage(this.id, 0);
            mfrmViewImage.ShowDialog();
        }

        private void frmChiTietSVH_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblSVH where ID_SVH = " + id;
            db = database_helper.GetDataTable(sql);
            getData();
        }

        private void getData()
        {
            tenNhom = db.Rows[0]["Nhom"].ToString() + Environment.NewLine;

            ten = textTitle[(int)myTextTitle.tenloai] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvn] + db.Rows[0]["TenVN"].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvnk] + db.Rows[0]["TenVN_Khac"].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkh] + db.Rows[0]["TenKH"].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkhk] + db.Rows[0]["TenKH_Khac"].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenen] + db.Rows[0]["TenEN"].ToString() + Environment.NewLine;

            vitriPL = textTitle[(int)myTextTitle.vtpl] + Environment.NewLine +
                "    " + db.Rows[0]["Nganh"].ToString() + Environment.NewLine +
                "    " + db.Rows[0]["Lop"].ToString() + Environment.NewLine +
                "    " + db.Rows[0]["Bo"].ToString() + Environment.NewLine +
                "    " + db.Rows[0]["Ho"].ToString() + Environment.NewLine;

            phanbo = textTitle[(int)myTextTitle.phanbo] + Environment.NewLine;
            if (db.Rows[0]["Dia_Diem_PH"].ToString() != "")
            {
                phanbo += "    " + db.Rows[0]["Dia_Diem_PH"].ToString() + Environment.NewLine;
            }

            ttph = textTitle[(int)myTextTitle.ttph] + Environment.NewLine;
            if (db.Rows[0]["Tinh_Trang_PH"].ToString() != "")
            {
                ttph += "    " + db.Rows[0]["Tinh_Trang_PH"].ToString() + Environment.NewLine;
            }

            tgph = textTitle[(int)myTextTitle.tgph] + Environment.NewLine;
            if (db.Rows[0]["Thoi_Gian_PH"].ToString() != "")
            {
                tgph += "    " + db.Rows[0]["Thoi_Gian_PH"].ToString() + Environment.NewLine;
            }

            if (db.Rows[0]["ID_NhomSVH"].ToString() == "NHOM01" || db.Rows[0]["ID_NhomSVH"].ToString() == "NHOM04")
                tacdong = textTitle[(int)myTextTitle.bophanbihai] + Environment.NewLine;
            else if (db.Rows[0]["ID_NhomSVH"].ToString() == "NHOM03")
                tacdong = textTitle[(int)myTextTitle.qhddvsh] + Environment.NewLine;
            else if (db.Rows[0]["ID_NhomSVH"].ToString() == "NHOM02" || db.Rows[0]["ID_NhomSVH"].ToString() == "NHOM05")
                tacdong = textTitle[(int)myTextTitle.nsh] + Environment.NewLine;

            if (db.Rows[0]["Tac_Dong"].ToString() != "")
            {
                tacdong += "    " + db.Rows[0]["Tac_Dong"].ToString() + Environment.NewLine;
            }


            img.Image = Properties.Resources.imgdefault;
            lblTB.Text = "Chưa có ảnh";
            btnA.Enabled = false;

            show();
        }

        private void show()
        {
            string data = "";
            data += tenNhom;
            if (cbTL.Checked)
                data += ten;
            if (cbPL.Checked)
                data += vitriPL;
            if (cbPB.Checked)
                data += phanbo;
            if (cbTTPH.Checked)
                data += ttph;
            if (cbTG.Checked)
                data += tgph;
            if (cbBP.Checked)
                data += tacdong;

            txt.Text = data;

            int wrapTitle = 1;
            for (int i = 0; i < textTitle.Length; i++)
            {
                int start = data.IndexOf(textTitle[i]);
                if (start != -1)
                {
                    start -= wrapTitle;
                    wrapTitle += old[i + 1];
                    txt.Select(start, textTitle[i].Length);
                    txt.SelectionColor = Color.Red;
                    txt.SelectionFont = new Font(txt.Font.Name, 20, FontStyle.Bold);
                }
            }

            int wrapContent = 3;
            for (int i = 0; i < textContent.Length; i++)
            {
                int start = data.IndexOf(textContent[i]);
                if (start != -1)
                {
                    start -= wrapContent;
                    wrapContent += oldContent[i + 1];
                    txt.Select(start, textContent[i].Length);
                    txt.SelectionColor = Color.Blue;
                    txt.SelectionFont = new Font(txt.Font.Name, 17, FontStyle.Bold);
                }
            }
        }

        private void cbItem_CheckedChanged(object sender, EventArgs e)
        {
            txt.Text = "";
            show();
        }

        private void getAll()
        {
            cbTL.Checked = cbPL.Checked = cbPB.Checked = cbTTPH.Checked = cbTG.Checked = cbBP.Checked = cb.Checked;
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
