using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayCollections
{
    public class NumberSwitcher
    {
        public static string SwitchNumber(string text) {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string result = text;
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);
            dictionary.Add("Three", 3);
            dictionary.Add("Four", 4);
            dictionary.Add("Five", 5);
            dictionary.Add("Six", 6);
            dictionary.Add("Seven", 7);
            dictionary.Add("Eight", 8);
            dictionary.Add("Nine", 9);
            dictionary.Add("Ten", 10);

            foreach (var number in dictionary.Keys) {
                if (result.ToLower().Contains(number.ToLower())) {
                    result = result.Replace(number, dictionary[number].ToString());
                    result = result.Replace(number.ToLower(),dictionary[number].ToString());
                }
            }
            return result;
        }
    }
}
