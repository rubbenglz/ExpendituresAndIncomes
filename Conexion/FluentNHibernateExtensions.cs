using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Mapping;
using FluentNHibernate.Mapping.Providers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Conexion
{
	public static class FluentNHibernateExtensions
	{
		public static FluentMappingsContainer AddFromNamespaceOf<T>(this FluentMappingsContainer fmc)
		{
			string ns = typeof(T).Namespace;
			IEnumerable<Type> enumerable = from t in typeof(T).Assembly.GetExportedTypes()
			where t.Namespace == ns
			select t into x
			where FluentNHibernateExtensions.IsMappingOf<IMappingProvider>(x) || FluentNHibernateExtensions.IsMappingOf<IIndeterminateSubclassMappingProvider>(x) || FluentNHibernateExtensions.IsMappingOf<IExternalComponentMappingProvider>(x) || FluentNHibernateExtensions.IsMappingOf<IFilterDefinition>(x)
			select x;
			foreach (Type current in enumerable)
			{
				fmc.Add(current);
			}
			return fmc;
		}

		private static bool IsMappingOf<T>(Type type)
		{
			return !type.IsGenericType && typeof(T).IsAssignableFrom(type);
		}
	}
}
