//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portafolio_OrnelasSamuel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Habilidad
    {
        public string id { get; set; }
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Porcentaje { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
