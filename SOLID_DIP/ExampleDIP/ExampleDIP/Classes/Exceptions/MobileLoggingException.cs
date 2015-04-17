using ExampleDIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDIP.Classes
{
    public class MobileLoggingException:ILoggingException
    {
        public void LogExceptionOccurs(string exceptionInfo)
        {
            Console.WriteLine("Mobile ==============Exception occurs:{0}", exceptionInfo);
        }
    }
}
