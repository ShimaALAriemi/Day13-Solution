using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13.NewFolder
{
    public class Employee : People, ICreature
    {
        string role;
        int workingHoures;
        int wage;

        public Employee()
        {
            
        }


        public Employee( string name, int age, int SSN, string address,
string role,int workingHoures, int wage):base(name, age, SSN, address)
        {
            this.role = role;
            this.workingHoures = workingHoures;
            this.wage = wage;
            
        }

        public void Eat()
        {
            Console.WriteLine("I Eat");
        }

        public void Move()
        {
            Console.WriteLine("I Move");
        }

         public  void Sleep()
        {
            Console.WriteLine("I Sleep");
        }

        //Using sealed for virtual method inhearted fron base class
        public sealed override string isPeopleObject()
        {
            return base.isPeopleObject() + "also Employee Object";
        }
        public override string ToString()
        {
            return base.ToString() + $"Your Role:  {this.role}";
        }

        
    }
}
