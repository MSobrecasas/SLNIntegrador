using Entidades.BASE;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Medico")]
    public class Medico : Persona
    {
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        [Required]
        public string Especialidad { get; set; }
        public int Matricula { get; set; }
    }
}
