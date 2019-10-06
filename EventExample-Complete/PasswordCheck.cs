using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventExample_Complete
{
    public class PasswordCheck
    {
        public bool OnChangingPassword(object source, ChangingPasswordEventArgs e)
        {
            if (e.NewPass.Equals(e.NewPassConf))
            {
                Thread.Sleep(3000);
                Console.WriteLine("Checker: Success, both password match");
                return true;
            }
            else
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Checker: Error, passwords didn't match: {e.NewPass} - {e.NewPassConf}");
                return false;
            }
        }
    }
}
