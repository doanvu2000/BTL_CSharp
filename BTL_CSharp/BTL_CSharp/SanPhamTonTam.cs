using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CSharp
{
    class SanPhamTonTam
    {
        public int masp { get; set; }
        public string tensp { get; set; }
        public int slton { get; set; }
        public float gia { get; set; }
        public string ncc { get; set; }

        public SanPhamTonTam()
        {

        }

        public SanPhamTonTam(int masp, string tensp, int slton, float gia, string ncc)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.slton = slton;
            this.gia = gia;
            this.ncc = ncc;
        }

    }
}
