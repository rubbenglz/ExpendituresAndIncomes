using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Conexion.Entities;

namespace Conexion.Ninject
{
    public class NHibernateHelper
    {
        private readonly string _connectionString;
        private ISessionFactory _sessionFactory;


        public ISessionFactory SessionFactory
        {
            get
            {
                ISessionFactory arg_19_0;
                if ((arg_19_0 = this._sessionFactory) == null)
                {
                    arg_19_0 = (this._sessionFactory = this.CreateSessionFactory());
                }
                return arg_19_0;
            }
        }

        public NHibernateHelper(string connectionString)
        {
            _connectionString = connectionString;
          
        }

        private ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(_connectionString))
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly());
                    m.HbmMappings.AddFromAssemblyOf<Entradassalidas>();
                })
                .BuildSessionFactory();

        }

        public static string schemaDTA
        {
            get;
            set;
        }
        public static string schemaCTL
        {
            get;
            set;
        }


    }
}
