using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration;

namespace Conexion.Mappings
{


    public class WalsCatalogoAlertasMap : ClassMap<WalsCatalogoAlertas>
    {

        public WalsCatalogoAlertasMap()
        {
            Table("WALS_CatalogoAlertas");
            LazyLoad();
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            Id(x => x.ClaveAlerta).GeneratedBy.Assigned().Column("ClaveAlerta");
            Map(x => x.Mensaje).Column("Mensaje").Length(400);
            Map(x => x.ClasificacionAlerta).Column("ClasificaciónAlerta").Length(10);
            Map(x => x.Imagen).Column("Imagen");
            Map(x => x.Estatus).Column("Estatus");
            Map(x => x.Nombre).Column("Nombre").Length(30);
        }
    }
}
