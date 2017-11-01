using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{
    public class WalsCatalounidatrans
    {
        public virtual int UKID { get; set; }
        public virtual string Placas { get; set; }
        public virtual string Numeroeconomico { get; set; }
        public virtual string Tipodeunidad { get; set; }
        public virtual string Volumenmaximo { get; set; }
        public virtual string Volumencanastilla { get; set; }
        public virtual string Pesomaximo { get; set; }
        public virtual string Pesocanastilla { get; set; }
        public virtual string Unidadoremolque { get; set; }
        public virtual string Estatus { get; set; }
    }
}
