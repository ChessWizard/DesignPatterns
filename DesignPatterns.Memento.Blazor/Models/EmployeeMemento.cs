using DesignPatterns.Memento.Blazor.Models.Interfaces;

namespace DesignPatterns.Memento.Blazor.Models
{
    public class EmployeeMemento : ICareTaker<Employee>
    {
        public Employee Originator { get; set; } = new();
    }
}
