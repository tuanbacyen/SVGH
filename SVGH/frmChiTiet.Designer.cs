namespace SVGH
{
    partial class frmChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTiet));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.img = new System.Windows.Forms.PictureBox();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.lblTB = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb = new System.Windows.Forms.CheckBox();
            this.cbTL = new System.Windows.Forms.CheckBox();
            this.cbPL = new System.Windows.Forms.CheckBox();
            this.cbPB = new System.Windows.Forms.CheckBox();
            this.cbTH = new System.Windows.Forms.CheckBox();
            this.cbXH = new System.Windows.Forms.CheckBox();
            this.cbDD = new System.Windows.Forms.CheckBox();
            this.cbBQ = new System.Windows.Forms.CheckBox();
            this.cbLSVN = new System.Windows.Forms.CheckBox();
            this.cbPHVN = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1154, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
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
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(12, 28);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(819, 418);
            this.txt.TabIndex = 3;
            this.txt.Text = "";
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
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(219, 202);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 26);
            this.btnA.TabIndex = 5;
            this.btnA.Text = "Xem ảnh lớn";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbPHVN);
            this.groupBox1.Controls.Add(this.cbLSVN);
            this.groupBox1.Controls.Add(this.cbBQ);
            this.groupBox1.Controls.Add(this.cbDD);
            this.groupBox1.Controls.Add(this.cbXH);
            this.groupBox1.Controls.Add(this.cbTH);
            this.groupBox1.Controls.Add(this.cbPB);
            this.groupBox1.Controls.Add(this.cbPL);
            this.groupBox1.Controls.Add(this.cbTL);
            this.groupBox1.Controls.Add(this.cb);
            this.groupBox1.Location = new System.Drawing.Point(837, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 186);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa thông tin";
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
            // cbPL
            // 
            this.cbPL.AutoSize = true;
            this.cbPL.Checked = true;
            this.cbPL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPL.Location = new System.Drawing.Point(126, 49);
            this.cbPL.Name = "cbPL";
            this.cbPL.Size = new System.Drawing.Size(94, 17);
            this.cbPL.TabIndex = 2;
            this.cbPL.Text = "Vị trí phân loại";
            this.cbPL.UseVisualStyleBackColor = true;
            this.cbPL.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbPB
            // 
            this.cbPB.AutoSize = true;
            this.cbPB.Location = new System.Drawing.Point(16, 72);
            this.cbPB.Name = "cbPB";
            this.cbPB.Size = new System.Drawing.Size(66, 17);
            this.cbPB.TabIndex = 3;
            this.cbPB.Text = "Phân bổ";
            this.cbPB.UseVisualStyleBackColor = true;
            this.cbPB.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbTH
            // 
            this.cbTH.AutoSize = true;
            this.cbTH.Location = new System.Drawing.Point(16, 95);
            this.cbTH.Name = "cbTH";
            this.cbTH.Size = new System.Drawing.Size(62, 17);
            this.cbTH.TabIndex = 4;
            this.cbTH.Text = "Tác hại";
            this.cbTH.UseVisualStyleBackColor = true;
            this.cbTH.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbXH
            // 
            this.cbXH.AutoSize = true;
            this.cbXH.Location = new System.Drawing.Point(126, 72);
            this.cbXH.Name = "cbXH";
            this.cbXH.Size = new System.Drawing.Size(109, 17);
            this.cbXH.TabIndex = 5;
            this.cbXH.Text = "Mức độ xuất hiện";
            this.cbXH.UseVisualStyleBackColor = true;
            this.cbXH.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbDD
            // 
            this.cbDD.AutoSize = true;
            this.cbDD.Location = new System.Drawing.Point(16, 164);
            this.cbDD.Name = "cbDD";
            this.cbDD.Size = new System.Drawing.Size(278, 17);
            this.cbDD.TabIndex = 6;
            this.cbDD.Text = "Đặc điểm chính của pha trưởng thành để nhận dạng";
            this.cbDD.UseVisualStyleBackColor = true;
            this.cbDD.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbBQ
            // 
            this.cbBQ.AutoSize = true;
            this.cbBQ.Location = new System.Drawing.Point(126, 95);
            this.cbBQ.Name = "cbBQ";
            this.cbBQ.Size = new System.Drawing.Size(122, 17);
            this.cbBQ.TabIndex = 7;
            this.cbBQ.Text = "Giám định bảo quản";
            this.cbBQ.UseVisualStyleBackColor = true;
            this.cbBQ.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbLSVN
            // 
            this.cbLSVN.AutoSize = true;
            this.cbLSVN.Location = new System.Drawing.Point(16, 117);
            this.cbLSVN.Name = "cbLSVN";
            this.cbLSVN.Size = new System.Drawing.Size(162, 17);
            this.cbLSVN.TabIndex = 8;
            this.cbLSVN.Text = "Lịch sử phát hiện ở Việt Nam";
            this.cbLSVN.UseVisualStyleBackColor = true;
            this.cbLSVN.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbPHVN
            // 
            this.cbPHVN.AutoSize = true;
            this.cbPHVN.Location = new System.Drawing.Point(16, 140);
            this.cbPHVN.Name = "cbPHVN";
            this.cbPHVN.Size = new System.Drawing.Size(204, 17);
            this.cbPHVN.TabIndex = 9;
            this.cbPHVN.Text = "Tài liệu công bố phát hiện ở Việt Nam";
            this.cbPHVN.UseVisualStyleBackColor = true;
            this.cbPHVN.CheckedChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.img);
            this.groupBox2.Controls.Add(this.btnA);
            this.groupBox2.Controls.Add(this.lblTB);
            this.groupBox2.Location = new System.Drawing.Point(837, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 234);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lựa thông tin";
            // 
            // frmChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChiTiet";
            this.Text = "frmChiTiet";
            this.Load += new System.EventHandler(this.frmChiTiet_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbPHVN;
        private System.Windows.Forms.CheckBox cbLSVN;
        private System.Windows.Forms.CheckBox cbBQ;
        private System.Windows.Forms.CheckBox cbDD;
        private System.Windows.Forms.CheckBox cbXH;
        private System.Windows.Forms.CheckBox cbTH;
        private System.Windows.Forms.CheckBox cbPB;
        private System.Windows.Forms.CheckBox cbPL;
        private System.Windows.Forms.CheckBox cbTL;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}