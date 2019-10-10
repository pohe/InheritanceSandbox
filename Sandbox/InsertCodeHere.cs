using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Employee e = new Employee("Vej 123", "Poul", 123);
            Teacher t1 = new Teacher("Programmering","Lollandvej 12", "Charlotte", 444);
            InternationalTeacher I1 = new InternationalTeacher("SWD", "Vej 444", "Peter", 555, "English");

            Console.WriteLine(e.CalculateSalary());

            
            //Console.WriteLine("Hello Poul!") ;

            // The LAST line of code should be ABOVE this line
        }
    }
}