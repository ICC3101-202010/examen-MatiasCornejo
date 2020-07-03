using System;
using System.Collections.Generic;
using System.Text;

namespace examen
{
    class Medico : Person
    {
        private int experiecePoints;

        public Medico(string name, string nacion, int age, int salary, int experiecePoints) : base(name, nacion, age, salary)
        {
            this.experiecePoints = experiecePoints;
        }

     

        public int ExperiecePoints { get => experiecePoints; set => experiecePoints = value; }
    }
}
