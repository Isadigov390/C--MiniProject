namespace HR_management_app.Models
{
    public class Department
    {
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public decimal SalaryLimit { get; set; }
        List<Employee> Employees { get; set; }
        public decimal CalcSalaryAverage()
        {
            return 0;
        }
    }
}
