﻿using EmployeesApp.Domain;

namespace EmployeesApp.Application.Employees
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        bool CheckIsVIP(Employee employee);
        Employee[] GetAll();
        Employee GetById(int id);
    }
}