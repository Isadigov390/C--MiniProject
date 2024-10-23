using HR_management_app.Models;

Employee employee = new Employee("Isa Sadigov", "Devleoper", 1200, "Software");
Department department = new Department("Software", 12, 3000);
HumanResourceManager manager = new HumanResourceManager();
manager.AddDepartment(department);
manager.AddEmployee(employee, "Software");
var deps = manager.GetDepartments();
foreach (var dep in deps) Console.WriteLine(dep.Name);
manager.EditDepartaments("Software","Android");
foreach (var dep in deps) Console.WriteLine(dep.Name);
Console.WriteLine(employee.No);
//manager.EditEmploye("AN1001",2000,"Developerer");
//foreach (var dep in deps) Console.WriteLine(dep.Name);
var depss=manager.Search("a");
foreach (var dep in depss) Console.WriteLine(dep.FullName);


