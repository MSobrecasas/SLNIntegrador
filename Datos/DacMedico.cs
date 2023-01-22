using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Entidades.Context;
using System.Data.Entity;

namespace Datos
{
    public static class DacMedico
    {
        private static DBIntegradorContext context = new DBIntegradorContext();

        public static List<Medico> Select()
        {
            return context.Medicos.ToList();
        }

        public static List<Medico> Select(string especialidad)
        {

            var medicos = context.Medicos
                         .Where(m => m.Especialidad == especialidad)
                         .OrderBy(m => m.Nombre)
                         .ToList();

            return medicos;
        }

        public static int Insert(Medico medico)
        {
            context.Medicos.Add(medico);
            return context.SaveChanges();
        }

        public static int Update(Medico medico)
        {
            Medico origen = context.Medicos.Find(medico.Id);
            context.Entry(medico).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Delete(int id)
        {
            Medico origen = context.Medicos.Find(id);
            if (origen != null)
            {
                context.Medicos.Remove(origen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Medico SelectById(int id)
        {
            return context.Medicos.Find(id);
        }
    }
}
