using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Models
{
    public class Memory
    {
        public List<NotePadMemento> NotePadMementos { get; set; } = new();

        public void Add(NotePadMemento memento)
        {
            NotePadMementos.Add(memento);
        }

        public List<NotePadMemento> GetCurrentMemory()
        {
            return NotePadMementos;
        }

        public NotePadMemento GetCurrentMemento()
        {
            if (!NotePadMementos.Any()) { throw new IndexOutOfRangeException("List is empty!"); }

            var currentElement = NotePadMementos.LastOrDefault();

            if (currentElement is null) { throw new Exception("Not Found Memento!"); }

            NotePadMementos.Remove(currentElement);

            return currentElement;
        }
    }
}
