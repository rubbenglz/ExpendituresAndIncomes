using Conexion.Entities;
using FluentNHibernate.Mapping;
using System;


namespace Conexion.Mappings
{
    public class DespachadorMap : ClassMap<Despachador>
    {
        public DespachadorMap()
        {
            Table("Despachador");
            LazyLoad();
            Id(x => x.Id).GeneratedBy.Identity().Column("Id");
            Map(x => x.Nombre).Column("Nombre").Not.Nullable().Length(50);
            Map(x => x.Prioridad).Column("Prioridad").Not.Nullable();
            Map(x => x.Estatus).Column("Estatus").Not.Nullable().CustomType<EstatusDespachadorType>();
            HasMany<Coladespachador>(x => x.Detalles).Cascade.All().ReadOnly();
        }
    }
}