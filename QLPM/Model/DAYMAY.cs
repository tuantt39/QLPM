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

    public partial class DAYMAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAYMAY()
        {
            this.DANGKYTIETHOCs = new HashSet<DANGKYTIETHOC>();
            this.MAYTINHs = new HashSet<MAYTINH>();
        }
        [Key]
        public string MADM { get; set; }
        public string MATT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGKYTIETHOC> DANGKYTIETHOCs { get; set; }
        public virtual ICollection<MAYTINH> MAYTINHs { get; set; }
        public virtual TRANGTHAI TRANGTHAI { get; set; }
    }
}