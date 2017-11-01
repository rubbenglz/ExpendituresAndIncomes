using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration; 

namespace Conexion.Mappings {
    
    
    public class WalsChoferesMap : ClassMap<WalsChoferes> {
        
        public WalsChoferesMap() {
			Table("WALS_Choferes");
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
			LazyLoad();
            Id(x => x.Chofer).GeneratedBy.Assigned().Column("Chofer");
			Map(x => x.Descripcion).Column("Descripción").Length(40);
            //Map(x => x.Usuario).Column("Usuario").Length(40);
            Map(x => x.Estatus).Column("Estatus");
        }
    }
}
