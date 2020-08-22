using System;

namespace EDStatusFeeder
{
    class EDStatusMonitorException : Exception
    {
        public EDStatusMonitorException(string message) : base(message) { }
    }
}
