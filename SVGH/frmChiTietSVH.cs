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

        string id = "";
        enum myTextTitle { tenloai, vtpl, phanbo, ttph, tgph, tacdong };
        string[] textTitle = { "Tên Loài", "Vị trí phân loại", "Phân bố", "Tình trạng phát hiện", "Thời gian phát hiện", "Tác động" };

        enum myTextContent { tenvn, tenvnk, tenkh, tenkhk, tenen, ho, bo, lop, nganh };
        string[] textContent = { "Tên Việt Nam: ", "Tên Việt Nam khác: ", "Tên khoa học: ", "Tên khoa học khác: ", "Tên tiếng anh: ", "Họ: ", "Bộ: ", "Lớp: ", "Ngành: " };

        int[] old = { 0, 6, 5, 2, 2, 2, 2 };
        int[] oldContent = {0, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1 };
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
            ten = textTitle[(int)myTextTitle.tenloai] + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvn] + db.Rows[0][3].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenvnk] + db.Rows[0][4].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkh] + db.Rows[0][5].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenkhk] + db.Rows[0][6].ToString() + Environment.NewLine +
                    "    " + textContent[(int)myTextContent.tenen] + db.Rows[0][7].ToString() + Environment.NewLine;

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

            ttph = textTitle[(int)myTextTitle.ttph] + Environment.NewLine;
            if (db.Rows[0][11].ToString() != "")
            {
                ttph += "    " + db.Rows[0][11].ToString() + Environment.NewLine;
            }

            tgph = textTitle[(int)myTextTitle.tgph] + Environment.NewLine;
            if (db.Rows[0][10].ToString() != "")
            {
                tgph += "    " + db.Rows[0][10].ToString() + Environment.NewLine;
            }

            tacdong = textTitle[(int)myTextTitle.tacdong] + Environment.NewLine;
            if (db.Rows[0][8].ToString() != "")
            {
                tacdong += "    " + db.Rows[0][8].ToString() + Environment.NewLine;
            }


            img.Image = Properties.Resources.imgdefault;
            lblTB.Text = "Chưa có ảnh";
            btnA.Enabled = false;

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
            if (cbTTPH.Checked)
                data += ttph;
            if (cbTG.Checked)
                data += tgph;
            if (cbBP.Checked)
                data += tacdong;

            txt.Text = data;

            int wrapTitle = 0;
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

            int wrapContent = 2;
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
