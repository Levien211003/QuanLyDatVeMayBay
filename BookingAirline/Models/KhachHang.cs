//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookingAirline.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        BookingAirLightEntities db = new BookingAirLightEntities();
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.HoaDon = new HashSet<HoaDon>();
            this.Ve = new HashSet<Ve>();
        }
    
        public string IDKH { get; set; }
        public string CCCD { get; set; }
        public string MaLKH { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string HinhAnh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
        public virtual LoaiKH LoaiKH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ve { get; set; }

        
    }

}
