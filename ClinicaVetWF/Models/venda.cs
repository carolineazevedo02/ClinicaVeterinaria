namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("venda")]
    public partial class venda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venda()
        {
            item_venda = new HashSet<item_venda>();
        }

        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_venda { get; set; }

        public decimal valor_total { get; set; }

        public int id_funcionario { get; set; }

        public decimal desconto { get; set; }

        public bool status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<item_venda> item_venda { get; set; }
    }
}
