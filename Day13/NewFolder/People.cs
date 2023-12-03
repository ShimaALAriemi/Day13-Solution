using Day13.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13.NewFolder
{
    public class People : ClassToAbstract, ICreature
    {
        static int con =0; 
        int id;
        string name;
        int age;
        int SSN;
        string address;

        public People()
        {
            
        }
        public People( string name,int age, int SSN, string address)
        {
            this.id = con++;
            this.name = name;
            this.age = age;
            this.SSN = SSN;
            this.address = address;
        }
        public override string ToString()
        {
            return $"Your Name: {this.name}";
        }

        public virtual string isPeopleObject()
        {
            return "is an People Object";
        }

        //Using sealed for abstract method inhearted fron abstract class
        public sealed override void Create()
        {
            Console.WriteLine("I can create an Object");
        }

        public void Eat()
        {
            Console.WriteLine("I Eat");
        }

        public void Move()
        {
            Console.WriteLine("I Move");
        }

        public void Sleep()
        {
            Console.WriteLine("I Sleep");
        }
    }

   
}
