namespace HR_management_app.Models
{
    public class Department
    {

        private string _name;
        private int _workerLimit;
        private decimal _salaryLimit;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >= 2) _name = value;
                else throw new Exception("Name must contain min 2 characters ");
            }
        }
        public int WorkerLimit {
            get
            {
                return _workerLimit;
            }
            set
            {
                if (value >= 1) _workerLimit = value;
                else throw new Exception("Worker limit can be min 1 ");
            }
        }
        public decimal SalaryLimit {
            get
            {
                return _salaryLimit;
            }
            set
            {
                if (value >= 250) _salaryLimit = value;
                else throw new Exception("Salary limit can be min 250");
            }
        }
        public List<Employee> Employees { get; set; }
        public decimal CalcSalaryAverage()
        {
            if (Employees.Count == 0)
                return 0;
            return Math.Round(Employees.Average(m => m.Salary),2) ;
        }
        public Department(string name, int workerLimit, decimal salaryLimit)
        {
            Name = name;
            WorkerLimit = workerLimit;
            SalaryLimit = salaryLimit;
            Employees = new List<Employee>();

        }
    }
}
