using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoBeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo toros = new Equipo("Matemáticas", "MAT6622");
            Equipo aguilas = new Equipo("Historia", "HTS1313");

            equipos.Add(toros);
            equipos.Add(aguilas);

            Jugador elmer = new Jugador("Elmer", "78");
            Jugador pablito = new Jugador("Pablito", "01");
            Jugador bebitamoxita = new Jugador("BebitaMoxita", "56");
            Jugador ezra = new Jugador("Ezra", "34");
            Jugador kakaroto = new Jugador("Goku-san", "32");
            Jugador linda = new Jugador("Linda", "01");
            Jugador tadeo = new Jugador("Tadeo", "56");
            Jugador carlos = new Jugador("Ezra", "34");
            Jugador jhony = new Jugador("Goku-san", "32");


            toros.Jugadores1.Add(elmer);
            toros.Jugadores1.Add(bebitamoxita);
            toros.Jugadores1.Add(linda);
            toros.Jugadores1.Add(tadeo);
            toros.Jugadores1.Add(carlos);
            toros.Jugadores1.Add(jhony);
            toros.Jugadores1.Add(pablito);
            toros.Jugadores1.Add(kakaroto);
            toros.Jugadores1.Add(ezra);
   

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " + equipo.Jugadores);
                Console.WriteLine("Materia: " + equipo.Jugadores);
                Console.WriteLine("Lista de alumnos: ");

                foreach (Jugador jugador in equipo.Jugadores1)
                {
                    Console.WriteLine("-" + equipo.Nombre);
                }
            }

            Console.Read();
        }
    }
}
