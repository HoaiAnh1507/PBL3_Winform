//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoHoaC_
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            this.DONHANGCHITIETs = new HashSet<DONHANGCHITIET>();
        }
    
        public int ID_SP { get; set; }
        public string TEN_SAN_PHAM { get; set; }
        public int ID_NCC { get; set; }
        public string TEN_DANH_MUC { get; set; }
        public string DON_VI { get; set; }
        public Nullable<decimal> DON_GIA { get; set; }
        public Nullable<int> SO_LUONG_CON_LAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANGCHITIET> DONHANGCHITIETs { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}