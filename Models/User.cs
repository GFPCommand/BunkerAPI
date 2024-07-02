namespace Bunker_API.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
		public bool IsAdmin { get; set; }
		public int RoleID { get; set; }
        public int PersonID { get; set; }
        public int RoomID { get; set; }
    }
}
