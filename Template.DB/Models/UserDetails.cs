using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.DB.Models
{
    [PetaPoco.TableName("UserDetails")]
    [PetaPoco.PrimaryKey("UserID")]
    public class UserDetails
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
