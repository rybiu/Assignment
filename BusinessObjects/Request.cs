using BusinessObjects.BusinessRules;
using System;

namespace BusinessObjects
{
    public class Request : BusinessObject
    {
        public Request()
        {
            // establish business rules

            AddRule(new ValidateId("Id"));

            AddRule(new ValidateLength("RequestDescription", 0, 300));

            AddRule(new ValidateLength("RepairDescription", 0, 300));

        }
        public int Id { get; set; }
        public string RequestDescription { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string RepairDescription { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public int WorkerId { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }

    }
}
