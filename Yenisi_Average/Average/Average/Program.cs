using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
         static void Main(string[] args)
        {
            /*List<int> reqem = new List<int>();
            reqem.Add(2);
            reqem.Add(3);
            reqem.Add(7);
            reqem.Add(4);
            reqem.Add(9);
            int i = reqem[0];
            */
            Console.WriteLine("Enter you number: ");
            int reqem = Convert.ToInt32(Console.ReadLine());

            int cem = 0;
            int j = 0;
            while (reqem!=0)
            {
                int i = reqem % 10;              
                cem = i + cem;
                reqem = reqem / 10;
                j++;
            }
            Console.WriteLine(cem/j);
        }
    }
}
