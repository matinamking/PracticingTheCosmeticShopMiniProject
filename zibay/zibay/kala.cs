//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zibay
{
    using System;
    using System.Collections.Generic;
    
    public partial class kala
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kala()
        {
            this.froshes = new HashSet<frosh>();
        }
    
        public int ID { get; set; }
        public Nullable<long> code_kala { get; set; }
        public string name_kala { get; set; }
        public string date_e { get; set; }
        public string mark { get; set; }
        public string mony { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<frosh> froshes { get; set; }
    }
}
