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

    public partial class Hojaencabezado
    {
        public Hojaencabezado()
        {
            this.Hojadetalle = new HashSet<Hojadetalle>();
        }

        public int HojaencabezadoId { get; set; }
        public Nullable<int> EmpleadoId { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public string observacion { get; set; }
        public bool estado_hoja { get; set; }

        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<Hojadetalle> Hojadetalle { get; set; }
    }
}
