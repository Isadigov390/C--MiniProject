namespace HR_management_app.Excepions
{
    public class Minimum2CharsException:Exception
    {
        public Minimum2CharsException(string message):base(message) 
        {
            
        }
        public Minimum2CharsException()
        {
            
        }
    }
}
