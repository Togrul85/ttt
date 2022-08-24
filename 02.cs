using System;
using System.Collections.Generic;
using System.Text;

namespace task0
{
    class Student:Person
    {
        private float _point;
        public float Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value > 0)
                {
                    _point = value;
                }
            }
        }
        public Student(string name, string surname, int age):base(name,surname,age)
        {
           Point = _point;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Surname"+Surname+"Age"+Age+"Name"+Name+"Salary");
        }
    }
}
