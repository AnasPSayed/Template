using Template.Entities.ViewModels;

namespace Template.Service.Interfaces
{
    public interface IUserDetailsService
    {
        int RegisterUser(UserDetailsViewModel viewModel);
    }
}
