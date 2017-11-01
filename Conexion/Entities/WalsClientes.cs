using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities {
    
    public class WalsClientes {
        public virtual int Cliente { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string Direccion_completa { get; set; }
        public virtual string Correo_electronico { get; set; }
        public virtual string Estatus { get; set; }
    }
}
