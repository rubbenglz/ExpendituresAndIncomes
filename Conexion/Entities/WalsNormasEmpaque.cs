using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{
    public class WalsNormasEmpaque
    {
        public virtual string ClaveProducto { get; set; }
        public virtual string NormaDeEmpaque { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Estatus { get; set; }
        public virtual float Largo { get; set; }
        public virtual float Alto { get; set; }
        public virtual float Ancho { get; set; }
        public virtual float Cantidad { get; set; }
        public virtual string CodigoDeEmpaque { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as WalsNormasEmpaque;
            if (t == null) return false;
            if (ClaveProducto == t.ClaveProducto
             && NormaDeEmpaque == t.NormaDeEmpaque
                && CodigoDeEmpaque == t.CodigoDeEmpaque)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ ClaveProducto.GetHashCode();
            hash = (hash * 397) ^ NormaDeEmpaque.GetHashCode();
            hash = (hash * 397) ^ CodigoDeEmpaque.GetHashCode();
            return hash;
        }
        #endregion
    }
}