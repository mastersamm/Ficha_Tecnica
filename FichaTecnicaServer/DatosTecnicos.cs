//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FichaTecnicaServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class DatosTecnicos
    {
        public int Id { get; set; }
        public int Id_AnalisisServer { get; set; }
        public string Nombre { get; set; }
        public string Procesador { get; set; }
        public string Modelo { get; set; }
        public string Velocidad { get; set; }
        public string RAM { get; set; }
        public string TipoDSistema { get; set; }
        public string Dominio { get; set; }
        public string Edicion_Windows { get; set; }
    
        public virtual AnalisisServer AnalisisServer { get; set; }
    }
}
