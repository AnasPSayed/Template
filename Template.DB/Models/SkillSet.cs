using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.DB.Models
{
    [PetaPoco.TableName("SkillSet")]
    [PetaPoco.PrimaryKey("Id")]
    public class SkillSet
    {
        public long Id { get; set; }
        public string SkillSetName { get; set; }
        public string SkillSetType { get; set; }
        public int SkillSetYOE { get; set; }
        public long UserId { get; set; }
    }
}
