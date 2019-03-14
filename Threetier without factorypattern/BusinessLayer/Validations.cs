namespace BusinessLayer
{
    public class Validations
    {
        /// <summary>
        /// validate of email address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ValidateEmail(string email)
        {
            if (email.Contains("@") && email.Contains(".com"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validation of Password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            int condcount = 0;
            //for capital letters condition
            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    condcount++;
                    break;
                }
            }
            //for digits checking condition
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    condcount++;
                    break;
                }
            }
            //for length of password checking condition
            if (password.Length <= 15 && password.Length >= 8)
            {
                condcount++;
            }
            if (condcount == 3)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// validate name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ValidateName(string name)
        {
            if (name.Length > 0)
            {
                return true;
            }
            return false;
        }
    }
}
