using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CSharp
{
    public class SanPhamTam
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SLMua { get; set; }
        public int Gia { get; set; }
        public string TenNCC { get; set; }

        public SanPhamTam()
        {

        }
        public SanPhamTam(int MaSP, string TenSP, int SLMua, int Gia, string TenNCC)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.SLMua = SLMua;
            this.Gia = Gia;
            this.TenNCC = TenNCC;
        }
        public SanPhamTam(int MaSP, string TenSP,  int Gia, int SLMua)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.SLMua = SLMua;
            this.Gia = Gia;
        }
    }
}
