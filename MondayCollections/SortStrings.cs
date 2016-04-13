using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayCollections
{
    public class SortStrings
    {
        public static ArrayList StringSort(string[] strings) {
            ArrayList stringList = new ArrayList(strings.ToList());
            stringList.Sort();
            return stringList;
        }
    }
}
