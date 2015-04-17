using ExampleDIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDIP.Classes
{
    public class CloudLoggingException:ILoggingException
    {
        public void LogExceptionOccurs(string exceptionInfo)
        {
            Console.WriteLine("CLOUD ==============Exception occurs:{0}", exceptionInfo);
        }
    }
}
