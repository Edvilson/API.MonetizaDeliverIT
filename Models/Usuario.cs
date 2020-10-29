using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monetiza.Models
{
    [Table("pes_usuario")]
    public class Usuario
    {
        [Key]
        public int codusuario { get; set; }
        public string dscnome { get; set; }
        public string dscsenha { get; set; }
        public string dscfuncao { get; set; }
    }
}
