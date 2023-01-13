using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmMedico
    {
        public static List<Medico> Listar()
        {
            //TODO listar Medico

            return AuxList();
        }

        public static List<Medico> Listar(string especidalidad)
        {
            List<Medico> auxList = AuxList();


            List<Medico> list = new List<Medico>();
            foreach (Medico med in auxList)
            {
                if (med.Especialidad.Equals(especidalidad)) { list.Add(med); }
            }
            return list;
        }

        public static int Insertar(Medico medico)
        {
            //TODO Insertar Medico
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO Eliminar Medico
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            //TODO eliminar medico
            return null;
        }

        private static List<Medico> AuxList()
        {
            List<Medico> list = new List<Medico>
            {
                new Medico { Id = 1, Nombre = "Juan", Apellido = "Perez", Domicilio = "Av Siempre Viva 23", Telefono = "54 388 154444444", Email = "mail@mail.com", Especialidad = "Clinico", Matricula = 1234 },
                new Medico { Id = 2, Nombre = "Andres", Apellido = "Lamas", Domicilio = "Av Siempre Viva 24", Telefono = "54 388 154444444", Email = "mail@mail.com", Especialidad = "Clinico", Matricula = 1245 },
                new Medico { Id = 3, Nombre = "Maria", Apellido = "Gomez", Domicilio = "Av Siempre Viva 25", Telefono = "54 388 154444444", Email = "mail@mail.com", Especialidad = "Traumatologo", Matricula = 1785 },
                new Medico { Id = 4, Nombre = "Ana", Apellido = "Ruiz", Domicilio = "Av Siempre Viva 23", Telefono = "54 388 154444444", Email = "mail@mail.com", Especialidad = "Generalista", Matricula = 1454 },
                new Medico { Id = 5, Nombre = "Irina", Apellido = "Soto", Domicilio = "Av Siempre Viva 22", Telefono = "54 388 154444444", Email = "mail@mail.com", Especialidad = "Ginecologo", Matricula = 1245 }
            };
            return list;
        }
    }
}
