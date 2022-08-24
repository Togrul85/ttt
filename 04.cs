using System;
using System.Collections.Generic;
using System.Text;

namespace task0
{
    class Teacher : Person
    {
        private float _salary;

        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    value = Salary;
                }
            }
        }
        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {
            Salary = _salary;
        }
        public override void ShowInfo()
        {
            throw new NotImplementedException(); 
        }

      
    }

}
