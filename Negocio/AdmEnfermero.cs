using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmEnfermero
    {
        public static List<Enfermero> Listar()
        {

            return DacEnfermero.Select();
        }


        public static int Insertar(Enfermero enfermero)
        {

            return DacEnfermero.Insert(enfermero);
        }

        public static int Eliminar(int id)
        {
            return DacEnfermero.Delete(id);
        }

        public static Enfermero TraerUno(int id)
        {
            return DacEnfermero.SelectById(id);
        }

        public static int Modificar(Enfermero enfermero)
        {
            return DacEnfermero.Update(enfermero);
        }
    }
}
