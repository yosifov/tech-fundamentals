namespace TechFundamentals.Methods
{
    using System;

    class PasswordValidator
    {
        public static void Exercise()
        {
            string password = Console.ReadLine();
            PasswordValidate(password);
        }

        private static void PasswordValidate(string password)
        {
            if (CheckPasswordLength(password) && 
                CheckPasswordSymbols(password) &&
                CheckPasswordContainsTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (!CheckPasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!CheckPasswordSymbols(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!CheckPasswordContainsTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool CheckPasswordContainsTwoDigits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool CheckPasswordSymbols(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckPasswordLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
