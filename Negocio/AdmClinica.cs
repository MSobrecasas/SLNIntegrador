using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmClinica
    {
        public static List<Clinica> Listar()
        {

            return DacClinica.Select();
        }

        public static int Insertar(Clinica clinica)
        {

            return DacClinica.Insert(clinica);
        }

        public static int Eliminar(int id)
        {
            return DacClinica.Delete(id);
        }

        public static Clinica TraerUno(int id)
        {
            return DacClinica.SelectById(id);
        }

        public static int Modificar(Clinica clinica)
        {
            return DacClinica.Update(clinica);
        }
    }
}
