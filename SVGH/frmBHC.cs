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
    public partial class frmBHC : Form
    {
        #region
        int showName = 0;
        #endregion

        public frmBHC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbPVKC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPVKC.Items.Count > 0)
            {
                showdata();
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
                dtgBHC.Columns["TenVN"].Visible = true;
                dtgBHC.Columns["TenKH"].Visible = false;
                showName = 0;
            }
            else if (rdkh.Checked)
            {
                dtgBHC.Columns["TenVN"].Visible = false;
                dtgBHC.Columns["TenKH"].Visible = true;
                showName = 1;
            }
            else if (rdch.Checked)
            {
                dtgBHC.Columns["TenVN"].Visible = true;
                dtgBHC.Columns["TenKH"].Visible = true;
                showName = 2;
            }
            showdata();
        }

        private void frmBHC_Load(object sender, EventArgs e)
        {
            showdata();
            loadPhamVi();
        }

        private void dtgBHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgBHC.Rows.Count > 0)
            {
                getImageToShow(dtgBHC.Rows[e.RowIndex].Cells["ID_BHChinh"].Value.ToString());
            }
            dtgBHC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showdata();
        }

        #region
        private void xemct()
        {

        }

        private void showdata()
        {
            string idCay = "";

            if (cbPVKC.Items.Count > 0)
            {
                idCay = cbPVKC.SelectedValue.ToString();
            }

            string sql = "SELECT ID_BHChinh,TenVN,TenKH FROM tblBHChinh ";
            bool check = false;

            if (idCay != "all" && idCay != "")
            {
                sql = sql + " where ID_Cay = '" + idCay + "' ";
                check = true;
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

            dtgBHC.DataSource = database_helper.GetDataTable(sql);
            if (dtgBHC.Rows.Count > 0)
            {
                dtgBHC.Rows[0].Selected = true;
                getImageToShow(dtgBHC.Rows[0].Cells["ID_BHChinh"].Value.ToString());
            }
            else
            {
                imgLoad.Image = null;
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

        private void getImageToShow(string id)
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
        #endregion
    }
}