using Conexion.Entities;
using Conexion.Ninject;
using Conexion.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Conexion.Classes;

namespace Conexion.Clases
{
    public class Principal
    {
        public Principal()
        {
            //AuxClassNH.HelperDATA = (AuxClassNH.HelperDATA ?? new NHibernateHelper(ConfigurationManager.ConnectionStrings["ConexionPRINCIPAL"].ConnectionString));
            //using (UnitOfWork uow = new UnitOfWork(AuxClassNH.dbContextDATA))
            //{
            //}
        }



        public  List<Registros> GetDatos(DateTime fechaIni, DateTime fechaFin)
        {
            List<Registros> datos = new List<Registros>();
            try
            {
                using (UnitOfWork uow = new UnitOfWork(AuxClassNH.HelperDATA.SessionFactory))
                {
                    Repository<Entradassalidas> repoData = new Repository<Entradassalidas>(uow.Session);
                    datos = (from item in repoData.All()
                                .Where(x => x.ES_Fecha >= fechaIni && x.ES_Fecha <= fechaFin)
                             select new Registros()
                             {
                                 Tipo = item.ES_Tipo,
                                 Cantidad = item.ES_Cantidad,
                                 Fecha = item.ES_Fecha,
                                 Descripcion = item.ES_Descripcion
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
                    ES_Fecha = objRegistro.Fecha,
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
    }
}
