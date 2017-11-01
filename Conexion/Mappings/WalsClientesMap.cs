using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration; 

namespace Conexion.Mappings {
    
    
    public class WalsClientesMap : ClassMap<WalsClientes> {
        
        public WalsClientesMap() {
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
			Table("WALS_Clientes");
			LazyLoad();
            Id(x => x.Cliente).GeneratedBy.Assigned().Column("Cliente");
			Map(x => x.Descripcion).Column("[Descripción]").Length(80);
			Map(x => x.Direccion_completa).Column("[Dirección completa]").Not.Nullable().Length(192);
			Map(x => x.Correo_electronico).Column("[Correo electrónico]").Length(300);
            Map(x => x.Estatus).Column("Estatus").Not.Nullable();
        }
    }
}
