using HR_management_app.Models;

namespace HR_management_app.Interfaces
{
    public interface IHumanResourceManager
    {
        List<Department> Departments { get; }
        void AddDepartment(Department department);
        List<Department> GetDepartments();
        void EditDepartaments(string searchedDepName,string newDepName);
        void AddEmployee(Employee employee,string depName);
        void RemoveEmployee(string employeeNo,string depName);
        void EditEmploye(string no,decimal newSalary,string newPossition);
        List<Employee> Search(string search);
    }
}
