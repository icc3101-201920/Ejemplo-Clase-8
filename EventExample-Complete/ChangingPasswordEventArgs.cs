using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample_Complete
{
    public class ChangingPasswordEventArgs
    {
        public string NewPass { get; set; }
        public string NewPassConf { get; set; }
    }
}
