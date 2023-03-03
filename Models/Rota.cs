using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class Rota
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NomeRota { get; set; }
        [Required]
        public double Taxa { get; set; }

        public Rota()
        {

        }
    }
}
