using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class LogException
    {
        
        public void ExceptionOccurs(string exceptionInfo)
        {
            Console.WriteLine("CLOUD ============== Exception occurs:{0}", exceptionInfo);
        }
    }
}
