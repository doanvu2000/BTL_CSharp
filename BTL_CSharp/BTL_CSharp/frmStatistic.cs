using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CSharp
{
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
        }
        DBEntites db = new DBEntites();
        List<SanPhamTam> list = new List<SanPhamTam>();
        DateTime start, end;
        private void frmStatistic_Load(object sender, EventArgs e)
        {
        }
        public List<SanPhamTam> GetAllSanPhamByDate(DateTime dateStart, DateTime dateEnd)
        {

            List<SanPhamTam> ls = new List<SanPhamTam>();
            var hd = db.HoaDons.Select(s => s);
            foreach (var s in hd)
            {
                DateTime ngaylap = s.NgayLap.Value;
                if (DateTime.Compare(ngaylap, dateStart) >= 0 &&
                    DateTime.Compare(ngaylap, dateEnd) <= 0)
                {//kiểm tra hóa đơn có ngày lập là date
                    int mahd = s.MaHD;
                    var record = db.ChiTietHDs.Join(db.SanPhams, ct => ct.MaSP, sp => sp.MaSP,
                        (ct, sp) => new
                        {
                            sanpham = sp,
                            chitiet = ct
                        }).Where(p => p.chitiet.MaHD == mahd).Select(p => new
                        {
                            masp = p.sanpham.MaSP,
                            tensp = p.sanpham.TenSP,
                            gia = p.sanpham.Gia,
                            slban = p.chitiet.SLBan
                        });
                    //record: tất cả các sản phẩm được bán vào thời gian "date"
                    foreach (var item in record)
                    {
                        int masp = item.masp;
                        string tensp = item.tensp;
                        int slban = (int)item.slban;
                        int gia = (int)item.gia;
                        int index = CheckInList(masp, ls);// kiểm tra xem sp có trong list chưa
                        if (index == -1)//chưa có thì add vào list
                            ls.Add(new SanPhamTam(item.masp, item.tensp, gia, slban));
                        else ls[index].SLMua += slban;//nếu có thì tăng thêm slban
                    }
                }
            }
            return ls;
        }
        public void setInformation()
        {
            if (list.Count <= 0)
            {
                lblToTal.Text = "Tổng doanh thu: 0 VNĐ";
                return;
            }
            int sum = 0;
            int slMax = list[0].SLMua, slMin = list[0].SLMua;
            int maspMax = list[0].MaSP, maspMin = list[0].MaSP;
            foreach (var s in list)
            {
                sum += s.Gia * s.SLMua;
                if (s.SLMua > slMax)
                {
                    slMax = s.SLMua;
                    maspMax = s.MaSP;
                }
                if (s.SLMua < slMin)
                {
                    slMin = s.SLMua;
                    maspMin = s.MaSP;
                }
            }
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string total = sum.ToString("#,###.###", cul.NumberFormat);
            lblToTal.Text = "Tổng doanh thu: " + total + "VNĐ";
            lblMaxProDuct.Text = "Sản phẩm bán chạy nhất: " + list[CheckInList(maspMax, list)].TenSP
                + "       -    Số lượng: " + slMax;
            lblMinProDuct.Text = "Sản phẩm bán ít nhất: " + list[CheckInList(maspMin, list)].TenSP
               + "       -    Số lượng: " + slMin;
        }

        private void btnOneDay_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            start = end = now;
            list = GetAllSanPhamByDate(now, now);
            setInformation();
            list.Sort((x, y) => { return x.SLMua - y.SLMua; });
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = list;
            dgvSanPham.Columns.RemoveAt(4);
        }
        public int CheckInList(int masp, List<SanPhamTam> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].MaSP == masp)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnBetween_Click(object sender, EventArgs e)
        {
            DateTime timeBegin = dateTimeBegin.Value;
            DateTime timeEnd = dateTimeEnd.Value;
            start = timeBegin;
            end = timeEnd;
            if (timeBegin.CompareTo(timeEnd) >= 0)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            list = GetAllSanPhamByDate(timeBegin, timeEnd);
            setInformation();
            list.Sort((x, y) => { return x.SLMua - y.SLMua; });
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = list;
            dgvSanPham.Columns.RemoveAt(4);
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            start = first;
            end = last;
            list = GetAllSanPhamByDate(first, last);
            setInformation();
            list.Sort((y, x) => { return x.SLMua - y.SLMua; });
            dgvSanPham.DataSource = null;
            dgvSanPham.DataSource = list;
            dgvSanPham.Columns.RemoveAt(4);
        }
        public void exportExcelFile()
        {
            int rowIndex = 1;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);

            excelApp.Cells[rowIndex, 1] = "BÁO CÁO DOANH THU";
            rowIndex++;
            if (DateTime.Compare(start, end) != 0)
            {
                excelApp.Cells[rowIndex, 1] = "Thời gian bắt đầu: ";
                excelApp.Cells[rowIndex, 2] = start.ToShortDateString();
                rowIndex++;
                excelApp.Cells[rowIndex, 1] = "Thời gian kết thúc: ";
                excelApp.Cells[rowIndex, 2] = end.ToShortDateString();
                rowIndex++;
            }
            else
            {
                excelApp.Cells[rowIndex, 1] = "Thời gian bán: ";
                excelApp.Cells[rowIndex, 2] = start.ToShortDateString();
                rowIndex++;
            }

            rowIndex++;
            //header table
            excelApp.Cells[rowIndex, 2] = "STT";
            for (int i = 1; i < dgvSanPham.Columns.Count + 1; i++)
            {
                excelApp.Cells[rowIndex, i+2] = dgvSanPham.Columns[i - 1].HeaderText;
            }
            rowIndex++;
            //data table
            int count = 1;
            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                excelApp.Cells[i + rowIndex,  2] = count;
                for (int j = 0; j < dgvSanPham.Columns.Count; j++)
                {   
                    excelApp.Cells[i + rowIndex, j + 3] = dgvSanPham.Rows[i].Cells[j].Value+"";
                }
                count++;

            }
            rowIndex += count+2;
            excelApp.Cells[rowIndex, 1] = lblToTal.Text;
            rowIndex += 2;
            excelApp.Cells[rowIndex, 1] = lblMaxProDuct.Text;
            rowIndex += 2;
            excelApp.Cells[rowIndex, 1] = lblMinProDuct.Text;
            rowIndex++;

            excelApp.Columns.AutoFit();
            excelApp.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            exportExcelFile();
        }
    }
}
