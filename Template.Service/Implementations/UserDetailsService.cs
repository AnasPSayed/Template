using Template.Entities.ViewModels;
using Template.Service.Interfaces;
using Template.DB.Interfaces;
using Template.DB.Implementations;
using Template.DB.Models;

namespace Template.Service.Implementations
{
    public class UserDetailsService : IUserDetailsService
    {
        private ILoginRepositoryManager repoManager;
        #region Constructor
        public UserDetailsService()
        {
            repoManager = new LoginRepositoryManager();
        }
        #endregion
        #region Public
        public void RegisterUser(UserDetailsViewModel viewModel) => SetUserValues(viewModel);
        #endregion

        #region Private
        private void SetUserValues(UserDetailsViewModel viewModel)
        {
            UserData uDetails = new UserData();
            uDetails.UserName = viewModel.UserName;
            uDetails.XId = viewModel.XID;
            var temp1 = repoManager.GetUserData(viewModel.XID);
            if (repoManager.GetUserData(viewModel.XID) != null)
            {
                int UserId = repoManager.RegisterUser(uDetails);
                foreach (SkillSet x in viewModel.SkillSets)
                {
                    if (repoManager.GetSkillSet(x.SkillSetName) != null)
                    {
                        SkillSet temp = new SkillSet();
                        temp.SkillSetName = x.SkillSetName;
                        temp.SkillSetType = x.SkillSetType;
                        temp.SkillSetYOE = x.SkillSetYOE;
                        temp.UserId = UserId;
                        int SkillId = repoManager.RegisterSkillSet(temp);
                    }
                }
            }
        }
        #endregion
    }
}
