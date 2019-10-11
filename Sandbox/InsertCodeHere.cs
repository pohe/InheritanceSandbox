using System;
using System.Collections.Generic;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Employee e = new Employee("Vej 123", "Poul", 123);
            Teacher t1 = new Teacher("Programmering i it","Lollandvej 12", "Charlotte", 444);
            InternationalTeacher I1 = new InternationalTeacher("SWC it", "Vej 444", "Peter", 555, "English");

            Employee e2 = new Teacher("SWD", "GAde 444", "Peter", 656);
            Console.WriteLine($"Lønnen for en employee er {e2.CalculateSalary()}");
            e2 = new InternationalTeacher("Database", "Vej 123", "Ole", 66, "English");
            Console.WriteLine($"Lønnen for en employee er {e2.CalculateSalary()}");


            List<Employee> ansatte = new List<Employee>();
            //ansatte.Add(e);
            ansatte.Add(t1);
            ansatte.Add(I1);
            ansatte.Add(e2);
            ansatte.Add((new Secretary("Vej 123", "Michael", 789, true)));
            ansatte.Insert(3, new Manager("Peter", "Gade 55", 99, "Roskilde", 6000));

            Console.WriteLine("Udskriv lønnen for alle ansatte");
            foreach (Employee employee in ansatte)
            {
                Console.WriteLine($"Lønnen for {employee.GetTitle()} er {employee.CalculateSalary()}");
            }

            //Console.WriteLine($"Lønnen for en international teacher er {I1.CalculateSalary()}");
            //Console.WriteLine($"Lønnen for en employee er {e.CalculateSalary()}");

            //Console.WriteLine($"Lønnen for en it underviser er {t1.CalculateSalary()}");
            //Console.WriteLine("Hello Poul!") ;

            // The LAST line of code should be ABOVE this line
        }
    }
}