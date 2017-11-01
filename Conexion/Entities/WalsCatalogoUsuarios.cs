using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{
    public class WalsCatalogoUsuarios
    {
        public virtual string UsuarioID { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Contrasea { get; set; }
        public virtual float? PerfilOrdenador { get; set; }
        public virtual float? PerfilTerminal { get; set; }
        public virtual float? PerfilRestriccionDePosiciones { get; set; }
        public virtual byte EsSupervisor { get; set; }
        public virtual byte Activo { get; set; }
    }
}
