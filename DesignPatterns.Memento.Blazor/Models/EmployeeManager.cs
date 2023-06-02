using DesignPatterns.Memento.Blazor.Models.Interfaces;

namespace DesignPatterns.Memento.Blazor.Models
{
    public class EmployeeManager : IMemento<EmployeeMemento>
    {
        public Stack<EmployeeMemento> memory { get; set; } = new();

        public void AddMementoToMemory(EmployeeMemento memento) => memory.Push(memento);
        
        public EmployeeMemento GetCurrentMemento() => memory.Pop();
    }
}
