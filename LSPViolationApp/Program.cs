using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPViolationApp.Model;

namespace LSPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple ap = new Orange();
            Console.WriteLine("Color of Apple is: "+ap.GetColor());
            Console.ReadLine();
        }
    }
}
