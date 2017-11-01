using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities {
    
    public class Coladespachador {
        public virtual int Id { get; set; }
        public virtual int DespachadorId { get; set; }
        public virtual string Argumentos { get; set; }
        public virtual EstatusDespachadorCola Estatus { get; set; }
        public virtual DateTime FechaInicio { get; set; }
        public virtual DateTime? FechaFin { get; set; }
        public virtual string UsuarioID { get; set; }
        public virtual Despachador Despachador { get; set; }

        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as Coladespachador;
            if (t == null) return false;
            if (Id == t.Id)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Id.GetHashCode();

            return hash;
        }
        #endregion
    }
}
