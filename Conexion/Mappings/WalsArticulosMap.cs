using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using Conexion.Entities;
using System.Configuration;

namespace Conexion.Mappings
{


    public class WalsArticulosMap : ClassMap<WalsArticulos>
    {

        public WalsArticulosMap()
        {
            Table("WALS_Articulos");
            Schema(ConfigurationManager.AppSettings["SchemaDTA"]);
            LazyLoad();
            Id(x => x.Producto).GeneratedBy.Assigned().Column("Producto");
            Map(x => x.Descripcion).Column("[Descripción]").Length(60);
            Map(x => x.Descripcion_corta).Column("[Descripción corta]").Length(30);
            Map(x => x.Familia).Column("Familia").Length(30);
            Map(x => x.Sub_familia).Column("[Sub familia]").Not.Nullable().Length(1);
            Map(x => x.Linea).Column("Línea").Length(30);
            Map(x => x.Marca).Column("Marca").Length(30);
            Map(x => x.Division).Column("[División]").Length(30);
            Map(x => x.SubSubGrupo).Column("SubSubGrupo").Not.Nullable().Length(1);
            Map(x => x.Unidad_de_medida).Column("[Unidad de medida]").Length(30);
            Map(x => x.Lote).Column("Lote").Length(1);
            Map(x => x.Caducidad).Column("Caducidad").Length(1);
            Map(x => x.Peso).Column("Peso").Precision(38);
            Map(x => x.Largo).Column("Largo").Precision(38);
            Map(x => x.Ancho).Column("Ancho").Precision(38);
            Map(x => x.Alto).Column("Alto").Precision(38);
            Map(x => x.Factor).Column("Factor").Length(6);
            Map(x => x.Maximo).Column("[Máximo]").Precision(38);
            Map(x => x.Minimo).Column("[Mínimo]").Precision(38);
            Map(x => x.Imagen).Column("Imagen").Not.Nullable().Precision(10);
            Map(x => x.Codigo_de_barras).Column("[Código de barras]").Not.Nullable().Length(25);
            Map(x => x.Reempaque).Column("Reempaque").Length(1);
            Map(x => x.Restringido).Column("Restringido").Length(1);
            Map(x => x.Canastilla_caja_mixto).Column("[Canastilla, caja, mixto]").Length(3);
            Map(x => x.Entrega_Detalle).Column("[Entrega Detalle]").Length(1);
            Map(x => x.Alerta_de_caducidad).Column("[Alerta de caducidad]").Length(1);
            Map(x => x.Alerta_de_componentes).Column("[Alerta de componentes]").Length(1);
            Map(x => x.Alerta_restriccion_para_devolucion).Column("[Alerta restricción para devolución]").Length(1);
            Map(x => x.Sustituto_Producto).Column("[Sustituto Producto]").Not.Nullable().Length(1);
            Map(x => x.ManejaDecimales).Column("[Maneja decimales]");
            Map(x => x.SustitutoProducto).Column("[Sustituto Producto]").Not.Nullable();
            Map(x => x.Estatus).Column("[Estatus]");
            Map(x => x.Ruta_Imagen).Column("[Ruta Imagen]");
        }
    }
}
