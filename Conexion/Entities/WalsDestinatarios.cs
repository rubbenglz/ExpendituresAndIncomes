using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities {
    
    public class WalsDestinatarios {
        public virtual int Destinatario { get; set; }
        public virtual int Cliente { get; set; }
        public virtual string DescripcionComercial { get; set; }
        public virtual string Descripcion { get; set; }

        public virtual string Ruta { get; set; }
        public virtual string Calle_y_numero { get; set; }
        public virtual string Colonia { get; set; }
        public virtual string Poblacion { get; set; }
        public virtual string Ciudad { get; set; }
        public virtual string Estado { get; set; }
        public virtual string Pais { get; set; }
        public virtual string CP { get; set; }
        public virtual string RutaDescripcion { get; set; }
        public virtual string Estatus { get; set; }

        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as WalsDestinatarios;
            if (t == null) return false;
            if (Destinatario == t.Destinatario
             && Cliente == t.Cliente)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Destinatario.GetHashCode();
            hash = (hash * 397) ^ Cliente.GetHashCode();

            return hash;
        }
        #endregion
    }
}
