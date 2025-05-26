using EmployeesApp.Application.Employees;
using EmployeesApp.Infrastructure.Persistance.Repositories;

namespace EmployeesApp.Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new EmployeeRepository();
            var service = new EmployeeService(repository);

            var employees = service.GetAll();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
            try
            {
                var result = service.GetById(62);
                Console.WriteLine($"Employee: {result.Name}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Processing failed: {e.Message}");
            }

        }
    }
}
