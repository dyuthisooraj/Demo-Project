using routingattributeassignment.Models;

namespace routingattributeassignment.interfaces
{
    public interface IEmployee
    {
        List<Employee> Details();
        Employee Details(int id);
    }

    public class Employeeservices : IEmployee
    {
        private readonly List<Employee> _employees;

        public Employeeservices()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee() { empid = 1, ename = "Dyuthi" });
            _employees.Add(new Employee() { empid = 2, ename = "Anika" });
            _employees.Add(new Employee() { empid = 3, ename = "Amit" });
            _employees.Add(new Employee() { empid = 2, ename = "Ishita" });
        }

        public Employee Details(int id)
        {
            return _employees.FirstOrDefault(x => x.empid == id);
        }

        public List<Employee> Details()
        {
            return _employees;
        }

    }
}
