using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration; 

namespace Conexion.Mappings
{
    public class WalsAyudanteChoferMap : ClassMap<WalsAyudanteChofer>
    {
        public WalsAyudanteChoferMap()
        {
            Table("WALS_AyudanteChofer");
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            LazyLoad();
            Id(x => x.ClaveAyudante).GeneratedBy.Assigned().Column("ClaveAyudante");
            Map(x => x.Descripcion).Column("Descripción");
            Map(x => x.Estatus).Column("Estatus");
        }
    }
}
