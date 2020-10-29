using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monetiza.Models
{
    [Table("fis_cpagar")]
    public class Conta
    {

        [Key]
        public int codcpagar { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 55 caracteres")]
        [MaxLength(55, ErrorMessage = "Este campo deve conter entre 3 a 55 caracteres")]
        public string dscnome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 a 55 caracteres")]
        [MaxLength(55, ErrorMessage = "Este campo deve conter entre 3 a 55 caracteres")]
        public string dscconta { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(10, ErrorMessage = "Este campo deve conter entre 10 a 20 caracteres")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter entre 10 a 20 caracteres")]
        public string datacompra { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(10, ErrorMessage = "Este campo deve conter entre 10 a 20 caracteres")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter entre 10 a 20 caracteres")]
        public string datavencimento { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double valororiginal { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string datapagamento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int diasatraso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double percmultaatraso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double valormultaatraso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double percjurosdia { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double valorjurosdia { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double valorcorrigido { get; set; }


    }

}

