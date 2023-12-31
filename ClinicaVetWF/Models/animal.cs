namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("animal")]
    public partial class animal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public animal()
        {
            consulta = new HashSet<consulta>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(54)]
        public string nome { get; set; }

        [Column(TypeName = "text")]
        public string observacoes { get; set; }

        public int id_especie { get; set; }

        public int id_cliente { get; set; }

        [StringLength(50)]
        public string cor { get; set; }

        [StringLength(50)]
        public string numero_identificacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_nascimento { get; set; }

        public bool status { get; set; }

        public virtual cliente cliente { get; set; }

        public virtual especie especie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consulta> consulta { get; set; }
    }
}
