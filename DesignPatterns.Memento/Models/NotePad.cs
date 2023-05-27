using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Models
{
    public class NotePad
    {
        public string Content { get; set; }

        public NotePadMemento Save()
        {
            return new NotePadMemento { ContentMemento = Content };
        }

        public void GoBack(NotePadMemento memento)
        {
            Content = memento.ContentMemento;
        }

        public string GetCurrentContent()
        {
            return Content;
        }
    }
}
