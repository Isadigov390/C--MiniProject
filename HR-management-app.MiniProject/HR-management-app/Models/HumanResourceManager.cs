using HR_management_app.Interfaces;

namespace HR_management_app.Models
{
    internal class HumanResourceManager : IHumanResourceManager
    {
        public List<Department> Departments { get; set; }

        public void AddDepartment(Department department)
        {

            //if (Departments.Any(d => d.Name.Equals(department.Name, StringComparison.OrdinalIgnoreCase)))
            //{
            //    throw new Exception("A department with the same name already exists.");
            //}

            Departments.Add(department);
        }

        public void AddEmployee(Employee employee, string depName)
        {
            var searchedDep = Departments.Find(n=>n.Name==depName);
            if (searchedDep == null) { throw new Exception(); }
            else searchedDep.Employees.Add(employee);
        }

        public void EditDepartaments(string searchedDepName, string newDepName)
        {
            var searchedDepartment = Departments.Find(n => n.Name.Equals(searchedDepName, StringComparison.OrdinalIgnoreCase));

            if (searchedDepartment == null)
            {
                throw new Exception("Department not found.");
            }
                
            searchedDepartment.Name = newDepName;
        }

        public void EditEmploye(string no, decimal newSalary, string newPossition)
        {
            foreach (var department in Departments)
            {
                var employee = department.Employees.Find(n=>n.No==no);
                if (employee is not null)
                {
                    employee.Salary = newSalary;
                    employee.Position = newPossition;
                    return;
                }
            }
            throw new Exception("Not Found");
        }

        public List<Department> GetDepartments()
        {
            var departments = Departments.FindAll(n=>n.isDelete=false);
            return Departments;
        }

        public void RemoveEmployee(string employeeNo, string depName)
        {
            var department = Departments.Find(n => n.Name == depName);
            if (department == null) throw new Exception("Department not found.");

            else
            {
                var employee = department.Employees.Find(n => n.No == employeeNo);
                if (employee == null) throw new Exception("Employee not found.");
                else employee.isDelete = true;

            }
        }


        public List<Employee> Search(string search)
        {
            var res = new List<Employee>();
            foreach (var department in Departments)
            {
                var employees=department.Employees.FindAll(n=>n.FullName.ToLower().Contains(search.ToLower()));
                res.AddRange(employees);
            }
            return res;
        }
    }
}
