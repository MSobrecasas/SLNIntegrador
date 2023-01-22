using Entidades.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DacHabitacion
    {
        private static DBIntegradorContext context = new DBIntegradorContext();

        public static List<Habitacion> Select()
        {
            return context.Habitaciones.ToList();
        }

        public static List<Habitacion> Select(bool estado)
        {

            var habitaciones = context.Habitaciones
                         .Where(h => h.Estado == estado)
                         .ToList();

            return habitaciones;
        }

        public static int Insert(Habitacion habitacion)
        {
            context.Habitaciones.Add(habitacion);
            return context.SaveChanges();
        }

        public static int Update(Habitacion habitacion)
        {
            Habitacion origen = context.Habitaciones.Find(habitacion.Id);
            context.Entry(habitacion).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Delete(int id)
        {
            Habitacion origen = context.Habitaciones.Find(id);
            if (origen != null)
            {
                context.Habitaciones.Remove(origen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
            Habitacion habitacion = (from h in context.Habitaciones
                                 where h.Numero == numero
                                 select h).SingleOrDefault();
            return habitacion;
        }
    }
}
