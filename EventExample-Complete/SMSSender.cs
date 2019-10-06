using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventExample_Complete
{
    public class SMSSender
    {

        public void OnChangePasswordRequested(object source, RequestEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nSMS:\nDear User:\n\tWe have registered a request to change your password at {e.RequestDateTime} Please access to registered mail for instructions...\n");
            Thread.Sleep(2000);
        }
    }
}
