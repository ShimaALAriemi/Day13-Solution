using Day13.NewFolder;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Shaima", 24,8899339,"Oman, SUR", "Trainee",10,10);

            Console.WriteLine(employee.ToString());
            employee.Eat();

            Student student = new Student();
            student.Eat();
            student.isPeopleObject();
        }
    }
}