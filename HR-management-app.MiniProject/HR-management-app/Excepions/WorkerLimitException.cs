namespace HR_management_app.Excepions
{
    public class WorkerLimitException:Exception
    {
        public WorkerLimitException(string message):base(message) { }
        public WorkerLimitException()
        {
            
        }

    }
}
