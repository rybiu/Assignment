using System;

namespace BusinessObjects.BusinessRules
{
    
    // date validation rule. 
    // date value must be in format MM/dd/yyyy
    
    public class ValidateDateType : BusinessRule
    {
        public ValidateDateType(string propertyName)
            : base(propertyName)
        {
            Error = propertyName + " is an invalid date";
        }

        public ValidateDateType(string propertyName, string errorMessage)
            : base(propertyName)
        {
            Error = errorMessage;
        }

        public override bool Validate(BusinessObject businessObject)
        {
            try
            {
                DateTime.Parse(GetPropertyValue(businessObject).ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
