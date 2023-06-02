using DesignPatterns.Memento.Blazor.Models.Interfaces;

namespace DesignPatterns.Memento.Blazor.Models
{
    public class EmployeeManager : IMemento<EmployeeMemento>
    {
        public Stack<EmployeeMemento> Memory { get;} = new();

        public void AddMementoToMemory(EmployeeMemento memento) => Memory.Push(memento);

        public EmployeeMemento GetCurrentMemento()
        {
            Memory.Pop();
            return Memory.FirstOrDefault();// Stack olduğu için en üstteki eleman alınmalı
        }
    }
}
