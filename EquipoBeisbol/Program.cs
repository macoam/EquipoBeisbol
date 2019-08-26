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

            Equipo leones = new Equipo("Leónes");
            Equipo toros = new Equipo("Toros");

            equipos.Add(leones);
            equipos.Add(toros);

            Jugador elmer = new Jugador("Elmer", "45");
            Jugador pablito = new Jugador("Pablito", "12");
            Jugador bebitamoxita = new Jugador("BebitaMoxita", "05");
            Jugador ezra = new Jugador("Ezra", "91");
            Jugador kakaroto = new Jugador("Goku-san", "13");

            toros.Jugadores1.Add(elmer);
            toros.Jugadores1.Add(bebitamoxita);
            toros.Jugadores1.Add(ezra);
        }
    }
}
