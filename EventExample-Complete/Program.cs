using System;

namespace EventExample_Complete
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            MailSender mailSender = new MailSender();
            SMSSender smsSender = new SMSSender();
            PasswordCheck passwordCheck = new PasswordCheck();
            //Suscribir los que escuchan los eventos
            //1- Suscribir OnLoggedIn de MailSender para que escuche el evento LoggedIn enviado por User
            user.LoggedIn += mailSender.OnLoggedIn;
            //2- Suscribir OnChangePasswordRequested de MailSender para que escuche el evento ChangePasswordRequested enviado por User
            user.ChangePasswordRequested += mailSender.OnChangePasswordRequested;
            //3- Suscribir OnChangePasswordRequested de SMSSender para que escuche el evento ChangePasswordRequested enviado por User
            user.ChangePasswordRequested += smsSender.OnChangePasswordRequested;
            //4- Suscribir OnchangingPassword de PasswordCheck para que escuche el evento ChangingPassword enviado por User
            user.ChangingPassword += passwordCheck.OnChangingPassword;

            user.LogIn();
            user.RequestChangePassword();

            if(user.ChangePassword("a", "b"))
            {
                Console.WriteLine("Password changed");
            }
            else
            {
                Console.WriteLine("Password didn't change");
            }
                
        }
    }
}
