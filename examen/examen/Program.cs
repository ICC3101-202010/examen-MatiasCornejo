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
            Jugador j3 = new Jugador("ignacio", "chile", 23, 40000, 5, 6, 13);
            Jugador j4 = new Jugador("rafael", "chile", 23, 110000, 4, 3, 2);
            Jugador j5 = new Jugador("eduardo", "chile", 23, 120000, 7, 3, 3);
            Jugador j6 = new Jugador("jose", "chile", 25, 50000, 7, 3, 4);
            Jugador j7 = new Jugador("eduardo", "chile", 28, 50000, 7, 3, 22);
            Jugador j8 = new Jugador("gary", "chile", 29, 60000, 7, 3, 6);      //equipo 1
            Jugador j9 = new Jugador("eduardo", "chile", 28, 70000, 7, 3, 5);
            Jugador j10 = new Jugador("Martin", "chile", 24, 30000, 7, 3, 24);
            Jugador j11 = new Jugador("Alejandro", "peru", 21, 140000, 7, 3, 23);//ojo aca me equivoco adrede de nacionalidad para que se vea en el metodo en el equipo 2
            Jugador j12 = new Jugador("eduardo", "chile", 25, 50000, 7, 3, 4);
            Jugador j13 = new Jugador("victor", "chile", 25, 50000, 7, 3, 4);
            Jugador j14= new Jugador("eduardo", "chile", 25, 50000, 7, 3, 4);

            Jugador j15 = new Jugador("eduardo", "chile", 25, 50000, 7, 3, 4);
            //Console.WriteLine(j8.Age);
            Medico m1 = new Medico("Dr yañez", "Chile", 55, 4000000, 12);
            Entrenador e1 = new Entrenador("Sampaoli", "Argentino", 43, 12000000, 12); //CREO AL MEDICO Y AL ENTRENADOR DEL EQUIPO 1


            
            /*
            //equipo 2
            int numm = 2;
            Jugador jj1 = new Jugador("matias", "peru", 22, 500000, 10, 2, 21);
            Jugador jj2 = new Jugador("eduardo", "peru", 23, 40000, 7, 3, 12);
            Jugador jj3 = new Jugador("leo", "peru", 23, 40000, 5, 6, 13);
            Jugador jj4 = new Jugador("bastian", "peru", 23, 110000, 4, 3, 2);
            Jugador jj5 = new Jugador("mickel", "peru", 23, 120000, 7, 3, 3);
            Jugador jj6 = new Jugador("alexis", "peru", 25, 50000, 7, 3, 4);
            Jugador jj7 = new Jugador("eduardo", "peru", 28, 50000, 7, 3, 22);
            Jugador jj8 = new Jugador("antonio", "peru", 29, 60000, 7, 3, 6);      //equipo 1
            Jugador jj9 = new Jugador("eduardo", "chile", 28, 70000, 7, 3, 5);
            Jugador jj10 = new Jugador("Martin", "peru", 24, 30000, 7, 3, 24);  
            Jugador jj11 = new Jugador("Alejandro", "peru", 21, 140000, 7, 3, 23);
            Jugador jj12 = new Jugador("eduardo", "peru", 25, 50000, 7, 3, 4);
            Jugador jj13 = new Jugador("pablo", "peru", 25, 50000, 7, 3, 4);
            Jugador jj14 = new Jugador("eduardo", "peru", 25, 50000, 7, 3, 4);

            Jugador jj15 = new Jugador("eduardo", "peru", 25, 50000, 7, 3, 4);
            //Console.WriteLine(j8.Age);
            Medico m2 = new Medico("Dr manriquez", "Chile", 55, 4000000, 12);
            Entrenador e2 = new Entrenador("Maradona", "Argentino", 53, 12000000, 12); //CREO AL MEDICO Y AL ENTRENADOR DEL EQUIPO 1

            */












            List<Jugador> jugadors = new List<Jugador>();
            List<Medico> medicos = new List<Medico>();   //instancio las listas correspondientes a la clase equipo donde guardo los jugadorees ,medico y tecnico
            List<Entrenador> entrenadors = new List<Entrenador>();

            Equipo E1 = new Equipo();

            if (num == 1) //para crear un equipo completo
            {
                jugadors.Add(j1);
                jugadors.Add(j2);//agrego los jugadores A LA LISTA JUGADORES DE LA CLASE EQUIPO 1
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


                E1 = new Equipo("Seleccion Chile","chile",jugadors,medicos,entrenadors);
                
            }
            /* Equipo E2 = new Equipo();
             if (numm == 2) //para crear un equipo completo
             {
                 jugadors.Add(jj1);
                 jugadors.Add(jj2);//agrego los jugadores A LA LISTA JUGADORES DE LA CLASE EQUIPO 1
                 jugadors.Add(jj3);
                 jugadors.Add(jj4);
                 jugadors.Add(jj5);
                 jugadors.Add(jj6);
                 jugadors.Add(jj7);
                 jugadors.Add(jj8);
                 jugadors.Add(jj9);
                 jugadors.Add(jj10);
                 jugadors.Add(jj11);
                 jugadors.Add(jj12);
                 jugadors.Add(jj13);
                 jugadors.Add(jj14);
                 jugadors.Add(jj15);

                 medicos.Add(m2);
                 entrenadors.Add(e2);


                 E2 = new Equipo("Seleccion Peru", "peru", jugadors, medicos, entrenadors);

             }
             E2.ShowInf(jugadors,medicos,entrenadors); //aqui veo informacion del equipo
             E2.Corroboracion(jugadors);//aqui veo si  al ser un equipo pais que todos sus jugadores corresponden al pais
            */

            E1.ShowInf(jugadors,medicos,entrenadors); //aqui veo informacion del equipo
            E1.Corroboracion(jugadors);//aqui veo si  al ser un equipo pais que todos sus jugadores corresponden al pais
        }
    }
}
