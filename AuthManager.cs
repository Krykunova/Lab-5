using System;

namespace ConsoleApp1
{
    public class AuthManager
    {
        private static AuthManager instance;
        public string CurrentUserEmail { get; private set; }

        private AuthManager() { }

        public static AuthManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new AuthManager();
                return instance;
            }
        }

        public void Login(string email)
        {
            CurrentUserEmail = email;
            Console.WriteLine($"Користувач {email} увійшов.");
        }
    }
}
