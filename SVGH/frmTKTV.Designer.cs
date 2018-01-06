namespace SVGH
{
    partial class frmTKTV
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
            this.button3 = new System.Windows.Forms.Button();
            this.imgLoad = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLTK = new System.Windows.Forms.ComboBox();
            this.cbdongnambo = new System.Windows.Forms.CheckBox();
            this.cbduyenhaintb = new System.Windows.Forms.CheckBox();
            this.cbtaynambo = new System.Windows.Forms.CheckBox();
            this.cbdbsongcuulong = new System.Windows.Forms.CheckBox();
            this.cbduyenhaibtb = new System.Windows.Forms.CheckBox();
            this.cbtaynguyen = new System.Windows.Forms.CheckBox();
            this.cbdbsonghong = new System.Windows.Forms.CheckBox();
            this.cbtrungdumnpb = new System.Windows.Forms.CheckBox();
            this.cbtrungtam = new System.Windows.Forms.CheckBox();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(344, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Xem chi tiết";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.imgLoad);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtg);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(920, 458);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(525, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 69);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imgLoad
            // 
            this.imgLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLoad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imgLoad.Location = new System.Drawing.Point(641, 34);
            this.imgLoad.Name = "imgLoad";
            this.imgLoad.Size = new System.Drawing.Size(274, 193);
            this.imgLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLoad.TabIndex = 4;
            this.imgLoad.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbLTK);
            this.groupBox2.Controls.Add(this.cbdongnambo);
            this.groupBox2.Controls.Add(this.cbduyenhaintb);
            this.groupBox2.Controls.Add(this.cbtaynambo);
            this.groupBox2.Controls.Add(this.cbdbsongcuulong);
            this.groupBox2.Controls.Add(this.cbduyenhaibtb);
            this.groupBox2.Controls.Add(this.cbtaynguyen);
            this.groupBox2.Controls.Add(this.cbdbsonghong);
            this.groupBox2.Controls.Add(this.cbtrungdumnpb);
            this.groupBox2.Controls.Add(this.cbtrungtam);
            this.groupBox2.Location = new System.Drawing.Point(637, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(278, 217);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiêu chí tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Loại tìm kiếm";
            // 
            // cbLTK
            // 
            this.cbLTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLTK.FormattingEnabled = true;
            this.cbLTK.Location = new System.Drawing.Point(72, 20);
            this.cbLTK.Margin = new System.Windows.Forms.Padding(2);
            this.cbLTK.Name = "cbLTK";
            this.cbLTK.Size = new System.Drawing.Size(201, 21);
            this.cbLTK.TabIndex = 20;
            this.cbLTK.SelectedIndexChanged += new System.EventHandler(this.cbLTK_SelectedIndexChanged);
            // 
            // cbdongnambo
            // 
            this.cbdongnambo.AutoSize = true;
            this.cbdongnambo.Location = new System.Drawing.Point(171, 69);
            this.cbdongnambo.Name = "cbdongnambo";
            this.cbdongnambo.Size = new System.Drawing.Size(93, 17);
            this.cbdongnambo.TabIndex = 19;
            this.cbdongnambo.Text = "Đông Nam Bộ";
            this.cbdongnambo.UseVisualStyleBackColor = true;
            this.cbdongnambo.CheckedChanged += new System.EventHandler(this.cbdongnambo_CheckedChanged);
            // 
            // cbduyenhaintb
            // 
            this.cbduyenhaintb.AutoSize = true;
            this.cbduyenhaintb.Location = new System.Drawing.Point(5, 137);
            this.cbduyenhaintb.Name = "cbduyenhaintb";
            this.cbduyenhaintb.Size = new System.Drawing.Size(146, 17);
            this.cbduyenhaintb.TabIndex = 18;
            this.cbduyenhaintb.Text = "Duyên hải Nam Trung Bộ";
            this.cbduyenhaintb.UseVisualStyleBackColor = true;
            this.cbduyenhaintb.CheckedChanged += new System.EventHandler(this.cbduyenhaintb_CheckedChanged);
            // 
            // cbtaynambo
            // 
            this.cbtaynambo.AutoSize = true;
            this.cbtaynambo.Location = new System.Drawing.Point(171, 46);
            this.cbtaynambo.Name = "cbtaynambo";
            this.cbtaynambo.Size = new System.Drawing.Size(85, 17);
            this.cbtaynambo.TabIndex = 17;
            this.cbtaynambo.Text = "Tây Nam Bộ";
            this.cbtaynambo.UseVisualStyleBackColor = true;
            this.cbtaynambo.CheckedChanged += new System.EventHandler(this.cbtaynambo_CheckedChanged);
            // 
            // cbdbsongcuulong
            // 
            this.cbdbsongcuulong.AutoSize = true;
            this.cbdbsongcuulong.Location = new System.Drawing.Point(5, 184);
            this.cbdbsongcuulong.Name = "cbdbsongcuulong";
            this.cbdbsongcuulong.Size = new System.Drawing.Size(154, 17);
            this.cbdbsongcuulong.TabIndex = 16;
            this.cbdbsongcuulong.Text = "Đồng bằng sông Cửu Long";
            this.cbdbsongcuulong.UseVisualStyleBackColor = true;
            this.cbdbsongcuulong.CheckedChanged += new System.EventHandler(this.cbdbsongcuulong_CheckedChanged);
            // 
            // cbduyenhaibtb
            // 
            this.cbduyenhaibtb.AutoSize = true;
            this.cbduyenhaibtb.Location = new System.Drawing.Point(4, 160);
            this.cbduyenhaibtb.Name = "cbduyenhaibtb";
            this.cbduyenhaibtb.Size = new System.Drawing.Size(143, 17);
            this.cbduyenhaibtb.TabIndex = 15;
            this.cbduyenhaibtb.Text = "Duyên hải Bắc Trung Bộ";
            this.cbduyenhaibtb.UseVisualStyleBackColor = true;
            this.cbduyenhaibtb.CheckedChanged += new System.EventHandler(this.cbduyenhaibtb_CheckedChanged);
            // 
            // cbtaynguyen
            // 
            this.cbtaynguyen.AutoSize = true;
            this.cbtaynguyen.Location = new System.Drawing.Point(5, 69);
            this.cbtaynguyen.Name = "cbtaynguyen";
            this.cbtaynguyen.Size = new System.Drawing.Size(84, 17);
            this.cbtaynguyen.TabIndex = 14;
            this.cbtaynguyen.Text = "Tây Nguyên";
            this.cbtaynguyen.UseVisualStyleBackColor = true;
            this.cbtaynguyen.CheckedChanged += new System.EventHandler(this.cbtaynguyen_CheckedChanged);
            // 
            // cbdbsonghong
            // 
            this.cbdbsonghong.AutoSize = true;
            this.cbdbsonghong.Location = new System.Drawing.Point(5, 92);
            this.cbdbsonghong.Name = "cbdbsonghong";
            this.cbdbsonghong.Size = new System.Drawing.Size(134, 17);
            this.cbdbsonghong.TabIndex = 13;
            this.cbdbsonghong.Text = "Đồng bằng sông Hồng";
            this.cbdbsonghong.UseVisualStyleBackColor = true;
            this.cbdbsonghong.CheckedChanged += new System.EventHandler(this.cbdbsonghong_CheckedChanged);
            // 
            // cbtrungdumnpb
            // 
            this.cbtrungdumnpb.AutoSize = true;
            this.cbtrungdumnpb.Location = new System.Drawing.Point(5, 115);
            this.cbtrungdumnpb.Name = "cbtrungdumnpb";
            this.cbtrungdumnpb.Size = new System.Drawing.Size(158, 17);
            this.cbtrungdumnpb.TabIndex = 12;
            this.cbtrungdumnpb.Text = "Trung du miền núi phía Bắc";
            this.cbtrungdumnpb.UseVisualStyleBackColor = true;
            this.cbtrungdumnpb.CheckedChanged += new System.EventHandler(this.cbtrungdumnpb_CheckedChanged);
            // 
            // cbtrungtam
            // 
            this.cbtrungtam.AutoSize = true;
            this.cbtrungtam.Location = new System.Drawing.Point(5, 46);
            this.cbtrungtam.Name = "cbtrungtam";
            this.cbtrungtam.Size = new System.Drawing.Size(74, 17);
            this.cbtrungtam.TabIndex = 11;
            this.cbtrungtam.Text = "Trung tâm";
            this.cbtrungtam.UseVisualStyleBackColor = true;
            this.cbtrungtam.CheckedChanged += new System.EventHandler(this.cbtrungtam_CheckedChanged);
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            this.dtg.AllowUserToDeleteRows = false;
            this.dtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.TenVN,
            this.ID,
            this.LOAI});
            this.dtg.Location = new System.Drawing.Point(8, 108);
            this.dtg.Margin = new System.Windows.Forms.Padding(2);
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            this.dtg.RowTemplate.Height = 24;
            this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg.Size = new System.Drawing.Size(625, 342);
            this.dtg.TabIndex = 2;
            this.dtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellClick);
            this.dtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_CellDoubleClick);
            this.dtg.Sorted += new System.EventHandler(this.dtg_Sorted);
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // LOAI
            // 
            this.LOAI.DataPropertyName = "LOAI";
            this.LOAI.HeaderText = "LOAI";
            this.LOAI.Name = "LOAI";
            this.LOAI.ReadOnly = true;
            this.LOAI.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(511, 70);
            this.txtSearch.TabIndex = 1;
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
            this.button2.Location = new System.Drawing.Point(441, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 26);
            this.button2.TabIndex = 20;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmTKTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "frmTKTV";
            this.Text = "frmTKTV";
            this.Load += new System.EventHandler(this.frmTKTV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbdongnambo;
        private System.Windows.Forms.CheckBox cbduyenhaintb;
        private System.Windows.Forms.CheckBox cbtaynambo;
        private System.Windows.Forms.CheckBox cbdbsongcuulong;
        private System.Windows.Forms.CheckBox cbduyenhaibtb;
        private System.Windows.Forms.CheckBox cbtaynguyen;
        private System.Windows.Forms.CheckBox cbdbsonghong;
        private System.Windows.Forms.CheckBox cbtrungdumnpb;
        private System.Windows.Forms.CheckBox cbtrungtam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI;
    }
}