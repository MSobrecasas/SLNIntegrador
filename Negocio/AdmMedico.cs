using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public static class AdmMedico
    {
        public static List<Medico> Listar()
        {

            return DacMedico.Select();
        }

        public static List<Medico> Listar(string especidalidad)
        {
            return DacMedico.Select(especidalidad);
        }

        public static int Insertar(Medico medico)
        {

            return DacMedico.Insert(medico);
        }

        public static int Eliminar(int id)
        {
            return DacMedico.Delete(id);
        }

        public static Medico TraerUno(int id)
        {
            return DacMedico.SelectById(id);
        }

        public static int Modificar(Medico medico)
        {
            return DacMedico.Update(medico);
        }
    }
}
