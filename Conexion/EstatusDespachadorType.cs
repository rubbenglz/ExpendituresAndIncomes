using NHibernate;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;
using System;
using System.Data;

namespace Conexion
{
    public class EstatusDespachadorType : IUserType
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
                return typeof(EstatusDespachador);
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
            if (text != "0" && text != "1")
            {
                throw new Exception(string.Format("Se esperaba un codigo de estatus pero fue '{0}'.", text));
            }
            string a;
            if ((a = text) != null)
            {
                if (a == "0")
                    return EstatusDespachador.Apagado;
                if (a == "1")
                    return EstatusDespachador.Encendido;
            }
            return EstatusDespachador.Desconocido;
        }

        public void NullSafeSet(IDbCommand cmd, object value, int index)
        {
            if (value == null)
            {
                ((IDataParameter)cmd.Parameters[index]).Value = " ";
                return;
            }
            switch ((EstatusDespachador)value)
            {
                case EstatusDespachador.Apagado:
                    ((IDataParameter)cmd.Parameters[index]).Value = "0";
                    return;
                case EstatusDespachador.Encendido:
                    ((IDataParameter)cmd.Parameters[index]).Value = "1";
                    return;
                case EstatusDespachador.Desconocido:
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
            if (ReferenceEquals(x, y)) return true;

            var xString = x as string;
            var yString = y as string;
            if (xString == null || yString == null) return false;

            return xString.Equals(yString);
        }

        public int GetHashCode(object x)
        {
            if (x != null)
            {
                return x.GetHashCode();
            }
            return typeof(EstatusDespachador).GetHashCode() + 473;
        }
    }

    public enum EstatusDespachador
    {
        Apagado,
        Encendido,
        Desconocido
    }
}
