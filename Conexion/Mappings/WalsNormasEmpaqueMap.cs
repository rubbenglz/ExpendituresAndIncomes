using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration;

namespace Conexion.Mappings
{
    public class WalsNormasEmpaqueMap : ClassMap<WalsNormasEmpaque>
    {
        public WalsNormasEmpaqueMap()
        {
            Table("WALS_NormasEmpaque");
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            LazyLoad();
            CompositeId().KeyProperty(x => x.ClaveProducto, "ClaveProducto")
                         .KeyProperty(x => x.NormaDeEmpaque, "NormaDeEmpaque")
                         .KeyProperty(x => x.CodigoDeEmpaque, "[CódigoDeEmpaque]");
            Map(x => x.Tipo).Column("Tipo").Not.Nullable();
            Map(x => x.Largo).Column("Largo").Not.Nullable();
            Map(x => x.Alto).Column("Alto").Not.Nullable();
            Map(x => x.Ancho).Column("Ancho").Not.Nullable();
            Map(x => x.Cantidad).Column("Cantidad").Not.Nullable();
            //Map(x => x.CodigoDeEmpaque).Column("[CódigoDeEmpaque]").Not.Nullable();
            Map(x => x.Estatus).Column("Estatus").Not.Nullable();
        }
    }
}
