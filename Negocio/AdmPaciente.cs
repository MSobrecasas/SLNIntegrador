using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        public static List<Paciente> Listar()
        {
            return DacPacientes.Select();
        }

        public static int Insertar(Paciente paciente)
        {
            return DacPacientes.Insert(paciente);
        }
        public static int Eliminar(int id)
        {
            return DacPacientes.Delete(id);
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
           return DacPacientes.TraerUno(nroHistoriaClinica);
        }

    }
}
