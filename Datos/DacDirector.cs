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
    public class DacDirector
    {
        private static DBIntegradorContext context = new DBIntegradorContext();

        public static List<Director> Select()
        {
            return context.Directores.ToList();
        }


        public static int Insert(Director director)
        {
            context.Medicos.Add(director);
            return context.SaveChanges();
        }

        public static int Update(Director director)
        {
            Director origen = context.Directores.Find(director.Id);
            context.Entry(director).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Delete(int id)
        {
            Director origen = context.Directores.Find(id);
            if (origen != null)
            {
                context.Medicos.Remove(origen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Director SelectById(int id)
        {
            return context.Directores.Find(id);
        }
    }
}
