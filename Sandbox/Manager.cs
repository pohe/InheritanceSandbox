using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Manager: Employee
    {
        public string Department { get; set; }

        public int Bonus { get; set; }
        public Manager(string name, string adress, int id, string department, int bonus):base(adress, name, id)
        {
            Department = department;
            Bonus = bonus;
        }

        public override int CalculateSalary()
        {
            return 4* base.CalculateSalary() + Bonus;
        }

        public override string GetTitle()
        {
            return "Manager";
        }
    }
}
