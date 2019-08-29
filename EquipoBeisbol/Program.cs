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

            Equipo aguilas = new Equipo("Águilas");
            aguilas.Entrenador = "Luis Miguel";
            aguilas.CiudadDeOrigen = "Hermosillo";

            aguilas.Jugadores.Add(new Jugador("Pedro", 7));
            aguilas.Jugadores.Add(new Jugador("Ramón", 23));
            aguilas.Jugadores.Add(new Jugador("Ulises", 9));
            aguilas.Jugadores.Add(new Jugador("Arturo", 44));
            aguilas.Jugadores.Add(new Jugador("Eduardo", 12));
            aguilas.Jugadores.Add(new Jugador("Raúl", 3));
            aguilas.Jugadores.Add(new Jugador("Kevin", 5));
            aguilas.Jugadores.Add(new Jugador("Andrés", 99));
            aguilas.Jugadores.Add(new Jugador("Jorge", 67));

            Equipo toros = new Equipo("Toros");
            toros.Entrenador = "Ricardo Montés";
            toros.CiudadDeOrigen = "Ciudad Obregón";

            toros.Jugadores.Add(new Jugador("Martín", 8));
            toros.Jugadores.Add(new Jugador("Brayan", 83));
            toros.Jugadores.Add(new Jugador("Elmer", 24));
            toros.Jugadores.Add(new Jugador("Adán", 41));
            toros.Jugadores.Add(new Jugador("Alberto", 16));
            toros.Jugadores.Add(new Jugador("José", 2));
            toros.Jugadores.Add(new Jugador("Ronaldo", 65));
            toros.Jugadores.Add(new Jugador("Amador", 98));
            toros.Jugadores.Add(new Jugador("Emiliano", 73));

            equipos.Add(aguilas);
            equipos.Add(toros);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("*" + equipo.Nombre + " de " + equipo.CiudadDeOrigen);

                foreach(Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("- " + jugador.Nombre + " " + jugador.Numero);
                }
            }

            Console.Read();
        }
    }
}
