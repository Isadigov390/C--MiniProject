using HR_management_app.Models;

Employee employee = new Employee("Isa Sadigov", "Devleoper", 1200, "Software");
Department department = new Department("Software", 12, 3000);
HumanResourceManager manager = new HumanResourceManager();
manager.AddDepartment(department);
//manager.AddEmployee(employee, "Software");
//var deps = manager.GetDepartments();
//foreach (var dep in deps) Console.WriteLine(dep.Name);

