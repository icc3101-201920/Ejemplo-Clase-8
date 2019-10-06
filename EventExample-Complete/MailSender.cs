using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventExample_Complete
{
    public class MailSender
    {
        public void OnLoggedIn(object source, EventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nMail: We have registered a log in at {DateTime.Now}\n");
            Thread.Sleep(2000);
        }

        public void OnChangePasswordRequested(object source, RequestEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nMail:\nDear User:\n\tWe have registered a request to change your password at {e.RequestDateTime}. Please follow the next instructions...\n");
            Thread.Sleep(2000);
        }
    }
}
