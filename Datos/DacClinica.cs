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
    public class DacClinica
    {
        private static DBIntegradorContext context = new DBIntegradorContext();

        public static List<Clinica> Select()
        {
            return context.Clinicas.ToList();
        }


        public static int Insert(Clinica medico)
        {
            context.Clinicas.Add(medico);
            return context.SaveChanges();
        }

        public static int Update(Clinica clinica)
        {
            Clinica origen = context.Clinicas.Find(clinica.Id);
            context.Entry(clinica).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Delete(int id)
        {
            Clinica origen = context.Clinicas.Find(id);
            if (origen != null)
            {
                context.Clinicas.Remove(origen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Clinica SelectById(int id)
        {
            return context.Clinicas.Find(id);
        }
    }
}
