using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmDirector
    {
        public static List<Director> Listar()
        {

            return DacDirector.Select();
        }


        public static int Insertar(Director director)
        {

            return DacDirector.Insert(director);
        }

        public static int Eliminar(int id)
        {
            return DacDirector.Delete(id);
        }

        public static Director TraerUno(int id)
        {
            return DacDirector.SelectById(id);
        }

        public static int Modificar(Director director)
        {
            return DacDirector.Update(director);
        }
    }
}
