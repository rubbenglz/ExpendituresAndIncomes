using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion
{
    public class Registros
    {
        public bool Check { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime  Fecha { get; set; }
        public decimal Cantidad { get; set; }

        public int Id { get; set; }
    }
}
