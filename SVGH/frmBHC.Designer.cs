namespace SVGH
{
    partial class frmBHC
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgLoad = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdch = new System.Windows.Forms.RadioButton();
            this.rdkh = new System.Windows.Forms.RadioButton();
            this.rdvn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPVKC = new System.Windows.Forms.ComboBox();
            this.dtgBHC = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BHChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBHC)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(235, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xem chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.imgLoad);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtgBHC);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(615, 350);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // imgLoad
            // 
            this.imgLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgLoad.Location = new System.Drawing.Point(330, 150);
            this.imgLoad.Name = "imgLoad";
            this.imgLoad.Size = new System.Drawing.Size(274, 193);
            this.imgLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLoad.TabIndex = 4;
            this.imgLoad.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rdch);
            this.groupBox2.Controls.Add(this.rdkh);
            this.groupBox2.Controls.Add(this.rdvn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbPVKC);
            this.groupBox2.Location = new System.Drawing.Point(330, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(278, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiêu chí tìm kiếm";
            // 
            // rdch
            // 
            this.rdch.AutoSize = true;
            this.rdch.Checked = true;
            this.rdch.Location = new System.Drawing.Point(8, 24);
            this.rdch.Name = "rdch";
            this.rdch.Size = new System.Drawing.Size(73, 17);
            this.rdch.TabIndex = 9;
            this.rdch.TabStop = true;
            this.rdch.Text = "Cả hai tên";
            this.rdch.UseVisualStyleBackColor = true;
            this.rdch.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdkh
            // 
            this.rdkh.AutoSize = true;
            this.rdkh.Location = new System.Drawing.Point(8, 72);
            this.rdkh.Name = "rdkh";
            this.rdkh.Size = new System.Drawing.Size(92, 17);
            this.rdkh.TabIndex = 8;
            this.rdkh.TabStop = true;
            this.rdkh.Text = "Tên khoa học";
            this.rdkh.UseVisualStyleBackColor = true;
            this.rdkh.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdvn
            // 
            this.rdvn.AutoSize = true;
            this.rdvn.Location = new System.Drawing.Point(8, 48);
            this.rdvn.Name = "rdvn";
            this.rdvn.Size = new System.Drawing.Size(90, 17);
            this.rdvn.TabIndex = 7;
            this.rdvn.TabStop = true;
            this.rdvn.Text = "Tên Việt Nam";
            this.rdvn.UseVisualStyleBackColor = true;
            this.rdvn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phạm vi ký chủ";
            // 
            // cbPVKC
            // 
            this.cbPVKC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPVKC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPVKC.FormattingEnabled = true;
            this.cbPVKC.Location = new System.Drawing.Point(87, 99);
            this.cbPVKC.Margin = new System.Windows.Forms.Padding(2);
            this.cbPVKC.Name = "cbPVKC";
            this.cbPVKC.Size = new System.Drawing.Size(187, 21);
            this.cbPVKC.TabIndex = 3;
            this.cbPVKC.SelectedIndexChanged += new System.EventHandler(this.cbPVKC_SelectedIndexChanged);
            // 
            // dtgBHC
            // 
            this.dtgBHC.AllowUserToAddRows = false;
            this.dtgBHC.AllowUserToDeleteRows = false;
            this.dtgBHC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBHC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBHC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBHC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.TenVN,
            this.ID_BHChinh});
            this.dtgBHC.Location = new System.Drawing.Point(8, 57);
            this.dtgBHC.Margin = new System.Windows.Forms.Padding(2);
            this.dtgBHC.Name = "dtgBHC";
            this.dtgBHC.ReadOnly = true;
            this.dtgBHC.RowTemplate.Height = 24;
            this.dtgBHC.Size = new System.Drawing.Size(311, 285);
            this.dtgBHC.TabIndex = 2;
            this.dtgBHC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBHC_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(9, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(310, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin tìm kiếm";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(332, 366);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khoa học";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // TenVN
            // 
            this.TenVN.DataPropertyName = "TenVN";
            this.TenVN.HeaderText = "Tên Việt Nam";
            this.TenVN.Name = "TenVN";
            this.TenVN.ReadOnly = true;
            // 
            // ID_BHChinh
            // 
            this.ID_BHChinh.DataPropertyName = "ID_BHChinh";
            this.ID_BHChinh.HeaderText = "ID";
            this.ID_BHChinh.Name = "ID_BHChinh";
            this.ID_BHChinh.ReadOnly = true;
            this.ID_BHChinh.Visible = false;
            // 
            // frmBHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "frmBHC";
            this.Text = "frmBHC";
            this.Load += new System.EventHandler(this.frmBHC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBHC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdch;
        private System.Windows.Forms.RadioButton rdkh;
        private System.Windows.Forms.RadioButton rdvn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPVKC;
        private System.Windows.Forms.DataGridView dtgBHC;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BHChinh;
    }
}