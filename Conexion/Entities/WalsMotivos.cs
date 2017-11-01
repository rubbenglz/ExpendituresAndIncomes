using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{
    public class WalsMotivos
    {
        public virtual string Llave { get; set; }
        public virtual string Clasificacion { get; set; }
        public virtual string Motivo { get; set; }
        public virtual string Estatus { get; set; }
    }
}
