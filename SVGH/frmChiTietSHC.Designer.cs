﻿namespace SVGH
{
    partial class frmChiTietSHC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietSHC));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.lblTB = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDDSHST = new System.Windows.Forms.CheckBox();
            this.cbDDHT = new System.Windows.Forms.CheckBox();
            this.cbBPPC = new System.Windows.Forms.CheckBox();
            this.cbDDGH = new System.Windows.Forms.CheckBox();
            this.cbPB = new System.Windows.Forms.CheckBox();
            this.cbPL = new System.Windows.Forms.CheckBox();
            this.cbTL = new System.Windows.Forms.CheckBox();
            this.cb = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.img);
            this.groupBox2.Controls.Add(this.btnA);
            this.groupBox2.Controls.Add(this.lblTB);
            this.groupBox2.Location = new System.Drawing.Point(574, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 234);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa thông tin";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(6, 19);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(288, 183);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 2;
            this.img.TabStop = false;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(219, 202);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 26);
            this.btnA.TabIndex = 5;
            this.btnA.Text = "Xem ảnh lớn";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTB.Location = new System.Drawing.Point(13, 207);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(45, 16);
            this.lblTB.TabIndex = 4;
            this.lblTB.Text = "label1";
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(12, 12);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(556, 474);
            this.txt.TabIndex = 8;
            this.txt.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbDDSHST);
            this.groupBox1.Controls.Add(this.cbDDHT);
            this.groupBox1.Controls.Add(this.cbBPPC);
            this.groupBox1.Controls.Add(this.cbDDGH);
            this.groupBox1.Controls.Add(this.cbPB);
            this.groupBox1.Controls.Add(this.cbPL);
            this.groupBox1.Controls.Add(this.cbTL);
            this.groupBox1.Controls.Add(this.cb);
            this.groupBox1.Location = new System.Drawing.Point(574, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 211);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa thông tin";
            // 
            // cbDDSHST
            // 
            this.cbDDSHST.AutoSize = true;
            this.cbDDSHST.Location = new System.Drawing.Point(16, 164);
            this.cbDDSHST.Name = "cbDDSHST";
            this.cbDDSHST.Size = new System.Drawing.Size(160, 17);
            this.cbDDSHST.TabIndex = 9;
            this.cbDDSHST.Text = "Đặc điểm sinh học, sinh thái";
            this.cbDDSHST.UseVisualStyleBackColor = true;
            this.cbDDSHST.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbDDHT
            // 
            this.cbDDHT.AutoSize = true;
            this.cbDDHT.Location = new System.Drawing.Point(16, 141);
            this.cbDDHT.Name = "cbDDHT";
            this.cbDDHT.Size = new System.Drawing.Size(115, 17);
            this.cbDDHT.TabIndex = 8;
            this.cbDDHT.Text = "Đặc điểm hình thái";
            this.cbDDHT.UseVisualStyleBackColor = true;
            this.cbDDHT.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbBPPC
            // 
            this.cbBPPC.AutoSize = true;
            this.cbBPPC.Location = new System.Drawing.Point(16, 187);
            this.cbBPPC.Name = "cbBPPC";
            this.cbBPPC.Size = new System.Drawing.Size(140, 17);
            this.cbBPPC.TabIndex = 6;
            this.cbBPPC.Text = "Biện pháp phòng chống";
            this.cbBPPC.UseVisualStyleBackColor = true;
            this.cbBPPC.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbDDGH
            // 
            this.cbDDGH.AutoSize = true;
            this.cbDDGH.Location = new System.Drawing.Point(16, 118);
            this.cbDDGH.Name = "cbDDGH";
            this.cbDDGH.Size = new System.Drawing.Size(109, 17);
            this.cbDDGH.TabIndex = 4;
            this.cbDDGH.Text = "Đặc điểm gây hại";
            this.cbDDGH.UseVisualStyleBackColor = true;
            this.cbDDGH.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbPB
            // 
            this.cbPB.AutoSize = true;
            this.cbPB.Location = new System.Drawing.Point(16, 95);
            this.cbPB.Name = "cbPB";
            this.cbPB.Size = new System.Drawing.Size(66, 17);
            this.cbPB.TabIndex = 3;
            this.cbPB.Text = "Phân bổ";
            this.cbPB.UseVisualStyleBackColor = true;
            this.cbPB.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbPL
            // 
            this.cbPL.AutoSize = true;
            this.cbPL.Checked = true;
            this.cbPL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPL.Location = new System.Drawing.Point(16, 72);
            this.cbPL.Name = "cbPL";
            this.cbPL.Size = new System.Drawing.Size(94, 17);
            this.cbPL.TabIndex = 2;
            this.cbPL.Text = "Vị trí phân loại";
            this.cbPL.UseVisualStyleBackColor = true;
            this.cbPL.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbTL
            // 
            this.cbTL.AutoSize = true;
            this.cbTL.Checked = true;
            this.cbTL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTL.Location = new System.Drawing.Point(16, 49);
            this.cbTL.Name = "cbTL";
            this.cbTL.Size = new System.Drawing.Size(64, 17);
            this.cbTL.TabIndex = 1;
            this.cbTL.Text = "Tên loài";
            this.cbTL.UseVisualStyleBackColor = true;
            this.cbTL.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.Location = new System.Drawing.Point(16, 26);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(81, 17);
            this.cb.TabIndex = 0;
            this.cb.Text = "Chọn tất cả";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(752, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(635, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "In thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmChiTietSHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChiTietSHC";
            this.Text = "Chi tiết sâu hại chính";
            this.Load += new System.EventHandler(this.frmChiTietSHC_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDDSHST;
        private System.Windows.Forms.CheckBox cbDDHT;
        private System.Windows.Forms.CheckBox cbBPPC;
        private System.Windows.Forms.CheckBox cbDDGH;
        private System.Windows.Forms.CheckBox cbPB;
        private System.Windows.Forms.CheckBox cbPL;
        private System.Windows.Forms.CheckBox cbTL;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}