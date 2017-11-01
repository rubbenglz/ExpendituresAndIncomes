using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Conexion.Entities;

namespace Conexion.Mappings
{


    public class WalsConfClienteMap : ClassMap<WalsConfCliente>
    {

        public WalsConfClienteMap()
        {
            Table("WALS_ConfCliente");
            LazyLoad();
            CompositeId().KeyProperty(x => x.Compaia, "Compañia")
                         .KeyProperty(x => x.TipoDocumento, "TipoDocumento")
                         .KeyProperty(x => x.NumeroDocumento, "NumeroDocumento");
            Map(x => x.ECompaia).Column("ECompañia").Not.Nullable();
            Map(x => x.ETipoDocumento).Column("ETipoDocumento").Not.Nullable();
            Map(x => x.ENumeroDocumento).Column("ENumeroDocumento").Not.Nullable();
            Map(x => x.Almacen).Column("Almacen");
            Map(x => x.SNumeroDocumento).Column("NumeroDocumento");
            Map(x => x.Detalle).Column("Detalle");
        }
    }
}
