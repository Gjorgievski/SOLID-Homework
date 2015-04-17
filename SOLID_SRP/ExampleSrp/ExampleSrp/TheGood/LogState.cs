using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class LogState
    {
        public void ComputerLogChangeState(string stateChangeInfo)
        {
            Console.WriteLine("MOBILE ============== Car changed state:{0}", stateChangeInfo);
        }
    }
}
