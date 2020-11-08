using BusinessObjects.BusinessRules;

namespace BusinessObjects
{
    public class Room : BusinessObject
    {
        public Room()
        {
            // establish business rules

            AddRule(new ValidateId("Id"));

            AddRule(new ValidateRequired("Name"));
            AddRule(new ValidateLength("Name", 1, 50));

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberUser { get; set; }
        public int NumberDevice { get; set; }
        public int StatusId { get; set; }

    }
}
