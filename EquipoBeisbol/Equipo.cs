﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoBeisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadDeOrigen { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }

        public List<Jugador> Jugadores1 { get; set; }

        public Equipo()
        {
            Nombre = "Sin asignar";
            CiudadDeOrigen = "Sin asignar";
            Entrenador = "Sin asignar";
            Jugadores = "Sin asignar";
        }
      
    }
}
