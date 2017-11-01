using Conexion.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Conexion.Mappings
{

    public class WalsAvisosentradaMap : ClassMap<WalsAvisosEntrada>
    {

        public WalsAvisosentradaMap()
        {
            Table("WALS_AvisosEntrada");
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            LazyLoad();
            Id(x => x.FolioDeAcuse).GeneratedBy.Assigned().Column("FolioDeAcuse");
            Map(x => x.ClaveDeProveedor).Column("ClaveDeProveedor");
            Map(x => x.Tipo).Column("Tipo").Not.Nullable().Length(2);
            Map(x => x.CartaPorte).Column("CartaPorte").Not.Nullable().Length(50);
            Map(x => x.Almacen).Column("Almacen").Length(12);
            Map(x => x.BuenEstado).Column("BuenEstado").Not.Nullable().Length(1);
            Map(x => x.Detalle).Column("Detalle");
        }
    }

}
