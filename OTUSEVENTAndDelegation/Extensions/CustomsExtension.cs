using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OTUSEVENTAndDelegation.Extensions
{
    internal static class CustomsExtension
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber)
            where T : class
        {
            if (collection == null || !collection.Any()) { throw new ArgumentNullException(nameof(collection)); }
            T max = collection.First();

            foreach (var item in collection)
            {
                var convertValue = convertToNumber(item);
                if (convertToNumber(max) < convertValue)
                {
                    max = item;
                }
            }

            return max;
        }



    }
}
