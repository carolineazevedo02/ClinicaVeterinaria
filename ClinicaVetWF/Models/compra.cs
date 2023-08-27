using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVetWF.Models
{
    [Table("compra")]
    public partial class compra
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public int Quantidade { get; set; }

        [ForeignKey("Fornecedor")]
        public int IdFornecedor { get; set; }

        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Cancelada { get; set; }
        public virtual fornecedor Fornecedor { get; set; }
        public virtual produto Produto { get; set; }
    }
}
