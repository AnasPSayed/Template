using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.DB.Models
{
    [PetaPoco.TableName("SkillSet")]
    [PetaPoco.PrimaryKey("SkillSetID")]
    public class SkillSet
    {
        public long SkillSetID { get; set; }
        public string SkillSetName { get; set; }
        public string SkillSetType { get; set; }
        public string SkillSetYOE { get; set; }
        public long UserID { get; set; }
    }
}
