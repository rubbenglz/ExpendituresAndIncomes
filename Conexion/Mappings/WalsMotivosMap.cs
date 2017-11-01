using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using System.Configuration;
using Conexion.Entities; 

namespace Conexion.Mappings
{
    public class WalsMotivosMap : ClassMap<WalsMotivos>
    {

        public WalsMotivosMap()
        {
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            Table("WALS_Motivos");
            LazyLoad();
            Id(x => x.Llave).Column("Llave");
            Map(x => x.Clasificacion).Column("Clasificacion");
            Map(x => x.Motivo).Column("Motivo");
            Map(x => x.Estatus).Column("Estatus");
        }
    }
}
