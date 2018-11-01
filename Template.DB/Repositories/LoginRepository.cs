using Template.DB.DataContext;
using Template.DB.Models;
using Template.Entities.ViewModels;

namespace Template.DB.Repositories
{

    public class LoginRepository : TemplateRepositoryBase
    {
        public int RegisterUser(UserDetailsViewModel user)
        {
            int userId = 0;
            UserDetails uDetails = new UserDetails();
            uDetails.UserID = user.UserID;
            uDetails.UserName = user.UserName;
            uDetails.XID = user.XID;

            userId = Insert<UserDetails>(uDetails);

            return userId;
        }
    }
}
