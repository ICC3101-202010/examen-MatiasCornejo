using System;
using System.Collections.Generic;
using System.Text;

namespace examen
{
    class Equipo
    {
        private List<Jugador> jugadors; //creo lista d jugadores del equipo
        private List<Medico> medicos;
        private List<Entrenador> entrenadors;
        private string nameTeam;
        private string nacionORleague;

        public Equipo()
        {
        }





        /*public Equipo(List<Jugador> jugadors)
        {
            this.Jugadors = jugadors;
        }
        */
        public Equipo(string nameTeam, string nacionORleague,List<Jugador> jugadors, List<Medico> medicos, List<Entrenador> entrenadors)
        {
            this.jugadors = jugadors;
            this.medicos = medicos;
            this.entrenadors = entrenadors;
            this.NameTeam = nameTeam;
            this.NacionORleague = nacionORleague;

        }

        public List<Jugador> Jugadors { get => jugadors; set => jugadors = value; }
        
        public List<Medico> Medicos { get => medicos; set => medicos = value; }
        public List<Entrenador> Entrenadors { get => entrenadors; set => entrenadors = value; }
        public string NameTeam { get => nameTeam; set => nameTeam = value; }
        public string NacionORleague { get => nacionORleague; set => nacionORleague = value; }

        public void ShowInf(List<Jugador> lis1,List<Medico>list2,List<Entrenador>list3)  //metodo que nos muestra a informacion del equipo , podrian haber sido  mas cosas pero solo mostrare nombre de plantel ,doctor y entrenador
        {
            
            Console.WriteLine("La lista de jugadores del equipo es");
            Console.WriteLine("");
            foreach (Jugador jugador in lis1)
            {
                Console.WriteLine("NOMBRE JUGADOR:  "+jugador.Name+"  Y SU NUMERO DE CAMISETA ES :"+jugador.ShirtNumber1);
            }

            Console.WriteLine("");   //perdon no me funcionaba la barra para el otro lado (mac--> windows == pum)
            Console.WriteLine("");
            Console.WriteLine("El medico de este equipo es :");
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (Medico medico in list2)
            {
                Console.WriteLine(medico.Name);

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("El tecnico del equipo es:");
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (Entrenador entrenador in list3)
            {
                Console.WriteLine(entrenador.Name);
            }
            
            
        }
        public void Corroboracion(List<Jugador> list1)
        {
            Console.WriteLine("comienza la comprobacion de que todo su equipo del pais este en orden");

            foreach(Jugador jugador in list1)
            {
                if (jugador.Nacion != nacionORleague)
                {
                    Console.WriteLine("el jugador :" + jugador.Name + " no cumple con las bases del campeonato ya que su nacionalidad corresponde a :" + jugador.Nacion );
                    Console.WriteLine("Para poder Jugar necesetira retirar al jugador de su plantel ");
                    break;

                }
                
            }
            Console.WriteLine("comprobacion exitosa");

        }

    }
}
