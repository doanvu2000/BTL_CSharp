
namespace BTL_CSharp
{
    partial class frmStatistic
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
            this.btnOneDay = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.btnBetween = new System.Windows.Forms.Button();
            this.tablePanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.tablePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMinProDuct = new System.Windows.Forms.Label();
            this.lblMaxProDuct = new System.Windows.Forms.Label();
            this.lblToTal = new System.Windows.Forms.Label();
            this.tablePanel2.SuspendLayout();
            this.tablePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // btnOneDay
            // 
            this.btnOneDay.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOneDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOneDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneDay.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOneDay.Location = new System.Drawing.Point(3, 3);
            this.btnOneDay.Name = "btnOneDay";
            this.btnOneDay.Size = new System.Drawing.Size(270, 79);
            this.btnOneDay.TabIndex = 2;
            this.btnOneDay.Text = "Ngày hiện tại";
            this.btnOneDay.UseVisualStyleBackColor = false;
            this.btnOneDay.Click += new System.EventHandler(this.btnOneDay_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLastMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastMonth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLastMonth.Location = new System.Drawing.Point(832, 3);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(271, 79);
            this.btnLastMonth.TabIndex = 2;
            this.btnLastMonth.Text = "Doanh thu  tháng trước";
            this.btnLastMonth.UseVisualStyleBackColor = false;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // btnBetween
            // 
            this.btnBetween.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBetween.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetween.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBetween.Location = new System.Drawing.Point(279, 3);
            this.btnBetween.Name = "btnBetween";
            this.btnBetween.Size = new System.Drawing.Size(547, 79);
            this.btnBetween.TabIndex = 2;
            this.btnBetween.Text = "Doanh thu theo khoảng thời gian";
            this.btnBetween.UseVisualStyleBackColor = false;
            this.btnBetween.Click += new System.EventHandler(this.btnBetween_Click);
            // 
            // tablePanel2
            // 
            this.tablePanel2.ColumnCount = 1;
            this.tablePanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel2.Controls.Add(this.label1, 0, 0);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.RowCount = 1;
            this.tablePanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel2.Size = new System.Drawing.Size(1106, 71);
            this.tablePanel2.TabIndex = 2;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeBegin.Location = new System.Drawing.Point(224, 3);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(215, 22);
            this.dateTimeBegin.TabIndex = 0;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeEnd.Location = new System.Drawing.Point(666, 3);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(215, 22);
            this.dateTimeEnd.TabIndex = 1;
            // 
            // tablePanel1
            // 
            this.tablePanel1.ColumnCount = 5;
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablePanel1.Controls.Add(this.dateTimeBegin, 1, 0);
            this.tablePanel1.Controls.Add(this.dateTimeEnd, 3, 0);
            this.tablePanel1.Controls.Add(this.button1, 0, 0);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 71);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.RowCount = 1;
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel1.Size = new System.Drawing.Size(1106, 45);
            this.tablePanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnLastMonth, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOneDay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBetween, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1106, 85);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dgvSanPham, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 201);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1106, 192);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 3);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(1100, 186);
            this.dgvSanPham.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lblMinProDuct, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblMaxProDuct, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblToTal, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 393);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1106, 174);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // lblMinProDuct
            // 
            this.lblMinProDuct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMinProDuct.AutoSize = true;
            this.lblMinProDuct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinProDuct.Location = new System.Drawing.Point(30, 114);
            this.lblMinProDuct.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblMinProDuct.Name = "lblMinProDuct";
            this.lblMinProDuct.Size = new System.Drawing.Size(219, 60);
            this.lblMinProDuct.TabIndex = 2;
            this.lblMinProDuct.Text = "Sản phẩm bán ít nhất: ";
            // 
            // lblMaxProDuct
            // 
            this.lblMaxProDuct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaxProDuct.AutoSize = true;
            this.lblMaxProDuct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxProDuct.Location = new System.Drawing.Point(30, 57);
            this.lblMaxProDuct.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblMaxProDuct.Name = "lblMaxProDuct";
            this.lblMaxProDuct.Size = new System.Drawing.Size(253, 57);
            this.lblMaxProDuct.TabIndex = 1;
            this.lblMaxProDuct.Text = "Sản phẩm bán chạy nhất: ";
            // 
            // lblToTal
            // 
            this.lblToTal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToTal.AutoSize = true;
            this.lblToTal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToTal.Location = new System.Drawing.Point(30, 0);
            this.lblToTal.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblToTal.Name = "lblToTal";
            this.lblToTal.Size = new System.Drawing.Size(118, 57);
            this.lblToTal.TabIndex = 0;
            this.lblToTal.Text = "Doanh thu: ";
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1106, 656);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.tablePanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStatistic";
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            this.tablePanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOneDay;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnBetween;
        private System.Windows.Forms.TableLayoutPanel tablePanel2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.TableLayoutPanel tablePanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMinProDuct;
        private System.Windows.Forms.Label lblMaxProDuct;
        private System.Windows.Forms.Label lblToTal;
        private System.Windows.Forms.Button button1;
    }
}