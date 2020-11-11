using BusinessObjects.BusinessRules;

namespace BusinessObjects
{
    public class User : BusinessObject
    {

        public User()
        {
            // establish business rules

            AddRule(new ValidateId("Id"));

            AddRule(new ValidateRequired("Username"));
            AddRule(new ValidateLength("Username", 1, 50));

            AddRule(new ValidateRequired("Password"));
            AddRule(new ValidateLength("Password", 1, 50));

        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int RoomId { get; set; }
        public int StatusId { get; set; }

    }
}
