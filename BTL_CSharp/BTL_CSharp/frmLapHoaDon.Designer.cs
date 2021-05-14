
namespace BTL_CSharp
{
    partial class frmLapHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridviewSanPham = new System.Windows.Forms.DataGridView();
            this.gridviewGioHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập hóa đơn";
            // 
            // gridviewSanPham
            // 
            this.gridviewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewSanPham.Location = new System.Drawing.Point(123, 183);
            this.gridviewSanPham.Name = "gridviewSanPham";
            this.gridviewSanPham.RowHeadersWidth = 51;
            this.gridviewSanPham.RowTemplate.Height = 24;
            this.gridviewSanPham.Size = new System.Drawing.Size(963, 189);
            this.gridviewSanPham.TabIndex = 1;
            this.gridviewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewSanPham_CellClick);
            // 
            // gridviewGioHang
            // 
            this.gridviewGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewGioHang.Location = new System.Drawing.Point(124, 396);
            this.gridviewGioHang.Name = "gridviewGioHang";
            this.gridviewGioHang.RowHeadersWidth = 51;
            this.gridviewGioHang.RowTemplate.Height = 24;
            this.gridviewGioHang.Size = new System.Drawing.Size(962, 180);
            this.gridviewGioHang.TabIndex = 2;
            this.gridviewGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewGioHang_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 608);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền: ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(742, 608);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(16, 17);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "0";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(982, 608);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 48);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(121, 675);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(84, 17);
            this.lblNhanVien.TabIndex = 8;
            this.lblNhanVien.Text = "lblNhanVien";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(124, 90);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(92, 17);
            this.lblKhachHang.TabIndex = 6;
            this.lblKhachHang.Text = "Khách hàng: ";
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 701);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridviewGioHang);
            this.Controls.Add(this.gridviewSanPham);
            this.Controls.Add(this.label1);
            this.Name = "frmLapHoaDon";
            this.Text = "frmLapHoaDon";
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridviewSanPham;
        private System.Windows.Forms.DataGridView gridviewGioHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblKhachHang;
    }
}