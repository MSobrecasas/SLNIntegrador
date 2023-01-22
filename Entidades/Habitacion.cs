using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Habitacion")]
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public bool Estado { get; set; }
    }
}
