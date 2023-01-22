using Entidades.BASE;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Paciente")]
    public class Paciente : Persona
    {
        public int NroHistoriaClinica { get; set; }
    }
}
