namespace SVGH
{
    partial class frmChiTietSVH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietSVH));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.Button();
            this.lblTB = new System.Windows.Forms.Label();
            this.cbTG = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTTPH = new System.Windows.Forms.CheckBox();
            this.cbBP = new System.Windows.Forms.CheckBox();
            this.cbPB = new System.Windows.Forms.CheckBox();
            this.cbPL = new System.Windows.Forms.CheckBox();
            this.cbTL = new System.Windows.Forms.CheckBox();
            this.cb = new System.Windows.Forms.CheckBox();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.groupBox2.Location = new System.Drawing.Point(671, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 234);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh";
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
            // cbTG
            // 
            this.cbTG.AutoSize = true;
            this.cbTG.Location = new System.Drawing.Point(16, 140);
            this.cbTG.Name = "cbTG";
            this.cbTG.Size = new System.Drawing.Size(173, 17);
            this.cbTG.TabIndex = 9;
            this.cbTG.Text = "Thời gian phát hiện và thu mẫu";
            this.cbTG.UseVisualStyleBackColor = true;
            this.cbTG.CheckStateChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbTG);
            this.groupBox1.Controls.Add(this.cbTTPH);
            this.groupBox1.Controls.Add(this.cbBP);
            this.groupBox1.Controls.Add(this.cbPB);
            this.groupBox1.Controls.Add(this.cbPL);
            this.groupBox1.Controls.Add(this.cbTL);
            this.groupBox1.Controls.Add(this.cb);
            this.groupBox1.Location = new System.Drawing.Point(671, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa thông tin";
            // 
            // cbTTPH
            // 
            this.cbTTPH.AutoSize = true;
            this.cbTTPH.Location = new System.Drawing.Point(16, 117);
            this.cbTTPH.Name = "cbTTPH";
            this.cbTTPH.Size = new System.Drawing.Size(121, 17);
            this.cbTTPH.TabIndex = 8;
            this.cbTTPH.Text = "Tình trạng phát hiện";
            this.cbTTPH.UseVisualStyleBackColor = true;
            this.cbTTPH.CheckStateChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbBP
            // 
            this.cbBP.AutoSize = true;
            this.cbBP.Location = new System.Drawing.Point(16, 164);
            this.cbBP.Name = "cbBP";
            this.cbBP.Size = new System.Drawing.Size(272, 17);
            this.cbBP.TabIndex = 6;
            this.cbBP.Text = "Bộ phận bị hại/ Nhóm sâu hại/ Quan hệ dinh dưỡng";
            this.cbBP.UseVisualStyleBackColor = true;
            this.cbBP.CheckStateChanged += new System.EventHandler(this.cbItem_CheckedChanged);
            // 
            // cbPB
            // 
            this.cbPB.AutoSize = true;
            this.cbPB.Location = new System.Drawing.Point(16, 94);
            this.cbPB.Name = "cbPB";
            this.cbPB.Size = new System.Drawing.Size(66, 17);
            this.cbPB.TabIndex = 3;
            this.cbPB.Text = "Phân bổ";
            this.cbPB.UseVisualStyleBackColor = true;
            this.cbPB.CheckStateChanged += new System.EventHandler(this.cbItem_CheckedChanged);
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
            this.cbPL.CheckStateChanged += new System.EventHandler(this.cbItem_CheckedChanged);
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
            this.cbTL.CheckStateChanged += new System.EventHandler(this.cbItem_CheckedChanged);
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
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(3, 2);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(662, 477);
            this.txt.TabIndex = 9;
            this.txt.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(716, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "In thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(833, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // frmChiTietSVH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt);
            this.Name = "frmChiTietSVH";
            this.Text = "Chi tiết sinh vật hại";
            this.Load += new System.EventHandler(this.frmChiTietSVH_Load);
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
        private System.Windows.Forms.CheckBox cbTG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTTPH;
        private System.Windows.Forms.CheckBox cbBP;
        private System.Windows.Forms.CheckBox cbPB;
        private System.Windows.Forms.CheckBox cbPL;
        private System.Windows.Forms.CheckBox cbTL;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}