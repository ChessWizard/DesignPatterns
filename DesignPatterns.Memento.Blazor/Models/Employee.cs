using DesignPatterns.Memento.Blazor.Models.Interfaces;

namespace DesignPatterns.Memento.Blazor.Models
{
    public class Employee : IOriginator<EmployeeMemento>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string CitizenNumber { get; set; }

        public EmployeeMemento CreateMemento()
        {
            EmployeeMemento memento = new();
            memento.Originator.Name = Name;
            memento.Originator.Surname = Surname;
            memento.Originator.Age = Age;
            memento.Originator.CitizenNumber = CitizenNumber;
            return memento;
        }

        public void UndoChanges(EmployeeMemento mementoModel)
        {
            Name = mementoModel.Originator.Name;
            Surname = mementoModel.Originator.Surname;
            Age = mementoModel.Originator.Age;
            CitizenNumber = mementoModel.Originator.CitizenNumber;
        }
    }
}
