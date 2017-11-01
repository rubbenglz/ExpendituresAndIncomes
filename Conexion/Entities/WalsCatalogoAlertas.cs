using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities
{

    public class WalsCatalogoAlertas
    {
        public virtual string ClaveAlerta { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Mensaje { get; set; }
        public virtual string ClasificacionAlerta { get; set; }
        public virtual string Estatus { get; set; }
        public virtual byte[] Imagen { get; set; }
    }
}