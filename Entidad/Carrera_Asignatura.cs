//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carrera_Asignatura
    {
        public int Id { get; set; }
        public int id_carrera { get; set; }
        public int id_asignatura { get; set; }
    
        public virtual Asignatura Asignatura { get; set; }
        public virtual Carrera Carrera { get; set; }
    }
}
