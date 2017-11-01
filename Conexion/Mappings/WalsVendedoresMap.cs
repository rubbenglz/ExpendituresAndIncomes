using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration;

namespace Conexion.Mappings
{


    public class WalsVendedoresMap : ClassMap<WalsVendedores>
    {

        public WalsVendedoresMap()
        {
            Table("WALS_Vendedores");
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            LazyLoad();
            Id(x => x.Vendedor).GeneratedBy.Assigned().Column("Vendedor");
            Map(x => x.Descripcion).Column("Descripción").Length(30);
            Map(x => x.Estatus).Column("Estatus");
        }
    }
}
