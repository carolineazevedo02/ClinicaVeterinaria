namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("endereco")]
    public partial class endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public endereco()
        {
            cliente = new HashSet<cliente>();
        }

        public int id { get; set; }

        [Column("endereco")]
        [Required]
        [StringLength(100)]
        public string endereco1 { get; set; }

        [Required]
        [StringLength(30)]
        public string estado { get; set; }

        [Required]
        [StringLength(30)]
        public string cidade { get; set; }

        [Required]
        [StringLength(8)]
        public string cep { get; set; }

        [Column(TypeName = "text")]
        public string referencia { get; set; }

        public bool status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cliente> cliente { get; set; }
    }
}
