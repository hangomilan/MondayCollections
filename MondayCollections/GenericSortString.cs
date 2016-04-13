using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayCollections
{
    public class GenericSortString
    {
        public static List<string> SortString(string[] strings) {
            List<string> result = new List<string>(strings.ToList());
            result.Sort();
            return result;

        }
    }
}
