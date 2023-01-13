using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmHabitacion
    {
        public static List<Habitacion> Listar()
        {
            //TODO retornar lista habitaciones
            return AuxList();
        }

        public static List<Habitacion> Listar(bool estado)
        {
            //TODO retornar lista habitaciones segun estado
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            //TODO Insertar habitacion
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO Eliminar habitacion
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
            //TODO Traer un habitacion
            return null;
        }

        private static List<Habitacion> AuxList()
        {
            List<Habitacion> list = new List<Habitacion>();
            list.Add(new Habitacion { Id = 1, Numero = 12, Estado = true });
            list.Add(new Habitacion { Id = 2, Numero = 13, Estado = true });
            list.Add(new Habitacion { Id = 3, Numero = 14, Estado = false });
            list.Add(new Habitacion { Id = 4, Numero = 15, Estado = false });
            list.Add(new Habitacion { Id = 5, Numero = 16, Estado = true });
            return list;
        }

    }
}
