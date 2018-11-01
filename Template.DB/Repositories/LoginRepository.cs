using System.Collections;
using System.Collections.Generic;
using Template.DB.DataContext;
using Template.DB.Models;
using Template.Entities.ViewModels;

namespace Template.DB.Repositories
{

    public class LoginRepository : TemplateRepositoryBase
    {
        public int RegisterUser(UserData user)
        {
            int userId = 0;

            userId = Insert<UserData>(user);

            return userId;
        }

        public int RegisterSkillSet(SkillSet skillset)
        {
            int userId = 0;

            userId = Insert<SkillSet>(skillset);

            return userId;
        }

        public IEnumerable<UserData> GetUserData(string xid)
        {
            var x = Select<UserData>(string.Format("select * from UserData where XId = {0}",xid));
            return x;
        }

        public IEnumerable<SkillSet> GetSkillSet(string skillset)
        {
            var x = Select<SkillSet>(string.Format("select * from SkillSet where SkillSetName = {'0'}", skillset));
            return x;
        }
    }
}
