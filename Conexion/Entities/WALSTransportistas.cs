using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{
    public class WalsTransportistas
    {
        public virtual int ClaveTransportista { get; set; }
        public virtual string NombreTransportista { get; set; }
        public virtual string Estatus { get; set; }
    }
}
