using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities {
    
    public class WalsCargaDevolucionesProveedor {
        public virtual decimal Folio { get; set; }
        public virtual string TipOrden { get; set; }
        public virtual string Vendedor { get; set; }
        public virtual decimal? Destinatario { get; set; }
        public virtual string Almacen { get; set; }
        public virtual int Acopio { get; set; }
        public virtual DateTime? FechaCaptura { get; set; }
        public virtual DateTime? FechaEntrega { get; set; }
        public virtual string Detalle { get; set; }
        public virtual string Estatus { get; set; }
        public virtual string Observaciones { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as WalsCargaDevolucionesProveedor;
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
