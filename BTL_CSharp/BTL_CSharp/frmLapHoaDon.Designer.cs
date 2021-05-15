
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
            this.lblSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập hóa đơn";
            // 
            // gridviewSanPham
            // 
            this.gridviewSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewSanPham.Location = new System.Drawing.Point(124, 231);
            this.gridviewSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridviewSanPham.Name = "gridviewSanPham";
            this.gridviewSanPham.RowHeadersWidth = 51;
            this.gridviewSanPham.RowTemplate.Height = 24;
            this.gridviewSanPham.Size = new System.Drawing.Size(963, 190);
            this.gridviewSanPham.TabIndex = 1;
            this.gridviewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewSanPham_CellClick);
            // 
            // gridviewGioHang
            // 
            this.gridviewGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewGioHang.Location = new System.Drawing.Point(124, 453);
            this.gridviewGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridviewGioHang.Name = "gridviewGioHang";
            this.gridviewGioHang.RowHeadersWidth = 51;
            this.gridviewGioHang.RowTemplate.Height = 24;
            this.gridviewGioHang.Size = new System.Drawing.Size(963, 180);
            this.gridviewGioHang.TabIndex = 2;
            this.gridviewGioHang.DataSourceChanged += new System.EventHandler(this.gridviewGioHang_DataSourceChanged);
            this.gridviewGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewGioHang_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(652, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền: ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTongTien.Location = new System.Drawing.Point(770, 669);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(20, 24);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "0";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(951, 680);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 57);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Tạo hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(120, 717);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(94, 20);
            this.lblNhanVien.TabIndex = 8;
            this.lblNhanVien.Text = "lblNhanVien";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(121, 126);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(102, 20);
            this.lblKhachHang.TabIndex = 6;
            this.lblKhachHang.Text = "Khách hàng: ";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.Location = new System.Drawing.Point(121, 146);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(51, 20);
            this.lblSale.TabIndex = 9;
            this.lblSale.Text = "label3";
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 773);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridviewGioHang);
            this.Controls.Add(this.gridviewSanPham);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLapHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label lblSale;
    }
}