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
        public int RegisterUser(UserDetailsViewModel viewModel) => SetUserValues(viewModel);
        #endregion

        #region Private
        private int SetUserValues(UserDetailsViewModel viewModel)
        {
            //UserDetails uDetails = new UserDetails();
            //uDetails.UserID = viewModel.UserID;
            //uDetails.UserName = viewModel.UserName;
            //uDetails.XID = viewModel.XID;

            return repoManager.RegisterUser(viewModel);
        }
        #endregion
    }
}
