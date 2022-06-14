using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2_Prototype
{
    internal class ConcretePrototype
    {
        public string field1 { get; set; }

        public ConcretePrototype Clone()
        {
            return (ConcretePrototype)this.MemberwiseClone();
        }
    }
}
