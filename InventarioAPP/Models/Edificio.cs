//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;

    public partial class Edificio
    {
        public Edificio()
        {
            this.Ubicacion = new HashSet<Ubicacion>();
        }

        public int EdificioId { get; set; }
        public string nombre_edificio { get; set; }
        public string observacion { get; set; }
        public bool estado_edificio { get; set; }

        public virtual ICollection<Ubicacion> Ubicacion { get; set; }
    }
}
