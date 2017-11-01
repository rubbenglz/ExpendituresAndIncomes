using Conexion.Ninject;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Conexion.Classes
{
    public static class AuxClassNH
    {
        public static NHibernateHelper HelperDATA { get; set; }
        public static ISessionFactory dbContextDATA { get { return AuxClassNH.HelperDATA.SessionFactory; } }
        //public static NHibernateHelper HelperReports { get; set; }
        //public static ISessionFactory dbContextReports { get { return AuxClassNH.HelperReports.SessionFactory; } }
        //public static NHibernateHelper HelperCTRL { get; set; }
        //public static ISessionFactory dbContextCTRL { get { return AuxClassNH.HelperCTRL.SessionFactory; } }
        //public static NHibernateHelper HelperVENTAS { get; set; }
        //public static ISessionFactory dbContextVENTAS { get { return AuxClassNH.HelperVENTAS.SessionFactory; } }
    }
}