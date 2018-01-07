﻿using SVGH.Database;
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
    public partial class frmChiTietBHC : Form
    {
        #region
        DataTable db;
        string ten = "";
        string nn = "";
        string tc = "";
        string ddps = "";
        string bppc = "";

        string id = "";

        enum myTextTitle { tenloai, nn, tc, ddps, bppc };
        string[] textTitle = { "Tên Loài", "Nguyên nhân", "Triệu chứng", "Đặc điểm phát sinh", "Biện pháp phòng chánh" };

        enum myTextContent { tenvn };
        string[] textContent = { "Tên Việt Nam: " };

        int[] old = { 0, 5, 5, 2, 2, 1, 1, 1, 3, 1 };
        int[] test = { 0, 5, 10, 12, 14, 15, 16, 17, 20 };
        #endregion

        public frmChiTietBHC(string id)
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
                cbNN.Checked = true;
            }
        }

        private void frmChiTietBHC_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblBHChinh where ID_BHChinh = " + id;
            db = database_helper.GetDataTable(sql);

            getData();
        }

        private void getData()
        {
            ten = textTitle[(int)myTextTitle.tenloai] + Environment.NewLine +
                "    " + textContent[(int)myTextContent.tenvn] + db.Rows[0][1].ToString() + Environment.NewLine;

            nn = textTitle[(int)myTextTitle.nn] + Environment.NewLine;
            if (db.Rows[0][2].ToString() != "")
            {
                nn += "    " + db.Rows[0][2].ToString() + Environment.NewLine;
            }

            tc = textTitle[(int)myTextTitle.tc] + Environment.NewLine;
            if (db.Rows[0][3].ToString() != "")
            {
                tc += "    " + db.Rows[0][3].ToString() + Environment.NewLine;
            }

            ddps = textTitle[(int)myTextTitle.ddps] + Environment.NewLine;
            if (db.Rows[0][4].ToString() != "")
            {
                ddps += "    " + db.Rows[0][4].ToString() + Environment.NewLine;
            }

            bppc = textTitle[(int)myTextTitle.bppc] + Environment.NewLine;
            if (db.Rows[0][5].ToString() != "")
            {
                bppc += "    " + db.Rows[0][5].ToString() + Environment.NewLine;
            }

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

        private void show()
        {
            string data = "";
            if (cbTL.Checked)
                data += ten;
            if (cbNN.Checked)
                data += nn;
            if (cbTC.Checked)
                data += tc;
            if (cbDDPS.Checked)
                data += ddps;
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
            cbTL.Checked = cbNN.Checked = cbTC.Checked = cbDDPS.Checked = cbBPPC.Checked = cb.Checked;
        }

        private void cbItem_CheckedChanged(object sender, EventArgs e)
        {
            txt.Text = "";
            show();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            frmViewImage mfrmViewImage = new frmViewImage(this.id, 2);
            mfrmViewImage.ShowDialog();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if(txt.Text.Trim().Length > 0)
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
