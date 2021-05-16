
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGioHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Mua Hàng";
            // 
            // gridviewSanPham
            // 
            this.gridviewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.gridviewSanPham, 2);
            this.gridviewSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewSanPham.Location = new System.Drawing.Point(3, 234);
            this.gridviewSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridviewSanPham.Name = "gridviewSanPham";
            this.gridviewSanPham.RowHeadersWidth = 51;
            this.gridviewSanPham.RowTemplate.Height = 24;
            this.gridviewSanPham.Size = new System.Drawing.Size(1143, 173);
            this.gridviewSanPham.TabIndex = 1;
            this.gridviewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewSanPham_CellClick);
            // 
            // gridviewGioHang
            // 
            this.gridviewGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.gridviewGioHang, 2);
            this.gridviewGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewGioHang.Location = new System.Drawing.Point(3, 465);
            this.gridviewGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridviewGioHang.Name = "gridviewGioHang";
            this.gridviewGioHang.RowHeadersWidth = 51;
            this.gridviewGioHang.RowTemplate.Height = 24;
            this.gridviewGioHang.Size = new System.Drawing.Size(1143, 131);
            this.gridviewGioHang.TabIndex = 2;
            this.gridviewGioHang.DataSourceChanged += new System.EventHandler(this.gridviewGioHang_DataSourceChanged);
            this.gridviewGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewGioHang_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 610);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng tiền: ";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTongTien.Location = new System.Drawing.Point(942, 610);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(204, 24);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "0";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(983, 703);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 30, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(136, 57);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Tạo hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(30, 658);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(94, 20);
            this.lblNhanVien.TabIndex = 8;
            this.lblNhanVien.Text = "lblNhanVien";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(30, 90);
            this.lblKhachHang.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(102, 20);
            this.lblKhachHang.TabIndex = 6;
            this.lblKhachHang.Text = "Khách hàng: ";
            // 
            // lblSale
            // 
            this.lblSale.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.Location = new System.Drawing.Point(30, 142);
            this.lblSale.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(51, 20);
            this.lblSale.TabIndex = 9;
            this.lblSale.Text = "label3";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sản phẩm có sẵn :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sản phẩm được chọn :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLuu, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblNhanVien, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblKhachHang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTongTien, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblSale, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridviewGioHang, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.gridviewSanPham, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.256449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.435508F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.918057F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.435508F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.76176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.980273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.45068F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.221548F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.827068F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 773);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1149, 773);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmLapHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewGioHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}