using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DB.Interfaces;
using Template.DB.Models;

namespace Template.DB.Repositories
{
    public class LoginRepositoryManager : ILoginRepositoryManager
    {
        public LoginRepository loginRepo;

        public LoginRepositoryManager()
        {
            loginRepo = new LoginRepository();
        }
        public int RegisterUser(UserDetails details) => RegisterUserDetails(details);

        private int RegisterUserDetails(UserDetails details)
        {
            return loginRepo.RegisterUser(details);
        }
    }
}
