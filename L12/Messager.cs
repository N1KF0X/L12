using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12
{
    internal class Messager
    {
        string Message { get; set; }
        public Messager(string txt)
        {
            this.Message = txt;
        }
        public void GetInfo(string generator)
        {
            Console.WriteLine("Имя генератора: " + generator);
            Console.WriteLine("Сообщение: " + Message);
        }
    }
}
