using Conexion.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Mappings
{
    public class WalsCatalogoUsuariosMap : ClassMap<WalsCatalogoUsuarios>
    {

        public WalsCatalogoUsuariosMap()
        {
            Table("vwCatalogoUsuarios");
            LazyLoad();
            Id(x => x.UsuarioID).Column("UsuarioID").Not.Nullable();
            Map(x => x.Nombre).Column("Nombre").Not.Nullable();
            Map(x => x.Contrasea).Column("Contraseña").Not.Nullable();
            Map(x => x.PerfilOrdenador).Column("PerfilOrdenador");
            Map(x => x.PerfilTerminal).Column("PerfilTerminal");
            Map(x => x.PerfilRestriccionDePosiciones).Column("PerfilRestriccionDePosiciones");
            Map(x => x.EsSupervisor).Column("EsSupervisor").Not.Nullable();
            Map(x => x.Activo).Column("Activo").Not.Nullable();
        }

    }
}
