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
    public partial class frmLapHoaDon : Form
    {
        List<SanPhamTam> list = new List<SanPhamTam>();
        List<SanPhamTonTam> li = new List<SanPhamTonTam>();
        List<SanPham> listSP = new List<SanPham>();
        public KhachHang kh = new KhachHang();
        public TaiKhoan tk = new TaiKhoan();
        bool sale = false;
        public frmLapHoaDon()
        {
            InitializeComponent();

        }
        public frmLapHoaDon(KhachHang k, TaiKhoan t, bool isSale)
        {
            InitializeComponent();
            kh = k;
            tk = t;
            DBEntites db = new DBEntites();

            int manv = tk.NhanVien.MaNV;
            var nv = db.NhanViens.Where(s => s.MaNV == manv).Select(s => s).FirstOrDefault();
            lblNhanVien.Text = "Nhân viên tạo hóa đơn: " + nv.TenNV;


            sale = isSale;
            lblKhachHang.Text = "Khách hàng: " + kh.TenKH + "               SĐT: " + kh.SDT;

            if (sale)
            {
                lblSale.Text = "Đã mua hàng ít nhất 1 lần, được giảm 2% hóa đơn";
            }
            else lblSale.Text = "";
        }
        void PopulateDataGridViewSP()
        {
            using (DBEntites db = new DBEntites())
            {
                // Kết nối hai bảng Sản phẩm và bảng NCC
                var sp = db.SanPhams.Join(db.NCCs, s => s.MaNCC, n => n.MaNCC,
                    (s, n) => new
                    {
                        sp = s,
                        ncc = n

                    }).Select(s => new
                    {
                        masp = s.sp.MaSP,
                        tensp = s.sp.TenSP,
                        slton = s.sp.SLTon,
                        gia = s.sp.Gia,
                        ncc = s.ncc.TenNCC,
                        mancc = s.ncc.MaNCC
                    });

                /*
                 * Sử dụng đối tượng SanPhamTonTam để thao tác dữ liệu tránh trường hợp người dùng 
                 * thêm sản phầm nhưng trả lại hoặc hủy đơn hàng.
                 * Không thao tác trực tiếp trên database.
                 */
                for (int i = 0; i < sp.ToList().Count; i++)
                {
                    int masp = int.Parse(sp.ToList()[i].masp.ToString());
                    string tensp = sp.ToList()[i].tensp.ToString();
                    int slton = int.Parse(sp.ToList()[i].slton.ToString());
                    float gia = float.Parse(sp.ToList()[i].gia.ToString());
                    string ncc = sp.ToList()[i].ncc.ToString();
                    li.Add(new SanPhamTonTam(masp, tensp, slton, gia, ncc));

                }
                gridviewSanPham.DataSource = li.ToList();
                gridviewSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // lblTongTien.Text = 
            }
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            PopulateDataGridViewSP();
        }

        private void gridviewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow currentRow = gridviewSanPham.CurrentRow;
                int masp = int.Parse(currentRow.Cells[0].Value + "");
                // Nối hai bảng SanPham và bảng NCC sau đó lấy ra các cột cần thiết 

                string tenSP = currentRow.Cells[1].Value + "";
                int slMua = 1;
                int gia = int.Parse(currentRow.Cells[3].Value + "");
                string tenNCC = currentRow.Cells[4].Value + "";

                int tonTaiSP = TonTaiSanPham(new SanPhamTam(masp, tenSP, slMua, gia, tenNCC), masp);
                /*
                 * Kiểm tra sản phầm vừa được thêm đã tồn tại trong gridview hay chưa
                 * -1: chưa tồn tại
                 * khác -1: đã tồn tại
                 */
                if (tonTaiSP == -1)
                {
                    list.Add(new SanPhamTam(masp, tenSP, slMua, gia, tenNCC));
                }
                else
                {
                    list[tonTaiSP].SLMua = list[tonTaiSP].SLMua + 1;
                }
                int slmua = SoLuongSP(masp);
                CapNhatSL(masp, slmua);
                //bugs
                gridviewGioHang.DataSource = list.ToList();
                gridviewGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
        * btnLuu: Sử dụng để cập nhật dữ liệu trong database
        * giảm số lượng hàng tồn trong db khi một hóa đơn được lập thành công.
        */
        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (DBEntites db = new DBEntites())
            {
                if (gridviewGioHang.DataSource == null)
                {
                    return;
                }
                listSP = db.SanPhams.ToList<SanPham>();
                foreach (SanPham s in listSP)
                {
                    s.SLTon = li[ViTriSPT(s.MaSP)].slton;
                }
                foreach (SanPham s in listSP)
                {
                    db.Entry(s).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                HoaDon new_HD = new HoaDon();
                new_HD.NgayLap = DateTime.Today;
                //fix
                new_HD.MaKH = kh.MaKH;               
                new_HD.MaNV = (int)tk.manv;
                //----
                //add HoaDon
                db.HoaDons.Add(new_HD);
                db.SaveChanges();
                List<HoaDon> hd = db.HoaDons.Select(s => s).ToList();
                //add chiTietHD
                //duyệt lần lượt danh sách sản phẩm mua và add vào bảng chi tiết
                foreach (SanPhamTam s in list)
                {
                    ChiTietHD chiTiet = new ChiTietHD();
                    chiTiet.MaHD = hd[hd.Count - 1].MaHD;
                    chiTiet.MaSP = s.MaSP;
                    chiTiet.SLBan = s.SLMua;
                    db.ChiTietHDs.Add(chiTiet);
                    db.SaveChanges();
                }
                //done
                MessageBox.Show("Hóa đơn của bạn đã được tạo");
                Close();
            }


        }

        /*
         * Kiểm tra sản phẩm đã tồn tại trong gridviewGioHang chưa
         * Nếu đã tồn tại thì trả về vị trí của sản phẩm trong đối tượng
         * Nếu chưa thì trả về giá trị -1
         */
        private int TonTaiSanPham(SanPhamTam sp, int masp)
        {
            int viTri = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaSP == masp)
                    viTri = i;
            }
            return viTri;
        }

        private int ViTriSPT(int masp)
        {
            int vt = -1;
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].masp == masp)
                    vt = i;
            }
            return vt;
        }

        /*
         * Kiểm tra xóa sản phẩm khỏi gridviewCart nếu sản phẩm đó có số lượng 1.
         * Nếu số lượng lớn hơn 1 sẽ giảm số lượng của sản phẩm đó xuống 1.
         */
        private void removeSP(int masp)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaSP == masp)
                {
                    if (list[i].SLMua > 1)
                    {
                        list[i].SLMua--;
                        li[ViTriSPT(masp)].slton++;
                    }
                    else
                    {
                        list.Remove(list[i]);
                        li[ViTriSPT(masp)].slton++;
                    }
                }
            }
        }

        /*
         * Bớt sản phẩm trong gridviewCart
         */
        private void gridviewGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            removeSP(int.Parse(gridviewGioHang.CurrentRow.Cells[0].Value + ""));
            gridviewGioHang.DataSource = null;
            gridviewGioHang.DataSource = list.ToList();
            gridviewSanPham.DataSource = null;
            gridviewSanPham.DataSource = li.ToList();
            gridviewSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /*
         * Hàm trả về số lượng sản phẩm đã mua trong gridviewCart
         */
        private int SoLuongSP(int masp)
        {
            int sl = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaSP == masp)
                    sl = list[i].SLMua;
            }
            return sl;
        }

        /*
         * Hàm tự động cập nhật số lượng sản phẩm tồn
         */
        private void CapNhatSL(int masp, int sl)
        {
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].masp == masp)
                {
                    if (li[i].slton > 0)
                        li[i].slton--;
                    else
                    {
                        MessageBox.Show("Không đủ số lượng để mua");
                        return;
                    }
                    gridviewSanPham.DataSource = null;
                    gridviewSanPham.DataSource = li.ToList();
                    gridviewSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void gridviewGioHang_DataSourceChanged(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (SanPhamTam s in list)
            {
                sum += s.Gia * s.SLMua;
            }
            if (sale)
            {
                sum = (sum * 98) / 100;
            }
            //format money vietnamese
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            string total = sum.ToString("#,###.###", cul.NumberFormat);
            lblTongTien.Text = total + "VNĐ";
        }
    }
}
