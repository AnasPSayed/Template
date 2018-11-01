using Template.DB.Models;
using Template.Entities.ViewModels;

namespace Template.DB.Interfaces
{
    public interface ILoginRepositoryManager
    {
        int RegisterUser(UserDetailsViewModel details);
    }
}
