using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities
{

    public class WalsConfCliente
    {
        public virtual string Compaia { get; set; }
        public virtual string TipoDocumento { get; set; }
        public virtual decimal NumeroDocumento { get; set; }
        public virtual string SNumeroDocumento { get; set; }
        public virtual string Almacen { get; set; }
        public virtual string Detalle { get; set; }
        public virtual string ECompaia { get; set; }
        public virtual string ETipoDocumento { get; set; }
        public virtual decimal ENumeroDocumento { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as WalsConfCliente;
            if (t == null) return false;
            if (Compaia == t.Compaia
             && TipoDocumento == t.TipoDocumento
             && NumeroDocumento == t.NumeroDocumento)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Compaia.GetHashCode();
            hash = (hash * 397) ^ TipoDocumento.GetHashCode();
            hash = (hash * 397) ^ NumeroDocumento.GetHashCode();

            return hash;
        }
        #endregion
    }
}
