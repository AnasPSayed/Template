using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.DB.Models;

namespace Template.DB.Interfaces
{
    interface ILoginRepositoryManager
    {
        int RegisterUser(UserDetails details);
    }
}
