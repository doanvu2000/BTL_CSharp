
namespace BTL_CSharp
{
    partial class frmMenuAction
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQLDMSP = new System.Windows.Forms.TabPage();
            this.tabQLHD = new System.Windows.Forms.TabPage();
            this.tabQLNCC = new System.Windows.Forms.TabPage();
            this.tabQLNV = new System.Windows.Forms.TabPage();
            this.tabQLKH = new System.Windows.Forms.TabPage();
            this.tabCreateBill = new System.Windows.Forms.TabPage();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabQLTK = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWelcome, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1584, 861);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabStatistic);
            this.tabControl1.Controls.Add(this.tabCreateBill);
            this.tabControl1.Controls.Add(this.tabQLTK);
            this.tabControl1.Controls.Add(this.tabQLDMSP);
            this.tabControl1.Controls.Add(this.tabQLHD);
            this.tabControl1.Controls.Add(this.tabQLNCC);
            this.tabControl1.Controls.Add(this.tabQLNV);
            this.tabControl1.Controls.Add(this.tabQLKH);
            this.tabControl1.Location = new System.Drawing.Point(3, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1578, 770);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQLDMSP
            // 
            this.tabQLDMSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLDMSP.Location = new System.Drawing.Point(4, 29);
            this.tabQLDMSP.Name = "tabQLDMSP";
            this.tabQLDMSP.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLDMSP.Size = new System.Drawing.Size(1570, 737);
            this.tabQLDMSP.TabIndex = 0;
            this.tabQLDMSP.Text = "Quản lý Danh Mục, Sản Phẩm";
            this.tabQLDMSP.UseVisualStyleBackColor = true;
            // 
            // tabQLHD
            // 
            this.tabQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLHD.Location = new System.Drawing.Point(4, 29);
            this.tabQLHD.Name = "tabQLHD";
            this.tabQLHD.Padding = new System.Windows.Forms.Padding(3);
            this.tabQLHD.Size = new System.Drawing.Size(1570, 737);
            this.tabQLHD.TabIndex = 1;
            this.tabQLHD.Text = "Quản lý Hóa Đơn";
            this.tabQLHD.UseVisualStyleBackColor = true;
            // 
            // tabQLNCC
            // 
            this.tabQLNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLNCC.Location = new System.Drawing.Point(4, 29);
            this.tabQLNCC.Name = "tabQLNCC";
            this.tabQLNCC.Size = new System.Drawing.Size(1570, 737);
            this.tabQLNCC.TabIndex = 2;
            this.tabQLNCC.Text = "Quản lý Nhà cung cấp";
            this.tabQLNCC.UseVisualStyleBackColor = true;
            // 
            // tabQLNV
            // 
            this.tabQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLNV.Location = new System.Drawing.Point(4, 29);
            this.tabQLNV.Name = "tabQLNV";
            this.tabQLNV.Size = new System.Drawing.Size(1570, 737);
            this.tabQLNV.TabIndex = 3;
            this.tabQLNV.Text = "Quản lý nhân viên";
            this.tabQLNV.UseVisualStyleBackColor = true;
            // 
            // tabQLKH
            // 
            this.tabQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLKH.Location = new System.Drawing.Point(4, 29);
            this.tabQLKH.Name = "tabQLKH";
            this.tabQLKH.Size = new System.Drawing.Size(1570, 737);
            this.tabQLKH.TabIndex = 4;
            this.tabQLKH.Text = "Quản lý khách hàng";
            this.tabQLKH.UseVisualStyleBackColor = true;
            // 
            // tabCreateBill
            // 
            this.tabCreateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCreateBill.Location = new System.Drawing.Point(4, 29);
            this.tabCreateBill.Name = "tabCreateBill";
            this.tabCreateBill.Size = new System.Drawing.Size(1570, 737);
            this.tabCreateBill.TabIndex = 5;
            this.tabCreateBill.Text = "Lập hóa đơn";
            this.tabCreateBill.UseVisualStyleBackColor = true;
            // 
            // tabStatistic
            // 
            this.tabStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStatistic.Location = new System.Drawing.Point(4, 29);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Size = new System.Drawing.Size(1570, 737);
            this.tabStatistic.TabIndex = 6;
            this.tabStatistic.Text = "Thống kê";
            this.tabStatistic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1574, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG MỸ PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(10, 60);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(94, 24);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Xin chào";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // tabQLTK
            // 
            this.tabQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQLTK.Location = new System.Drawing.Point(4, 29);
            this.tabQLTK.Name = "tabQLTK";
            this.tabQLTK.Size = new System.Drawing.Size(1570, 737);
            this.tabQLTK.TabIndex = 7;
            this.tabQLTK.Text = "Quản lý tài khoản";
            this.tabQLTK.UseVisualStyleBackColor = true;
            // 
            // frmMenuAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuAction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuAction_FormClosed);
            this.Load += new System.EventHandler(this.frmMenuAction_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabQLDMSP;
        private System.Windows.Forms.TabPage tabQLHD;
        private System.Windows.Forms.TabPage tabQLNCC;
        private System.Windows.Forms.TabPage tabQLNV;
        private System.Windows.Forms.TabPage tabQLKH;
        private System.Windows.Forms.TabPage tabCreateBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TabPage tabStatistic;
        private System.Windows.Forms.TabPage tabQLTK;
    }
}