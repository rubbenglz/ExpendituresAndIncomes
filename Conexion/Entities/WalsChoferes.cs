using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities {
    
    public class WalsChoferes {
        public virtual int Chofer { get; set; }
        public virtual string Descripcion { get; set; }
        //public virtual string Usuario { get; set; }
        public virtual string Estatus { get; set; }
    }
}
