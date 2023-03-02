using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaDoTioBill.Models
{
    internal class TipoQuentinha
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tamanho { get; set; }
        [Required]
        public string Opcoes { get; set; }
    }
}
