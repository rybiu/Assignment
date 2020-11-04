using BusinessObjects.BusinessRules;
using System;

namespace BusinessObjects
{
    public class Device : BusinessObject
    {
        public Device()
        {
            // establish business rules

            AddRule(new ValidateId("Id"));

            AddRule(new ValidateRequired("Name"));
            AddRule(new ValidateLength("Name", 1, 50));

            AddRule(new ValidateLength("Description", 0, 300));
            
            AddRule(new ValidateDateType("BoughtDate"));

            AddRule(new ValidateDateType("WarrantyDate"));

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public byte[] Image { get; set; }
        public DateTime? BoughtDate { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public int RoomId { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }

    }
}
