using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventGenerator firstEG = new EventGenerator("firstEG");
            EventGenerator secondEG = new EventGenerator("secondEG");
            Messager messager = new Messager("text");
            firstEG.EventGenerate();
            firstEG.Notify += messager.GetInfo;
            secondEG.Notify += messager.GetInfo;
            firstEG.EventGenerate();
            secondEG.EventGenerate();

        }
    }
}
