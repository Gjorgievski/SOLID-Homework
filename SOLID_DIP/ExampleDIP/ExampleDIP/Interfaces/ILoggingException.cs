using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDIP.Interfaces
{
    public interface ILoggingException
    {
        
        void LogExceptionOccurs(string exceptionInfo);
        
    }
}
