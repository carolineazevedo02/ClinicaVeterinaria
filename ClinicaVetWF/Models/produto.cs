using ClinicaVetWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("produto")]
public partial class produto
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public produto()
    {
        item_venda = new HashSet<item_venda>();
    }

    public int id { get; set; }

    [Required]
    [StringLength(50)]
    public string nome { get; set; }

    public decimal preco { get; set; }

    public decimal preco_custo { get; set; }

    public int quantidade { get; set; }

    [StringLength(255)]
    public string codigo { get; set; }

    public bool status { get; set; }

    // Adicione a chave estrangeira para a tabela "fornecedor"
    public int? fornecedorId { get; set; }

    [ForeignKey("fornecedorId")]
    public virtual fornecedor fornecedor { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<item_venda> item_venda { get; set; }
}
