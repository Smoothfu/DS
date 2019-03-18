using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DicBase;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            PII pObj = new PII();
            for(int i=0;i<10;i++)
            {
                pObj.Add(i, "Fred" + i);
            }

            Console.WriteLine($"There are  {pObj.Count} names");
            Console.WriteLine($"5's name is {pObj.Item(5)}");
            pObj.Clear();
            Console.WriteLine($"There are {pObj.Count} names");
            Console.ReadLine();
        }
    }

   
}
