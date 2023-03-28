using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12
{
    internal class EventGenerator
    {
        public string Name { get; set; }
        public EventGenerator(string name)
        {
            Name = name;
        }

        public delegate void EventHandler(string str);
        public event EventHandler Notify;
        public void EventGenerate()
        {
            if (Notify != null)
            {
                Notify(Name);
            }
            else
            {
                Console.WriteLine("Делегат пуст");
            }
        }
    }
}
