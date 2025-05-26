using EmployeesApp.Domain;

namespace EmployeesApp.Application.Employees
{
    public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
    {
        public EmployeeService()
        {
           
        }

        public void Add(Employee employee)
        {
            if(employee == null)
                throw new ArgumentException($@"{nameof(employee)} must not be null", nameof(employee));
            
            employeeRepository.Add(employee);
        }


        public Employee[] GetAll()
        {
            return employeeRepository
                .GetAll()
                .OrderBy(o => o.Name)
                .ToArray();
        }

        public Employee? GetById(int id)
        {
            if (id <= 0)
                throw new ArgumentException($@"Id must be a positive value", nameof(id));

            var ret = employeeRepository.GetById(id);

            if (ret == null)
                throw new Exception($@"Unable to find employee with {nameof(Employee.Id)} {id}");

            return ret;
        }

        public bool CheckIsVIP(Employee employee) =>
            employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
    }

}