using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities
{

    public class WalsProveedores
    {
        public virtual int Clave_del_proveedor { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Retiene_acomodo { get; set; }
        public virtual string Estatus { get; set; }
        public virtual string Foto_Obligada { get; set; }
    }
}
