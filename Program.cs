using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    internal class constuctor
    {
        string name;
        int id;
        public constuctor(string n,int n2)
        {
            name = n;
            id = n2;
        }
        public constuctor(constuctor c)
        {
            this.name = c.name;
            this.id = c.id;
        }
        static void Main(string[] args)
        {
            constuctor c1 = new constuctor("susmi", 21);
            constuctor c2 = new constuctor(c1);
            Console.WriteLine("first object: name: {0},id={1}", c1.name, c1.id);
            Console.WriteLine("copied object: name: {0},id={1}", c2.name, c2.id);
            Console.ReadLine();
        }
    }
}
