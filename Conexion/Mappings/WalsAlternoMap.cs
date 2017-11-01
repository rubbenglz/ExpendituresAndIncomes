using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using System.Configuration;
using Conexion.Entities; 

namespace Conexion.Mappings {
    public class WalsAlternoMap : ClassMap<WalsAlterno> {

        public WalsAlternoMap()
        {
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            Table("WALS_Alterno");
            LazyLoad();
            CompositeId().KeyProperty(x => x.Producto, "Producto")
                         .KeyProperty(x => x.Almacen, "[Almacén]")
                         .KeyProperty(x => x.Codigo,"[Código]");
            Map(x => x.EsCodigoProveedor).Column("EsCodigoProveedor").Length(60);
            Map(x => x.Estatus).Column("Estatus");
        }
    }
}
