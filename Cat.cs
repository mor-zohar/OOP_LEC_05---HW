using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_05___HW
{
    internal class Cat : Animals
    {
        public string Color { get; set; }

        public Cat(string color,string name,string sounds)
            :base(name,sounds)
        {
            Color = color;
        }

        public override string Print()
        {
            return $"{base.Print()}, Color: {Color}";
        }
    }
}
