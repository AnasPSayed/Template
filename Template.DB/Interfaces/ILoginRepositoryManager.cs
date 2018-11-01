using System.Collections.Generic;
using Template.DB.Models;
using Template.Entities.ViewModels;

namespace Template.DB.Interfaces
{
    public interface ILoginRepositoryManager
    {
        int RegisterUser(UserData details);
        int RegisterSkillSet(SkillSet details);
        IEnumerable<UserData> GetUserData(string xid);

        IEnumerable<SkillSet> GetSkillSet(string skillset);
    }
}
