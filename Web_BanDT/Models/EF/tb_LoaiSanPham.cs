//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_BanDT.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_LoaiSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_LoaiSanPham()
        {
            this.TB_PRODUCT = new HashSet<TB_PRODUCT>();
        }
    
        public int ID { get; set; }
        public string tieuDeLSP { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string SeoMoTa { get; set; }
        public string SeoTuKhoa { get; set; }
        public string SeoTieuDe { get; set; }
        public string biDanhLSP { get; set; }
        public string icon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRODUCT> TB_PRODUCT { get; set; }
    }
}
