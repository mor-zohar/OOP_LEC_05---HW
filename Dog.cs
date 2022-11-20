using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_05___HW
{
    internal class Dog : Animals
    {
        public int Age { get; set; }

        public Dog(int age,string name,string sounds)
            : base(name, sounds) 
        {
            Age = age;
        }

        public override string Print()
        {
            return $"{base.Print()}, Age: {Age}";
        }
    }
}
