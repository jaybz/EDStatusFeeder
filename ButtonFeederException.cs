using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDStatus_Feeder
{
    class ButtonFeederException : Exception
    {
        public ButtonFeederException(string message) : base(message) { }
    }
}
