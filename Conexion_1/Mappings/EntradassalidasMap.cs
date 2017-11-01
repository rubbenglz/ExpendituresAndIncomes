using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities; 

namespace Conexion.Mappings {
    
    
    public class EntradassalidasMap : ClassMap<Entradassalidas> {
        
        public EntradassalidasMap() {
			Table("EntradasSalidas");
			LazyLoad();
			Id(x => x.ES_Index).GeneratedBy.Identity().Column("ES_Index");
			Map(x => x.ES_Tipo).Column("ES_Tipo").Not.Nullable();
			Map(x => x.ES_Descripcion).Column("ES_Descripcion").Not.Nullable();
			Map(x => x.ES_Cantidad).Column("ES_Cantidad").Not.Nullable();
			Map(x => x.ES_Fecha).Column("ES_Fecha").Not.Nullable();
			Map(x => x.ES_UsuarioMod).Column("ES_UsuarioMod").Not.Nullable();
			Map(x => x.ES_Equipo).Column("ES_Equipo").Not.Nullable();
			Map(x => x.ES_FechaAlta).Column("ES_FechaAlta").Not.Nullable();
			Map(x => x.ES_FechaMod).Column("ES_FechaMod").Not.Nullable();
        }
    }
}
