//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pjPrueba1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Gente
    {
        public int id { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }
        public Nullable<int> edad { get; set; }
        public Nullable<int> idsexo { get; set; }
    
        public virtual cSexo cSexo { get; set; }
    }
}
