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
    
    public partial class Ve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ve()
        {
            this.ChiTietHDs = new HashSet<ChiTietHD>();
        }
    
        public string MaVe { get; set; }
        public string MaCB { get; set; }
        public string MaHV { get; set; }
        public string IDKH { get; set; }
        public string TinhTrang { get; set; }
        public Nullable<double> GiaVe { get; set; }
        public string CCCD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }
        public virtual ChuyenBay ChuyenBay { get; set; }
        public virtual HangVe HangVe { get; set; }
    }
}
