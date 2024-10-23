using System.Threading.Channels;

namespace HR_management_app.Models
{
    public class Employee
    {
        public string No{ get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public bool isDelete { get; set; } = false;
        private decimal _salary;
        private string _position;
        private static int employeeCounter = 1000;
        public string Position 
        {
            get
            {
                return _position;
            }
            set
            {
                if (value.Length >= 2) _position = value;
                else throw new Exception("Position must contain min 2 characters ");
            }
        }

        public decimal Salary {
            get
            {
                return _salary;
            }
            set
            {

                if (value > 250) _salary = value;
                else throw new Exception("Salary must be greater than 250");
            }
        }

        public Employee(string fullName, string position, decimal salary, string departmentName)
        {

            FullName = fullName;
            Position = position;
            Salary = salary;
            DepartmentName = departmentName;

            No = departmentName.Substring(0, 2).ToUpper() + employeeCounter;
            employeeCounter++;
        }

    }
}
