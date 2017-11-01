using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration; 

namespace Conexion.Mappings {
    
    
    public class WalsRemisionfacturaMap : ClassMap<WalsRemisionFactura> {
        
        public WalsRemisionfacturaMap() {
            Table("WALS_RemisionFactura");
            LazyLoad();
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            CompositeId().KeyProperty(x => x.Compania, "Compania")
                         .KeyProperty(x => x.IdPedido, "IdPedido")
                         .KeyProperty(x => x.TipoOrden, "TipoOrden");
            Map(x => x.Dias).Column("Dias");
            Map(x => x.Plazo).Column("Plazo");
            Map(x => x.FormaPago).Column("FormaPago");
            Map(x => x.OrdenCompra).Column("OrdenCompra");
            Map(x => x.URLPDF).Column("FileXML");
        }
    }
}
