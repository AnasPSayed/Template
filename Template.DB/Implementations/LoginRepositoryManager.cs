using Template.DB.Interfaces;
using Template.DB.Models;
using Template.DB.Repositories;
using Template.Entities.ViewModels;

namespace Template.DB.Implementations
{
    public class LoginRepositoryManager : ILoginRepositoryManager
    {
        private LoginRepository loginRepo;

        public LoginRepositoryManager()
        {
            loginRepo = new LoginRepository();
        }
        public int RegisterUser(UserDetailsViewModel details)
        {
            return loginRepo.RegisterUser(details);
        }
    }
}
