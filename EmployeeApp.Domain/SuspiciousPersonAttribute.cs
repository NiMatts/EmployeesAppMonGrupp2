using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Domain
{
    public class SuspiciousPersonAttribute(string name) : ValidationAttribute
    {
        public override bool IsValid(object? value) =>
            value?.ToString()?.ToUpper() != name.ToUpper();
    }
}
