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
    
    public partial class ChiTietHD
    {
        public int STT { get; set; }
        public string MaHD { get; set; }
        public string MaVe { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<double> TongTien { get; set; }
        public string MaCB { get; set; }
    
        public virtual HoaDon HoaDon { get; set; }
        public virtual Ve Ve { get; set; }
    }
}
