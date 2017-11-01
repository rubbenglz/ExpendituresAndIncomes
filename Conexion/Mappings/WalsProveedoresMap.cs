using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration;  

namespace Conexion.Mappings {
    
    
    public class WalsProveedoresMap : ClassMap<WalsProveedores> {
        
        public WalsProveedoresMap() {
			Table("WALS_Proveedores");
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
			LazyLoad();
            Id(x => x.Clave_del_proveedor).GeneratedBy.Assigned().Column("[Clave del proveedor]");
			Map(x => x.Nombre).Column("Nombre").Length(40);
			Map(x => x.Retiene_acomodo).Column("[Retiene acomodo]").Not.Nullable().Length(1);
            Map(x => x.Foto_Obligada).Column("[Foto obligada]").Not.Nullable().Length(1);            
            Map(x => x.Estatus).Column("Estatus");
        }
    }
}
