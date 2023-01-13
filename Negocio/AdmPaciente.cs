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
            //TODO retornar lsita pacientes
            
            return AuxList();
        }

        public static int Insertar(Paciente paciente)
        {
            //TODO Insertar paciente
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO Eliminar paciente
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            //TODO Traer un Paciente
            return null;
        }

        private static List<Paciente> AuxList()
        {
            List<Paciente> list = new List<Paciente>
            {
                new Paciente { Id = 1, Nombre = "Adrian", Apellido = "Rojas", Domicilio = "Av Siempre Viva 23", Telefono = "54 388 154444444", Email = "mail@mail.com",  NroHistoriaClinica = 10203},
                new Paciente { Id = 2, Nombre = "Jose", Apellido = "Diaz", Domicilio = "Av Siempre Viva 24", Telefono = "54 388 154444444", Email = "mail@mail.com",  NroHistoriaClinica = 10204},
                new Paciente { Id = 3, Nombre = "Luis", Apellido = "Quispe", Domicilio = "Av Siempre Viva 25", Telefono = "54 388 154444444", Email = "mail@mail.com",  NroHistoriaClinica = 10205},
                new Paciente { Id = 4, Nombre = "Yesica", Apellido = "Llanos", Domicilio = "Av Siempre Viva 23", Telefono = "54 388 154444444", Email = "mail@mail.com", NroHistoriaClinica = 10206},
                new Paciente { Id = 5, Nombre = "Lucia", Apellido = "Luna", Domicilio = "Av Siempre Viva 22", Telefono = "54 388 154444444", Email = "mail@mail.com",  NroHistoriaClinica = 10207}
            };
            return list;
        }
    }
}
