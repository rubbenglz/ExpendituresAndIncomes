using System;
using System.Text;
using System.Collections.Generic;

namespace Conexion.Entities
{
    public class WalsAyudanteChofer
    {
        public virtual string ClaveAyudante { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string Estatus { get; set; }
    }
}
