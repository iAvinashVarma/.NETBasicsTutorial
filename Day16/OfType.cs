using System;
using System.Collections;
using System.Linq;

namespace Day16
{
    public class OfType
    {
        private static void Main(string[] args)
        {
            #region Of Type (Lamda Syntax)

            ArrayList arrayList = new ArrayList { "India", "Russia", 12, 7.0, true, "Indonesia" };

            var filterOfTypeString = arrayList.OfType<string>();

            foreach (var item in filterOfTypeString)
            {
                Console.WriteLine(item);
            }

            var filterOfTypeStringValueN = arrayList.OfType<string>().Where(nd => nd.Contains("nd"));

            foreach (var item in filterOfTypeStringValueN)
            {
                Console.WriteLine(item);
            }

            #endregion Of Type (Lamda Syntax)
        }
    }
}