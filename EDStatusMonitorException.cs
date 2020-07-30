using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDStatus_Feeder
{
    class EDStatusMonitorException : Exception
    {
        public EDStatusMonitorException(string message) : base(message) { }
    }
}
