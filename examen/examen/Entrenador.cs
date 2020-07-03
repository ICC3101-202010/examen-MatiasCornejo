using System;
using System.Collections.Generic;
using System.Text;

namespace examen
{
    class Entrenador : Person
    {
        private int tacticPoints;

        public Entrenador(string name, string nacion, int age, int salary, int tacticPoints):base(name,nacion,age,salary)
        {
            this.tacticPoints = tacticPoints;
        }
    }
}