using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{
    public class WalsAvisosEntradaDV
    {
        public virtual string FolioDeAcuse { get; set; }
        public virtual string ClaveDeProveedor { get; set; }
        public virtual string TipoDV { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string CartaPorte { get; set; }
        public virtual string Almacen { get; set; }
        public virtual string BuenEstado { get; set; }
        public virtual string Detalle { get; set; }
    }
}
