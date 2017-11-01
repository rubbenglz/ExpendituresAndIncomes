using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using Conexion.Entities; 

namespace Conexion.Mappings {
    
    
    public class WalsCargaDevolucionesProveedorMap : ClassMap<WalsCargaDevolucionesProveedor> {
        
        public WalsCargaDevolucionesProveedorMap() {
			Table("WALS_CargaDevolucionesProveedor");
			LazyLoad();
            CompositeId().KeyProperty(x => x.Folio, "Folio")
                         .KeyProperty(x => x.TipOrden, "TipOrden")
                         .KeyProperty(x => x.Almacen, "Almacen");
			Map(x => x.Vendedor).Column("Vendedor").Not.Nullable().Length(1);
			Map(x => x.Destinatario).Column("Destinatario").Precision(53);		
			Map(x => x.Acopio).Column("Acopio").Not.Nullable().Precision(10);
			Map(x => x.FechaCaptura).Column("FechaCaptura");
			Map(x => x.FechaEntrega).Column("FechaEntrega");
			Map(x => x.Detalle).Column("Detalle");
			Map(x => x.Estatus).Column("Estatus").Not.Nullable().Length(1);
			Map(x => x.Observaciones).Column("Observaciones").Not.Nullable().Length(60);
        }
    }
}
