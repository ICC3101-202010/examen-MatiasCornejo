using System;
using System.Collections.Generic;
using System.Text;

namespace examen
{
    class Jugador:Person

    {
        private int attackPoints;
        private int defensePoints;
        private int ShirtNumber;

      
        public Jugador(string name, string nacion, int age, int salary, int attackPoints, int defensePoints, int shirtNumber) : base(name, nacion, age, salary)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.ShirtNumber1 = shirtNumber;
        }

        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public int DefensePoints { get => defensePoints; set => defensePoints = value; }
        public int ShirtNumber1 { get => ShirtNumber; set => ShirtNumber = value; }
    }
}
