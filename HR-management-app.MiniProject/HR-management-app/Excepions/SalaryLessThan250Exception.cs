namespace HR_management_app.Excepions
{
    public class SalaryLessThan250Exception:Exception
    {
        public SalaryLessThan250Exception(string message):base(message) 
        {
            
        }
        public SalaryLessThan250Exception()
        {
            
        }
    }
}
