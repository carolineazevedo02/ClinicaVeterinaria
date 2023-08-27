using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVetWF.Models
{
    public class FuncionarioPermissao
    {
        [Key]
        public int Id { get; set; }

        public bool PodeAcessarCliente { get; set; }
        public bool PodeAcessarClinica { get; set; }
        public bool PodeAcessarFornecedores { get; set; }
        public bool PodeAcessarProdutos { get; set; }
        public bool PodeAcessarRelatorios { get; set; }
        public bool PodeAcessarFuncionarios { get; set; }

        [ForeignKey("Funcionario")]
        public int FuncionarioId { get; set; }

        public virtual funcionario Funcionario { get; set; }
    }
}
