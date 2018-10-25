using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DB.DataContext;
using Template.DB.Models;

namespace Template.DB.Repositories
{
    
    public class LoginRepository : TemplateRepositoryBase
    {
        public int RegisterUser(UserDetails user)
        {
            int userId = 0;
            userId = Insert<UserDetails>(user);
            return userId;
        }
    }
}
