using Conexion.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Mappings
{
    public class PedidoMap : ClassMap<Pedido>
    {
        public PedidoMap()
        {
            CompositeId().KeyProperty(x => x.Folio, "Folio")
                         .KeyProperty(x => x.TipOrden, "TipOrden")
                         .KeyProperty(x => x.Almacen, "Almacen");
            Map(x => x.Acuse).Column("Acuse").Not.Nullable().Length(50);
            Map(x => x.GlClass).Column("GlClass").Not.Nullable();
            Map(x => x.URAT).Column("URAT").Not.Nullable();
          
        }
    }
}
