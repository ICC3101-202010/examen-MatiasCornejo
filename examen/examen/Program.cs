using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Jugador j1 = new Jugador("matias", "chile", 22, 500000, 10, 2, 21);
            Jugador j2 = new Jugador("eduardo","chile",23,40000,7,3,12);
            Jugador j3 = new Jugador("eduardo", "chile", 23, 40000, 5, 6, 13);
            Jugador j4 = new Jugador("eduardo", "chile", 23, 110000, 4, 3, 2);
            Jugador j5 = new Jugador("eduardo", "chile", 23, 120000, 7, 3, 3);
            Jugador j6 = new Jugador("eduardo", "chile", 25, 50000, 7, 3, 4);
            Jugador j7 = new Jugador("eduardo", "chile", 28, 50000, 7, 3, 22);
            Jugador j8 = new Jugador("eduardo", "chile", 29, 60000, 7, 3, 6);
            Jugador j9 = new Jugador("eduardo", "chile", 28, 70000, 7, 3, 5);
            Jugador j10 = new Jugador("Martin", "chile", 24, 30000, 7, 3, 24);
            Jugador j11 = new Jugador("Alejandro", "chile", 21, 140000, 7, 3, 23);
            Jugador j12 = new Jugador("eduardo", "chile", 25, 50000, 7, 3, 4);
            Jugador j13 = new Jugador("eduardo", "chile", 25, 50000, 7, 3, 4);
            Jugador j14= new Jugador("eduardo", "chile", 25, 50000, 7, 3, 4);

            Jugador j15 = new Jugador("eduardo", "chile", 25, 50000, 7, 3, 4);
            //Console.WriteLine(j8.Age);
            Medico m1 = new Medico("Dr yañez", "Chile", 55, 4000000, 12);
            Entrenador e1 = new Entrenador("Sampaoli", "Argentino", 43, 12000000, 12); //CREO AL MEDICO Y AL ENTRENADOR DEL EQUIPO 1
            List<Jugador> jugadors = new List<Jugador>();
            List<Medico> medicos = new List<Medico>();   //instancio las listas correspondientes a la clase equipo donde guardo los jugadorees ,medico y tecnico
            List<Entrenador> entrenadors = new List<Entrenador>();

            Equipo E1 = new Equipo();

            if (num == 1) //para crear un equipo completo
            {
                jugadors.Add(j1);
                jugadors.Add(j2);//agrego los jugadores A LA LISTA JUGADORES DE LA CLASE EQUIPO
                jugadors.Add(j3);
                jugadors.Add(j4);
                jugadors.Add(j5);
                jugadors.Add(j6);
                jugadors.Add(j7);
                jugadors.Add(j8);
                jugadors.Add(j9);
                jugadors.Add(j10);
                jugadors.Add(j11);
                jugadors.Add(j12);
                jugadors.Add(j13);
                jugadors.Add(j14);
                jugadors.Add(j15);

                medicos.Add(m1);
                entrenadors.Add(e1);


                E1 = new Equipo("u de chile","chile",jugadors,medicos,entrenadors);
                
            }
            E1.ShowInf(jugadors,medicos,entrenadors); //aqui veo informacion del equipo
            E1.Corroboracion(jugadors);//aqui veo si  al ser un equipo pais que todos sus jugadores corresponden al pais
        }
    }
}
