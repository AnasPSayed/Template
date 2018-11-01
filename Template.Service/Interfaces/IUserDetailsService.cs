using Template.Entities.ViewModels;

namespace Template.Service.Interfaces
{
    public interface IUserDetailsService
    {
        void RegisterUser(UserDetailsViewModel viewModel);
    }
}
