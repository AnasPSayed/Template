using System.Collections.Generic;
using Template.DB.Models;

namespace Template.Entities.ViewModels
{
    public class UserDetailsViewModel
    {
        public string UserName { get; set; }
        public string XID { get; set; }
        public List<SkillSet> SkillSets { get; set; }
    }
}
