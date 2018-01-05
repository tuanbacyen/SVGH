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
    public partial class frmChiTiet : Form
    {
        #region
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
        int loai = 0;
        #endregion

        public frmChiTiet(string id, int loai)
        {
            InitializeComponent();
            this.id = id;
            this.loai = loai;
            //string rstr = "<span style='color:red'>"+ Environment.NewLine + "ahasdhaius</span><span style='color:red'>ahsgdihasdhaius</span>";
            //txt.Text = rstr;
            //txt.Select(0, replaceColor.Length-5);
            //txt.SelectionColor = Color.Red;
            //txt.SelectionFont = new Font(txt.Font.Name, 40,FontStyle.Bold);
            //txt.Select(replaceColor.Length - 5, replaceColor.Length);
            //txt.SelectionColor = Color.Blue;


        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            if (this.loai == 0)
            {
                string sql = "SELECT * FROM tblSVH where ID_SVH = " + id;
                DataTable db = database_helper.GetDataTable(sql);

                ten = "Tên Loài" + Environment.NewLine + "    Tên Việt Nam: " + db.Rows[0][3].ToString() + Environment.NewLine + "    Tên Việt Nam khác: " + db.Rows[0][4].ToString() + Environment.NewLine + "    Tên khoa học: " + db.Rows[0][5].ToString() + Environment.NewLine + "    Tên khoa học khác: " + db.Rows[0][6].ToString() + Environment.NewLine;

                vitriPL = "Vị trí phân loại" + Environment.NewLine + "    Họ: " + db.Rows[0][12].ToString() + Environment.NewLine + "    Bộ: " + db.Rows[0][13].ToString() + Environment.NewLine + "    Lớp: " + db.Rows[0][14].ToString() + Environment.NewLine + "    Ngành: " + db.Rows[0][15].ToString() + Environment.NewLine;

                if (db.Rows[0][9].ToString() != "")
                {
                    phanbo = "Phân bố" + Environment.NewLine + "    " + db.Rows[0][9].ToString() + Environment.NewLine;
                }

                if (db.Rows[0][8].ToString() != "")
                {
                    tachai = "Tác hại" + Environment.NewLine + "    " + db.Rows[0][8].ToString() + Environment.NewLine;
                }

                mdxh = "Mức độ xuất hiện" + Environment.NewLine;
                dd = "Đặc điểm chỉnh của pha trưởng thành để nhận dạng" + Environment.NewLine;
                gdbq = "Giám định bảo quản" + Environment.NewLine;
                ls = "Lịch sử phát hiện ở Việt Nam" + Environment.NewLine + "    Tình trạng phát hiện " + db.Rows[0][11].ToString() + Environment.NewLine + "    Thời gian phát hiện: " + db.Rows[0][10].ToString() + Environment.NewLine;
                tailieu = "Tài liệu công bố phát hiện ở việt nam" + Environment.NewLine;

                img.Image = Properties.Resources.imgdefault;
                lblTB.Text = "Chưa có ảnh";
                btnA.Enabled = false;
            }
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
        }

        private void getAll()
        {
            cbTL.Checked = cbPL.Checked = cbBQ.Checked = cbDD.Checked = cbLSVN.Checked = cbPB.Checked = cbPHVN.Checked = cbTH.Checked = cbXH.Checked = cb.Checked;
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
            getData();
        }
    }
}
