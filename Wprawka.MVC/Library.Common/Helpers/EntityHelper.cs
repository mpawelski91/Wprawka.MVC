using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common.Helpers
{
    public static class EntityHelper
    {
        public static void CopyProperties<TSource, TDestination>(this TSource source, TDestination destination)
            where TSource : class
            where TDestination : class
        {
            var destinationProperties = destination.GetType().GetProperties();

            foreach (var property in source.GetType().GetProperties())
            {
                if(destinationProperties.Any(x=>x.Name == property.Name))
                {
                    var destinationProperty = destinationProperties.FirstOrDefault(x => x.Name == property.Name);
                    destinationProperty.SetValue(destination, property.GetValue(source));
                }
            }
        }
    }
}
