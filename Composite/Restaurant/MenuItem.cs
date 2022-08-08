using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    // будь-яка наша страва/напій
    class MenuItem : TreeElement
    {
        public string name;
        public double cost;
        public string descr;

        public override void print()
        {
            Console.WriteLine($"{name} - {descr} - {cost}");
        }
    }
}
