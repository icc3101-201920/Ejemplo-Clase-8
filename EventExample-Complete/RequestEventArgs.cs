using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample_Complete
{
    public class RequestEventArgs:EventArgs
    {
        public DateTime RequestDateTime { get; set; }
    }
}
