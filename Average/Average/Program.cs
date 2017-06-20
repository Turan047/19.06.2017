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
            List<int> reqem = new List<int>();
            reqem.Add(2);
            reqem.Add(3);
            reqem.Add(7);
            reqem.Add(4);
            reqem.Add(9);
            int i = reqem[0];
            Int32 uzunluq = reqem.Count;
            int cem2 = 0;
            for (i=0;i<uzunluq;i++)
            { 
                int cem=reqem[i] + reqem[i+1];
                
                cem2 = cem2+cem;
                i++;
            }
            Console.WriteLine(cem2 / uzunluq);
        }
    }
}
