//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NiceStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class ToolsTB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ToolsTB()
        {
            this.SCPs = new HashSet<SCP>();
        }
    
        public int ID { get; set; }
        public int Barcode { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Mojodi { get; set; }
        public string Type { get; set; }
        public Nullable<int> CartID { get; set; }
    
        public virtual CartTB CartTB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCP> SCPs { get; set; }
    }
}