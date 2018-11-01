namespace Template.DB.Models
{
    [PetaPoco.TableName("UserData")]
    [PetaPoco.PrimaryKey("Id")]
    public class UserData
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string XId { get; set; }
    }
}
