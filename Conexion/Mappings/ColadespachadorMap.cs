using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Conexion.Entities;

namespace Conexion.Mappings
{


    public class ColadespachadorMap : ClassMap<Coladespachador>
    {

        public ColadespachadorMap()
        {
            Table("ColaDespachador");
            base.DynamicUpdate();
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.DespachadorId).Column("DespachadorId").Not.Nullable().Precision(10);
            Map(x => x.Argumentos).Column("Argumentos").Not.Nullable();
            Map(x => x.Estatus).Column("Estatus").Not.Nullable().CustomType<EstatusDespachadorColaType>();
            Map(x => x.FechaInicio).Column("FechaInicio").Not.Nullable();
            Map(x => x.FechaFin).Column("FechaFin");
            Map(x => x.UsuarioID).Column("UsuarioID").Not.Nullable();
            References<Despachador>(x => x.Despachador).Column("DespachadorId").Cascade.All().ReadOnly();
        }
    }
}
