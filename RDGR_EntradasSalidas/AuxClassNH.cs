using Conexion.Ninject;
using NHibernate;
using System;

namespace RDGR_EntradasSalidas
{
	public static class AuxClassNH
	{
		public static NHibernateHelper HelperDATAPBA
		{
			get;
			set;
		}

		public static ISessionFactory dbContextDATAPBA
		{
			get
			{
				return AuxClassNH.HelperDATAPBA.SessionFactory;
			}
		}

        public static NHibernateHelper HelperDATA
        {
            get;
            set;
        }

        public static ISessionFactory dbContextDATA
        {
            get
            {
                return AuxClassNH.HelperDATA.SessionFactory;
            }
        }

		public static NHibernateHelper HelperVENTAS
		{
			get;
			set;
		}

		public static ISessionFactory dbContextVENTAS
		{
			get
			{
				return AuxClassNH.HelperVENTAS.SessionFactory;
			}
		}

		public static NHibernateHelper HelperCTRL
		{
			get;
			set;
		}

		public static ISessionFactory dbContextCTRL
		{
			get
			{
				return AuxClassNH.HelperCTRL.SessionFactory;
			}
		}
	}
}
