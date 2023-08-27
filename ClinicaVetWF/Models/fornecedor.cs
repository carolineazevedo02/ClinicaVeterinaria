namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fornecedor")]
    public partial class fornecedor
    {
        public fornecedor()
        {
            produtos = new HashSet<produto>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(100)]
        public string Endereco { get; set; }

        [StringLength(50)]
        public string Telefone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
        public DateTime dataCadastro { get; set; }

        // Indicar a relação de um fornecedor para muitos produtos
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto> produtos { get; set; }
    }
}
