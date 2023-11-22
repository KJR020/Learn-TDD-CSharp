using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public static class Calculation
    {
        public static float Ave(List<float> floats)
        {
            return floats.Sum() / floats.Count;
        }

        public static int Ave(List<int> list)
        {
            int values = 0;
            foreach (int val in list)
            {
                values += val;
            }
            return values / list.Count;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
