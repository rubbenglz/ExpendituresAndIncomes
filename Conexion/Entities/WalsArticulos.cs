using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conexion.Entities
{

    public class WalsArticulos
    {
        public virtual string Producto { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string Descripcion_corta { get; set; }
        public virtual string Familia { get; set; }
        public virtual string Sub_familia { get; set; }
        public virtual string Linea { get; set; }
        public virtual string Marca { get; set; }
        public virtual string Division { get; set; }
        public virtual string SubSubGrupo { get; set; }
        public virtual string Unidad_de_medida { get; set; }
        public virtual string Lote { get; set; }
        public virtual string Caducidad { get; set; }
        public virtual float Peso { get; set; }
        public virtual float Largo { get; set; }
        public virtual float Ancho { get; set; }
        public virtual float Alto { get; set; }
        public virtual float Factor { get; set; }
        public virtual float Maximo { get; set; }
        public virtual float Minimo { get; set; }
        public virtual string Imagen { get; set; }
        public virtual string Codigo_de_barras { get; set; }
        public virtual string Reempaque { get; set; }
        public virtual string Restringido { get; set; }
        public virtual string Canastilla_caja_mixto { get; set; }
        public virtual string Entrega_Detalle { get; set; }
        public virtual string Alerta_de_caducidad { get; set; }
        public virtual string Alerta_de_componentes { get; set; }
        public virtual string Alerta_restriccion_para_devolucion { get; set; }
        public virtual string Sustituto_Producto { get; set; }
        public virtual string ManejaDecimales { get; set; }
        public virtual string SustitutoProducto { get; set; }
        public virtual string Ruta_Imagen { get; set; }
        public virtual string Estatus { get; set; }

    }

}
