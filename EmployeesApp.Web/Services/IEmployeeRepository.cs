using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        bool CheckIsVIP(Employee employee);
        Employee[] GetAll();
        Employee GetById(int id);
    }
}