using Conexion.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Mappings
{
    public class WalsCatalounidatransMap : ClassMap<WalsCatalounidatrans>
    {
        public WalsCatalounidatransMap()
        {
            Table("WALS_CataloUnidaTrans");
            LazyLoad();
            Id(x => x.UKID).GeneratedBy.Assigned().Column("ID");
            Map(x => x.Placas).Column("Placas");
            Map(x => x.Numeroeconomico).Column("NumeroEconomico");
            Map(x => x.Tipodeunidad).Column("TipoDeUnidad");
            Map(x => x.Volumenmaximo).Column("VolumenMaximo");
            Map(x => x.Volumencanastilla).Column("VolumenCanastilla");
            Map(x => x.Pesomaximo).Column("PesoMaximo");
            Map(x => x.Pesocanastilla).Column("PesoCanastilla");
            Map(x => x.Unidadoremolque).Column("UnidadORemolque");
            Map(x => x.Estatus).Column("Estatus");
        }
    }
}
