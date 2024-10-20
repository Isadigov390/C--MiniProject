using HR_management_app.Models;

namespace HR_management_app.Interfaces
{
    public interface IHumanResourceManager
    {
        List<Department> Departments { get; }
        void AddDepartment();
        List<Department> GetDepartments();
        void EditDepartaments();
        void AddEmployee();
        void RemoveEmployee();
        void EditEmploye();
        List<Department> Search();
    }
}
