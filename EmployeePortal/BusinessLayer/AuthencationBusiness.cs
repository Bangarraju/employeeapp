using RepositoryLayer;

namespace BusinessLayer
{
    public class AuthencationBusiness
    {
        AuthencationRepo _authRepo;

        public AuthencationBusiness()
        {
            _authRepo = new AuthencationRepo();
        }

        public bool ValidateLogin(string emailID, string password)
        {
            return _authRepo.ValidateLogin(emailID, password);
        }

        public bool Register(string emailID, string password, string firstName, string lastName, bool isStudent)
        {
            return _authRepo.Register(emailID, password, firstName, lastName, isStudent);
        }
    }
}