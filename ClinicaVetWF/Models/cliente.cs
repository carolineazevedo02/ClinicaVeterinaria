namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cliente")]
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            animal = new HashSet<animal>();
        }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(54)]
        public string nome { get; set; }

        public int id_endereco { get; set; }

        [Required]
        [StringLength(11)]
        public string cpf { get; set; }     
        
        [Required]
        [StringLength(20)]
        public string rg { get; set; }        
        
        [Required]
        [StringLength(15)]
        public string telefone { get; set; }        
        
        [Required]
        [StringLength(100)]
        public string email { get; set; }

        public bool status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<animal> animal { get; set; }

        public virtual endereco endereco { get; set; }
    }
}
