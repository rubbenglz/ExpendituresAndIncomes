using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion.Entities;
using Conexion.Ninject;
using Ninject;
using System.Configuration;
using Conexion.Clases;
using NHibernate;
using Conexion.Classes;

namespace Conexion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var _connectionString = @"";
            NHibernateHelper helper = new NHibernateHelper(_connectionString);
            using (UnitOfWork unitOfWork = new UnitOfWork(helper.SessionFactory))
            {
                //Repository<F55items> repo = new Repository<F55items>(unitOfWork.Session);
            }

            Console.ReadLine();
        }
    }
}
