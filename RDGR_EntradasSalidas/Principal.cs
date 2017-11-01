using Conexion;
using Conexion.Entities;
using Conexion.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RDGR_EntradasSalidas
{
    public class Principal
    {
        public Principal()
        {
            
            
        }
        public  List<Registros> GetDatos(DateTime fechaIni, DateTime fechaFin)
        {
            List<Registros> datos = new List<Registros>();
            try
            {
                using (UnitOfWork uow = new UnitOfWork(AuxClassNH.dbContextDATA))
                {
                    Repository<Entradassalidas> repoDatos = new Repository<Entradassalidas>(uow.Session);
                    datos = (from item in repoDatos.All()
                             where item.ES_Fecha >= fechaIni && item.ES_Fecha <= fechaFin
                             select new Registros()
                             {
                                 Id = item.ES_Index,
                                 Cantidad = item.ES_Cantidad,
                                 Descripcion = item.ES_Descripcion.Trim(),
                                 Fecha = item.ES_Fecha,
                                 Tipo = item.ES_Tipo.Trim()

                             }).ToList();

                };
                return datos;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public  string Save(Registros objRegistro)
        {
            string respuesta = "";
            try
            {
                var objGuardar = new Entradassalidas()
                {
                    ES_Cantidad = objRegistro.Cantidad,
                    ES_Descripcion = objRegistro.Descripcion,
                    ES_Tipo = objRegistro.Tipo,
                    ES_Equipo = Environment.MachineName,
                    ES_Fecha = Convert.ToDateTime(objRegistro.Fecha.Date.ToShortDateString()),
                    ES_FechaAlta = DateTime.Now,
                    ES_FechaMod = DateTime.Now,
                    ES_UsuarioMod = "RUBEN"
                };
                try
                {   
                    using (UnitOfWork uow = new UnitOfWork(AuxClassNH.dbContextDATA))
                    {
                        uow.Session.Save("Entradassalidas", objGuardar);                        
                        uow.Commit();
                    };
                }
                catch (Exception)
                {
                    throw;
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public enum TipoVentana
        {
            Agregar,
            Modificar
        }
    }
}
