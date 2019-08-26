using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoBeisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }

        public Jugador()
        {
            Nombre = "Sin asignar";
            Numero = "Sin asignar";
        }

    }
}
