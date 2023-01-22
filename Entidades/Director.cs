using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Table("Director")]
    public class Director : Medico
    {
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        [Required]
        public string PostGrado { get; set; }
    }
}
