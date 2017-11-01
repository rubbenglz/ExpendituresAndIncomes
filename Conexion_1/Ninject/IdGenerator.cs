using System;
using System.Collections.Generic;
using System.Data;
using NHibernate.Dialect;
using NHibernate.Engine;
using NHibernate.Id;
using System.Linq;
using NHibernate.Persister.Entity;
using NHibernate.Type;
using Conexion.Ninject;
using Conexion.Entities;


namespace Conexion
{
    public class IdGenerator : IIdentifierGenerator, IConfigurable
    {
        private string _tableName;
        // The "select max(id) ..." query will go into this proc:
        private string DefaultProcedureName = NHibernateHelper.schemaDTA + ".sp_nuevo_numero_de_folio :tabla";

        public string ProcedureName { get; protected set; }
        public string TableNameParameter { get; protected set; }
        public string OutputParameter { get; protected set; }

        public IdGenerator()
        {
            ProcedureName = DefaultProcedureName;
        }

        public object Generate(ISessionImplementor session, object obj)
        {
            //using (UnitOfWork unitOfWork = new UnitOfWork(session.Factory))
            //{
            //    Repository<NumeroDeAlerta> repository = new Repository<NumeroDeAlerta>(unitOfWork.Session);
            //    var result = repository.ByRawQuery("EXEC [" + NHibernateHelper.schemaDTA + "].[sp_nuevo_numero_de_folio] '" + _tableName + "'").ToList<NumeroDeAlerta>().FirstOrDefault<NumeroDeAlerta>().EDBT;
            //    unitOfWork.Commit();
            //    return result;
            //}
            return null;
        }

        public void Configure(IType type, IDictionary<string, string> parms, Dialect dialect)
        {
            _tableName = parms["TableName"];
        }

        //private string GetTableName(ISessionImplementor session, Type objectType)
        //{
        //    //if (string.IsNullOrEmpty(_tableName))
        //    //{
        //    //    //Not set by configuration, default to the mapped table of the actual type from runtime object:
        //    //    var persister = (IJoinable)session.Factory.GetClassMetadata(objectType);

        //    //    var qualifiedTableName = persister.TableName.Split('.');
        //    //    _tableName = qualifiedTableName[qualifiedTableName.GetUpperBound(0)]; //Get last string
        //    //}

        //    //return _tableName;
        //}
    }
}
