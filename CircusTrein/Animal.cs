using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        private string name;
        private int size;
        private int type;

        public Animal(string name, int size, int type)
        {
            this.name = name;
            this.size = size;
            this.type = type;

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public override string ToString()
        {
            return Name + " " + size + " " + type;
        }
    }
}
