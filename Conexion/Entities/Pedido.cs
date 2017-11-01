using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{
   public class Pedido
    {
        public virtual double Acuse { get; set; }
        public virtual string GlClass { get; set; }
        public virtual double Folio { get; set; }
        public virtual string TipOrden { get; set; }
        public virtual string Almacen { get; set; }
        public virtual double URAT { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as Pedido;
            if (t == null) return false;
            if (Folio == t.Folio
             && TipOrden == t.TipOrden
             && Almacen == t.Almacen)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Folio.GetHashCode();
            hash = (hash * 397) ^ TipOrden.GetHashCode();
            hash = (hash * 397) ^ Almacen.GetHashCode();

            return hash;
        }
        #endregion
    }
}
