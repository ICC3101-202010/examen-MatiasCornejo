using System;
using System.Collections.Generic;
using System.Text;

namespace examen
{
    class Person
    {
        private string name;
        private string nacion;
        private int age;
        private int salary;

        public Person(string name, string nacion, int age, int salary)
        {
            this.name = name;
            this.nacion = nacion;
            this.age = age;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Nacion { get => nacion; set => nacion = value; }
        public int Age { get => age; set => age = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
