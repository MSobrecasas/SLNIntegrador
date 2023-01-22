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
    public class DacEnfermero
    {
        private static DBIntegradorContext context = new DBIntegradorContext();

        public static List<Enfermero> Select()
        {
            return context.Enfermeros.ToList();
        }

        public static int Insert(Enfermero enfermero)
        {
            context.Enfermeros.Add(enfermero);
            return context.SaveChanges();
        }

        public static int Update(Enfermero enfermero)
        {
            Enfermero origen = context.Enfermeros.Find(enfermero);
            context.Entry(enfermero).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Delete(int id)
        {
            Enfermero origen = context.Enfermeros.Find(id);
            if (origen != null)
            {
                context.Enfermeros.Remove(origen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Enfermero SelectById(int id)
        {
            return context.Enfermeros.Find(id);
        }
    }
}
