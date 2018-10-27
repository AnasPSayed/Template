using Template.DB.Models;

namespace Template.DB.Interfaces
{
    public interface ILoginRepositoryManager
    {
        int RegisterUser(UserDetails details);
    }
}
