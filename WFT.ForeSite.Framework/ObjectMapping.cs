using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFT.ForSite.Framework
{
    static class ObjectMapping
    {
        public static void MapObjects(object source, object destination)
        {
            Type sourcetype = source.GetType();
            Type destinationtype = destination.GetType();

            var sourceProperties = sourcetype.GetProperties();
            var destionationProperties = destinationtype.GetProperties();

            var commonproperties = from sp in sourceProperties
                                   join dp in destionationProperties on new { sp.Name, sp.PropertyType } equals
                                       new { dp.Name, dp.PropertyType }
                                   select new { sp, dp };

            foreach (var match in commonproperties)
            {
                match.dp.SetValue(destination, match.sp.GetValue(source, null), null);
            }
        }
    }
}
