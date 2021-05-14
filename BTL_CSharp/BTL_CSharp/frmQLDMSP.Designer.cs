
namespace BTL_CSharp
{
    partial class frmQLDMSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDMSP));
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDMViewSP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.cblNCC = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(37, 201);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(906, 257);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.dgvDanhMuc);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtTenDM);
            this.panel1.Controls.Add(this.txtMaDM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 249);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(901, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(379, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 34);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Location = new System.Drawing.Point(485, 41);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.Size = new System.Drawing.Size(428, 163);
            this.dgvDanhMuc.TabIndex = 3;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Location = new System.Drawing.Point(269, 171);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.Location = new System.Drawing.Point(148, 171);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Location = new System.Drawing.Point(20, 171);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(227, 104);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(189, 22);
            this.txtTenDM.TabIndex = 1;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Enabled = false;
            this.txtMaDM.Location = new System.Drawing.Point(227, 44);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(189, 22);
            this.txtMaDM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Danh Mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Danh Mục:";
            // 
            // lblDMViewSP
            // 
            this.lblDMViewSP.AutoSize = true;
            this.lblDMViewSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMViewSP.Location = new System.Drawing.Point(31, 0);
            this.lblDMViewSP.Name = "lblDMViewSP";
            this.lblDMViewSP.Size = new System.Drawing.Size(58, 31);
            this.lblDMViewSP.TabIndex = 2;
            this.lblDMViewSP.Text = "DM";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancelSP);
            this.panel2.Controls.Add(this.btnXoaSP);
            this.panel2.Controls.Add(this.btnSuaSP);
            this.panel2.Controls.Add(this.btnThemSP);
            this.panel2.Controls.Add(this.cblNCC);
            this.panel2.Controls.Add(this.txtMoTa);
            this.panel2.Controls.Add(this.txtSoLuongTon);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.txtTenSP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvSanPham);
            this.panel2.Controls.Add(this.lblDMViewSP);
            this.panel2.Location = new System.Drawing.Point(45, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 478);
            this.panel2.TabIndex = 3;
            // 
            // btnCancelSP
            // 
            this.btnCancelSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelSP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelSP.Location = new System.Drawing.Point(638, 141);
            this.btnCancelSP.Name = "btnCancelSP";
            this.btnCancelSP.Size = new System.Drawing.Size(111, 40);
            this.btnCancelSP.TabIndex = 14;
            this.btnCancelSP.Text = "Cancel";
            this.btnCancelSP.UseVisualStyleBackColor = false;
            this.btnCancelSP.Click += new System.EventHandler(this.btnCancelSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaSP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoaSP.Location = new System.Drawing.Point(501, 141);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(111, 40);
            this.btnXoaSP.TabIndex = 13;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaSP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSuaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuaSP.Location = new System.Drawing.Point(364, 141);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(111, 40);
            this.btnSuaSP.TabIndex = 12;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemSP.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemSP.Location = new System.Drawing.Point(227, 141);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(111, 40);
            this.btnThemSP.TabIndex = 11;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // cblNCC
            // 
            this.cblNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cblNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cblNCC.FormattingEnabled = true;
            this.cblNCC.Location = new System.Drawing.Point(778, 58);
            this.cblNCC.Name = "cblNCC";
            this.cblNCC.Size = new System.Drawing.Size(151, 24);
            this.cblNCC.TabIndex = 10;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(451, 100);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(177, 22);
            this.txtMoTa.TabIndex = 9;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(148, 100);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(177, 22);
            this.txtSoLuongTon.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(451, 58);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(177, 22);
            this.txtGia.TabIndex = 8;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(148, 58);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(177, 22);
            this.txtTenSP.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mô tả: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nhà CC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // frmQLDMSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1062, 781);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLDMSP";
            this.Text = "QUẢN LÝ DANH MỤC, SẢN PHẨM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label lblDMViewSP;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.ComboBox cblNCC;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button btnClose;
    }
}

