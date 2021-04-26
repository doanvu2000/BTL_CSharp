
namespace BTL_CSharp
{
    partial class frmQLNV
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lblluong = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lbltennv = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(166, 205);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.Size = new System.Drawing.Size(666, 337);
            this.dgvNhanVien.TabIndex = 90;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Danh Mục Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(532, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nhập SĐT";
            // 
            // txttimkiem
            // 
            this.txttimkiem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txttimkiem.Location = new System.Drawing.Point(596, 94);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(152, 20);
            this.txttimkiem.TabIndex = 8;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Yellow;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTim.Location = new System.Drawing.Point(577, 132);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(104, 38);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm &Kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.Color.Yellow;
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.ForeColor = System.Drawing.Color.OrangeRed;
            this.btndong.Location = new System.Drawing.Point(42, 424);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(104, 38);
            this.btndong.TabIndex = 11;
            this.btndong.Text = "&Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Yellow;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnxoa.Location = new System.Drawing.Point(42, 367);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(104, 38);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Yellow;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnsua.Location = new System.Drawing.Point(42, 301);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 38);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "&Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Yellow;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnthem.Location = new System.Drawing.Point(42, 241);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 38);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "&Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtluong
            // 
            this.txtluong.ForeColor = System.Drawing.Color.Blue;
            this.txtluong.Location = new System.Drawing.Point(74, 176);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(172, 20);
            this.txtluong.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.ForeColor = System.Drawing.Color.Blue;
            this.txtdiachi.Location = new System.Drawing.Point(310, 142);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(167, 20);
            this.txtdiachi.TabIndex = 3;
            // 
            // txtsdt
            // 
            this.txtsdt.ForeColor = System.Drawing.Color.Blue;
            this.txtsdt.Location = new System.Drawing.Point(310, 97);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(167, 20);
            this.txtsdt.TabIndex = 2;
            // 
            // txttennv
            // 
            this.txttennv.ForeColor = System.Drawing.Color.Blue;
            this.txttennv.Location = new System.Drawing.Point(74, 139);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(172, 20);
            this.txttennv.TabIndex = 1;
            // 
            // txtmanv
            // 
            this.txtmanv.ForeColor = System.Drawing.Color.Blue;
            this.txtmanv.Location = new System.Drawing.Point(74, 97);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(172, 20);
            this.txtmanv.TabIndex = 76;
            // 
            // lblluong
            // 
            this.lblluong.AutoSize = true;
            this.lblluong.ForeColor = System.Drawing.Color.Blue;
            this.lblluong.Location = new System.Drawing.Point(22, 176);
            this.lblluong.Name = "lblluong";
            this.lblluong.Size = new System.Drawing.Size(37, 13);
            this.lblluong.TabIndex = 75;
            this.lblluong.Text = "Lương";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.ForeColor = System.Drawing.Color.Blue;
            this.lbldiachi.Location = new System.Drawing.Point(260, 145);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(41, 13);
            this.lbldiachi.TabIndex = 74;
            this.lbldiachi.Text = "Địa Chỉ";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.ForeColor = System.Drawing.Color.Blue;
            this.lblsdt.Location = new System.Drawing.Point(260, 100);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(29, 13);
            this.lblsdt.TabIndex = 73;
            this.lblsdt.Text = "SĐT";
            // 
            // lbltennv
            // 
            this.lbltennv.AutoSize = true;
            this.lbltennv.ForeColor = System.Drawing.Color.Blue;
            this.lbltennv.Location = new System.Drawing.Point(22, 139);
            this.lbltennv.Name = "lbltennv";
            this.lbltennv.Size = new System.Drawing.Size(43, 13);
            this.lbltennv.TabIndex = 72;
            this.lbltennv.Text = "Họ Tên";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.ForeColor = System.Drawing.Color.Blue;
            this.lblmanv.Location = new System.Drawing.Point(21, 100);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(37, 13);
            this.lblmanv.TabIndex = 71;
            this.lblmanv.Text = "MãNV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(172, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Yellow;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.Red;
            this.btnhuy.Location = new System.Drawing.Point(687, 132);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(94, 38);
            this.btnhuy.TabIndex = 10;
            this.btnhuy.Text = "&Hủy";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(853, 555);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.lblluong);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lblsdt);
            this.Controls.Add(this.lbltennv);
            this.Controls.Add(this.lblmanv);
            this.Controls.Add(this.label1);
            this.Name = "frmQLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmQLNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lblluong;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Label lbltennv;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhuy;
    }
}