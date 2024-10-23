namespace HR_management_app.Excepions
{
    public class EmployeeNotFoundException:Exception
    {
        public EmployeeNotFoundException(string message):base(message) 
        {
            
        }
        public EmployeeNotFoundException()
        {
            
        }
    }
}
