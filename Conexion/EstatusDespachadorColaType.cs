using NHibernate;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;
using System;
using System.Data;

namespace Conexion
{
    public class EstatusDespachadorColaType : IUserType
    {
        public bool IsMutable
        {
            get
            {
                return false;
            }
        }

        public Type ReturnedType
        {
            get
            {
                return typeof(EstatusDespachadorCola);
            }
        }

        public SqlType[] SqlTypes
        {
            get
            {
                return new SqlType[]
				{
					NHibernateUtil.String.SqlType
				};
            }
        }

        public object NullSafeGet(IDataReader rs, string[] names, object owner)
        {
            object obj = NHibernateUtil.String.NullSafeGet(rs, names[0]);
            if (obj == null)
            {
                return null;
            }
            string text = ((string)obj).Trim();
            if (text != "W" && text != "P" && text != "D" && text != "E" && text != "F")
            {
                throw new Exception(string.Format("Se esperaba un codigo de estatus pero fue '{0}'.", text));
            }
            string a;
            if ((a = text) != null)
            {
                if (a == "W")
                    return EstatusDespachadorCola.Espera;
                if (a == "P")
                    return EstatusDespachadorCola.Proceso;
                if (a == "D")
                    return EstatusDespachadorCola.Terminado;
                if (a == "E")
                    return EstatusDespachadorCola.Error;
                if (a == "F")
                    return EstatusDespachadorCola.Fallo;
            }
            return EstatusDespachadorCola.Desconocido;
        }

        public void NullSafeSet(IDbCommand cmd, object value, int index)
        {
            if (value == null)
            {
                ((IDataParameter)cmd.Parameters[index]).Value = " ";
                return;
            }
            switch ((EstatusDespachadorCola)value)
            {
                case EstatusDespachadorCola.Espera:
                    ((IDataParameter)cmd.Parameters[index]).Value = "W";
                    return;
                case EstatusDespachadorCola.Proceso:
                    ((IDataParameter)cmd.Parameters[index]).Value = "P";
                    return;
                case EstatusDespachadorCola.Terminado:
                    ((IDataParameter)cmd.Parameters[index]).Value = "D";
                    return;
                case EstatusDespachadorCola.Error:
                    ((IDataParameter)cmd.Parameters[index]).Value = "E";
                    return;
                case EstatusDespachadorCola.Fallo:
                    ((IDataParameter)cmd.Parameters[index]).Value = "F";
                    return;
                case EstatusDespachadorCola.Desconocido:
                    ((IDataParameter)cmd.Parameters[index]).Value = "";
                    return;
                default:
                    return;
            }
        }

        public object DeepCopy(object value)
        {
            return value;
        }

        public object Replace(object original, object target, object owner)
        {
            return original;
        }

        public object Assemble(object cached, object owner)
        {
            return cached;
        }

        public object Disassemble(object value)
        {
            return value;
        }

        public new bool Equals(object x, object y)
        {
            return object.ReferenceEquals(x, y) || (x != null && y != null && x.Equals(y));
        }

        public int GetHashCode(object x)
        {
            if (x != null)
            {
                return x.GetHashCode();
            }
            return typeof(EstatusDespachadorCola).GetHashCode() + 473;
        }
    }

    public enum EstatusDespachadorCola
    {
        Espera,
        Proceso,
        Terminado,
        Error,
        Fallo,
        Desconocido
    }
}
