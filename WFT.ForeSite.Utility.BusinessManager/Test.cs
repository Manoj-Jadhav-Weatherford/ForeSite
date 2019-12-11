using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFT.ForeSite.Framework;

namespace WFT.ForeSite.Utility.BusinessManager
{

    public class Test
    {
        private ExceptionHandling exceptionHandling = new ExceptionHandling();

        public void GetCount(int t)
        {
           exceptionHandling.Process((M) => GetNumricCout(t),t);
        }

        public int GetCounts(int y)
        {
            return exceptionHandling.ProcessReturn((M) => GetNumricCout(y), y);
        }
        public int GetNumricCout(int t)
        {
            return 9 + t;
        }
    }
}
