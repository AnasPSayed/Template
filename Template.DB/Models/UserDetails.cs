namespace Template.DB.Models
{
    [PetaPoco.TableName("UserDetails")]
    [PetaPoco.PrimaryKey("UserID")]
    public class UserDetails
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string XID { get; set; }
    }
}
