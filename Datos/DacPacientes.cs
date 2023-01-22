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
    public class DacPacientes
    {
        private static DBIntegradorContext context = new DBIntegradorContext();

        public static List<Paciente> Select()
        {
            return context.Pacientes.ToList();
        }

        public static int Insert(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return context.SaveChanges();
        }

        public static int Update(Paciente paciente)
        {
            Paciente origen = context.Pacientes.Find(paciente.Id);
            context.Entry(paciente).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public static int Delete(int id)
        {
            Paciente origen = context.Pacientes.Find(id);
            if (origen != null)
            {
                context.Pacientes.Remove(origen);
                return context.SaveChanges();
            }
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            Paciente paciente = (from p in context.Pacientes
                           where p.NroHistoriaClinica == nroHistoriaClinica
                           select p).SingleOrDefault();
            return paciente;
        }
    }
}
