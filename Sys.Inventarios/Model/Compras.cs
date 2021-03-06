//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compras()
        {
            this.ComprasProductos = new HashSet<ComprasProductos>();
            this.Impuestos = new HashSet<Impuestos>();
        }
    
        public int Id { get; set; }
        public string Compra { get; set; }
        public int Empresa_Id { get; set; }
        public Nullable<decimal> CostoNeto { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> CostoTotal { get; set; }
        public System.DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public Nullable<int> Usuario_Id { get; set; }
    
        public virtual Empresas Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComprasProductos> ComprasProductos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Impuestos> Impuestos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
