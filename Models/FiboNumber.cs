using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace View_Component.Models
{
    public class FiboNumber
    {
        public static List<int> func()
        {
            List<int> numbers = new List<int>();
            int st = 0, en = 1;
            numbers.Add(st);numbers.Add(en);
            for(int i = 0; i < 20; i++)
            {
                int temp = st + en;
                numbers.Add((temp));
                st = en; en = temp;
            }
            return numbers;
        }
       
        
    }
}
