//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class DANGKYTIETHOC
    {
        [Key]
        public int ID { get; set; }
        public string MADM { get; set; }
        public string MAGV { get; set; }
        public string MALOP { get; set; }
        public string MAPHONG { get; set; }
        public Nullable<System.DateTime> CABATDAU { get; set; }
        public string GHICHU { get; set; }
    
        public virtual LOP LOP { get; set; }
        public virtual PHONG PHONG { get; set; }
        public virtual DAYMAY DAYMAY { get; set; }
        public virtual GIANGVIEN GIANGVIEN { get; set; }
    }
}
