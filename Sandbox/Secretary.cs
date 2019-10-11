using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Secretary: Employee
    {
        public bool TranslationCapacity { get; set; }
        public Secretary(string adress, string name, int id, bool translationCapacity) : base(adress, name, id)
        {
            TranslationCapacity = translationCapacity;
        }

        public override int CalculateSalary()
        {
            if (TranslationCapacity == true)
                return base.CalculateSalary() * 2;
            else
            {
                return base.CalculateSalary();
            }
        }

        public override string GetTitle()
        {
            return "Secretary";
        }
    }
}
