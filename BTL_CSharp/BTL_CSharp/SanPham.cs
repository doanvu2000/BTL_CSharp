//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL_CSharp
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietHDs = new HashSet<ChiTietHD>();
        }
    
        public int MaSP { get; set; }
        public int MaDM { get; set; }
        public string TenSP { get; set; }
        public Nullable<int> SLTon { get; set; }
        public Nullable<int> Gia { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> MaNCC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
        public virtual NCC NCC { get; set; }
    }
}
