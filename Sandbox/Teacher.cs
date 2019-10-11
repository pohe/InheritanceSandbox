using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Teacher : Employee
    { 
       
        private string _course;

        protected  string Course
        {
            get { return _course; }
            set { _course = value; }
        }

       

        public Teacher(string course, string adress, string name, int id):base(adress, name, id)
        {
            _course = course; 
        }

        public override int CalculateSalary()
        {
            if (_course.Contains("it"))
            {
                return base.CalculateSalary()*3;
            }
            else
            {
                return base.CalculateSalary()*2;
            }
            
        }

        public override string GetTitle()
        {
            return "Teacher";
        }
    }
}
