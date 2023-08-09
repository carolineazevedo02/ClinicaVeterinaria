namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("funcionario")]
    public partial class funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public funcionario()
        {
            consulta = new HashSet<consulta>();
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int id_cargo { get; set; }

        [Required]
        [StringLength(54)]
        public string nome { get; set; }

        public decimal salario { get; set; }

        [Required]
        [StringLength(64)]
        public string email { get; set; }

        [Required]
        [StringLength(54)]
        public string login { get; set; }

        [Required]
        [StringLength(54)]
        public string senha { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_criacao { get; set; }

        public bool status { get; set; }

        public virtual cargo cargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consulta> consulta { get; set; }
    }
}
