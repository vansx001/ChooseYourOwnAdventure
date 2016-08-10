using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Own_Adventure
{
    class Reader
    {
        string name;

        public Reader()
        {
        }
        public Reader(string name)
        {
            this.name = name;
        }
    public string getName()
        {
            Console.WriteLine("What is your name? \n");
            this.name = Console.ReadLine();
            return this.name;
        }
    }
}
