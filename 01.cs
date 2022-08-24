using System;
using System.Collections.Generic;
using System.Text;

namespace task0
{
    abstract class Person
    {
        private static int _id;
        public int _Id { get; }
        public string _name;
        public string _surname;
        public int _age;
        public Person(string name, string surname, int age)
        {
            _id++;
            _id = Id;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public int Id
        {
            get
            {
                return _Id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 0)
                {
                    value = _name;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                if (value.Length > 0)
                {
                    value = _surname;
                }
            }

        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    value = _age;
                }
            }
        }
        public abstract void ShowInfo();

    }

}
    

