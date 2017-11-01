using System;
using System.Text;
using System.Collections.Generic;


namespace Conexion.Entities
{

    public class Despachador
    {
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual int Prioridad { get; set; }
        public virtual EstatusDespachador Estatus { get; set; }
        public virtual IList<Coladespachador> Detalles { get; set; }
        public Despachador()
        {
            Detalles = new List<Coladespachador>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as Despachador;
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
    }
}
