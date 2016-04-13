using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayCollections
{
    public class ReverseSequence
    {
        public static int[] Reverse(int[] numbers) {
            int[] resultArray = new int[numbers.Length];
            Stack<int> stack = new Stack<int>();
            foreach (var number in numbers) {
                stack.Push(number);
            }
            int i = 0;
            while (stack.Count > 0) {
                resultArray[i] = stack.Pop();
                i++;
            }
            return resultArray;
        }
    }
}
