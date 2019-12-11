using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFT.ForeSite.Utility.BusinessManager;

namespace WFT.ForeSite.Utility
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCount();
            Console.ReadLine();
        }

       static void GetCount()
        {
            Test t = new Test();
            t.GetCount(9);
            Console.WriteLine(t.GetCounts(9));
        }
    }
}
