using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{
    
    public class Entradassalidas {
        public virtual int ES_Index { get; set; }
        public virtual string ES_Tipo { get; set; }
        public virtual string ES_Descripcion { get; set; }
        public virtual decimal ES_Cantidad { get; set; }
        public virtual DateTime ES_Fecha { get; set; }
        public virtual string ES_UsuarioMod { get; set; }
        public virtual string ES_Equipo { get; set; }
        public virtual DateTime ES_FechaAlta { get; set; }
        public virtual DateTime ES_FechaMod { get; set; }
    }
}
