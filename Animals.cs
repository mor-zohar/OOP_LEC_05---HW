using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEC_05___HW
{
    internal class Animals
    {
        public string Name { get; set; }
        public string Sounds { get; set; }

        public Animals(string name,string sounds)
        {
            Name= name;
            Sounds= sounds; 
        }   
        
        public virtual string Print()
        {
            return $"Name: {Name}, Sound: {Sounds}";
        }

    }
}
