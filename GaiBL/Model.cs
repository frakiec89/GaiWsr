//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GaiBL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Model()
        {
            this.Cars = new HashSet<Cars>();
        }
    
        public int IdModel { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdConstructor { get; set; }
        public Nullable<int> IdTypeChassis { get; set; }
        public Nullable<int> IdTypeСategory { get; set; }
        public Nullable<int> IdTypeEngines { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cars> Cars { get; set; }
        public virtual Chassis Chassis { get; set; }
        public virtual Constructor Constructor { get; set; }
        public virtual Engines Engines { get; set; }
        public virtual Сategory Сategory { get; set; }
    }
}
