using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration;

namespace Conexion.Mappings
{
    public class WalsTransportistasMap : ClassMap<WalsTransportistas>
    {

        public WalsTransportistasMap()
        {
            Table("WALS_Transportistas");
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            LazyLoad();
            Id(x => x.ClaveTransportista).GeneratedBy.Assigned().Column("ClaveTransportista");
            Map(x => x.NombreTransportista).Column("NombreTransportista");
            Map(x => x.Estatus).Column("Estatus");
        }
    }
}
