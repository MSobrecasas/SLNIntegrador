using Datos;
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
            return DacHabitacion.Select();
        }

        public static List<Habitacion> Listar(bool estado)
        {
            return DacHabitacion.Select(estado);
        }

        public static int Insertar(Habitacion habitacion)
        {
            return DacHabitacion.Insert(habitacion);
        }
        public static int Eliminar(int id)
        {
            return DacHabitacion.Delete(id);
        }

        public static Habitacion TraerUno(int numero)
        {
            return DacHabitacion.TraerUno(numero);
        }

    }
}
