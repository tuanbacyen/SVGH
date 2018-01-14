using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SVGH
{
    public partial class frmViewImage : Form
    {
        string id = "";
        int loai = 0;
        DataTable db;

        public frmViewImage(string id, int loai)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.id = id;
            this.loai = loai;
        }

        private void myShowImg()
        {
            int withI = 80;
            int heightI = 80;
            int x = 0;
            int y = 10;
            int maxheight = -1;

            for (int i = 0; i < db.Rows.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Name = "" + i;
                pic.Location = new Point(x, y);
                pic.Width = withI;
                pic.Height = heightI;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Click += click_itemImg;
                x += pic.Width + 10;
                maxheight = Math.Max(pic.Height, maxheight);

                if (x > this.panel.Width - 90)
                {
                    x = 20;
                    y += maxheight + 10;
                }
                try
                {
                    DataRowView drv = db.DefaultView[i];
                    Byte[] image = (byte[])drv[0];
                    MemoryStream stmBLOBData = new MemoryStream(image);
                    pic.Image = Image.FromStream(stmBLOBData);
                    if(i == 0)
                    {
                        imgBigShow.Image = pic.Image;
                        lblName.Text = db.Rows[0][1].ToString();
                    }
                }
                catch (Exception ex)
                {
                    pic.Image = Properties.Resources.imgdefault;
                    if(i == 0)
                    {
                        lblName.Text = "Ảnh bị lỗi không hiển thị được";
                    }
                }
                this.panel.Controls.Add(pic);
            }
        }

        private void click_itemImg(object sender, EventArgs e)
        {
            PictureBox picI = (sender as PictureBox);
            lblName.Text = db.Rows[int.Parse(picI.Name)][1].ToString();
            try
            {
                imgBigShow.Image = picI.Image;
            }
            catch (Exception ex)
            {
                imgBigShow.Image = Properties.Resources.imgdefault;
            }
        }

        private void frmViewImage_Load(object sender, EventArgs e)
        {
            string sql = "";
            if(loai == 1)
            {
                sql = "SELECT Img_Data, Img_Name, Img_Des from tblAnhSHC where ID_SHChinh = " + id;
            }
            else if(loai == 2)
            {
                sql = "SELECT Img_Data, Img_Name, Img_Des from tblAnhBHC where ID_BHChinh = " + id;
            }
            
            db = database_helper.GetDataTable(sql);
            myShowImg();
        }
    }
}
