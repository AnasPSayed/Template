using System.Collections.Generic;
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
        public int RegisterUser(UserData details)
        {
            return loginRepo.RegisterUser(details);
        }
        public int RegisterSkillSet(SkillSet details)
        {
            return loginRepo.RegisterSkillSet(details);
        }

        public IEnumerable<UserData> GetUserData(string xid)
        {
            return loginRepo.GetUserData(xid);
        }

        public IEnumerable<SkillSet> GetSkillSet(string skillset)
        {
            return loginRepo.GetSkillSet(skillset);
        }
    }
}
