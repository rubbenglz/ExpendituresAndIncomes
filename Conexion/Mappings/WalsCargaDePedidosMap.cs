using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration; 

namespace Conexion.Mappings {
    
    
    public class WalsCargaDePedidosMap : ClassMap<WalsCargaDePedidos> {

        public WalsCargaDePedidosMap()
        {
            Table("WALS_CargaDePedidos");
            //Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            LazyLoad();
            CompositeId().KeyProperty(x => x.Folio, "Folio")
                         .KeyProperty(x => x.TipOrden, "TipOrden")
                         .KeyProperty(x => x.Almacen, "Almacen");
            Map(x => x.Vendedor).Column("Vendedor");
            Map(x => x.Destinatario).Column("Destinatario");
            Map(x => x.Acopio).Column("Acopio");
            Map(x => x.FechaCaptura).Column("FechaCaptura");
            Map(x => x.FechaEntrega).Column("FechaEntrega");
            Map(x => x.Detalle).Column("Detalle");
            Map(x => x.Estatus).Column("Estatus").Not.Nullable();
            Map(x => x.Observaciones).Column("Observaciones").Not.Nullable();
        }
    }
}
