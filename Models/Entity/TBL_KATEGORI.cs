//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Devrekani_Sehitler_Kutuphanesi.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_KATEGORI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_KATEGORI()
        {
            this.TBL_KITAP = new HashSet<TBL_KITAP>();
        }
    
        public byte ID { get; set; }
        public string AD { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_KITAP> TBL_KITAP { get; set; }
    }
}
