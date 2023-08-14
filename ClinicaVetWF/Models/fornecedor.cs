using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVetWF.Models
{
    public class fornecedor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(14)] // CNPJ possui 14 caracteres
        public string CNPJ { get; set; }

        [MaxLength(100)]
        public string Endereco { get; set; }

        [MaxLength(50)]
        public string Telefone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
    }
}
