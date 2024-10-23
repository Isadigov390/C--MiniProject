namespace HR_management_app.Excepions
{
    public class DepartmentNotFoundException:Exception
    {
        public DepartmentNotFoundException(string message):base(message) 
        {
            
        }
        public DepartmentNotFoundException()
        {
            
        }
    }
}
