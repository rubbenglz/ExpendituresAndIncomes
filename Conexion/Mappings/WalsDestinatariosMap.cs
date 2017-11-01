using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration; 

namespace Conexion.Mappings {
    
    
    public class WalsDestinatariosMap : ClassMap<WalsDestinatarios> {
        
        public WalsDestinatariosMap() {
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
			Table("WALS_Destinatarios");
			LazyLoad();
            CompositeId().KeyProperty(x => x.Destinatario, "Destinatario")
                         .KeyProperty(x => x.Cliente, "Cliente");
			Map(x => x.Descripcion).Column("[Descripción]").Length(80);
            Map(x => x.DescripcionComercial).Column("DescripcionComercial");	
            Map(x => x.Ruta).Column("Ruta").Length(3);
            Map(x => x.RutaDescripcion).Column("[Descripción ruta]").Length(80);
			Map(x => x.Calle_y_numero).Column("[Calle y número]").Not.Nullable().Length(40);
			Map(x => x.Colonia).Column("Colonia").Not.Nullable().Length(40);
			Map(x => x.Poblacion).Column("[Población]").Not.Nullable().Length(25);
			Map(x => x.Ciudad).Column("Ciudad").Not.Nullable().Length(25);
			Map(x => x.Estado).Column("Estado").Not.Nullable().Length(30);
			Map(x => x.Pais).Column("[Pais]").Not.Nullable().Length(30);
			Map(x => x.CP).Column("CP").Not.Nullable().Length(12);
            Map(x => x.Estatus).Column("Estatus").Not.Nullable();
        }
    }
}
