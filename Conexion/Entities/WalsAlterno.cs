using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities
{
    public class WalsAlterno
    {
        public virtual int Producto { get; set; }
        public virtual string Almacen { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Estatus { get; set; }
        public virtual string EsCodigoProveedor { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as WalsAlterno;
            if (t == null) return false;
            if (Producto == t.Producto
             && Almacen == t.Almacen
             && Codigo == t.Codigo)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Producto.GetHashCode();
            hash = (hash * 397) ^ Almacen.GetHashCode();
            hash = (hash * 397) ^ Codigo.GetHashCode();
            return hash;
        }
        #endregion
    }
}
