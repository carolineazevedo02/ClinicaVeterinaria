namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("consulta")]
    public partial class consulta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public consulta()
        {
            exame = new HashSet<exame>();
            medicacao = new HashSet<medicacao>();
        }

        public int id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime data { get; set; }

        [Column(TypeName = "text")]
        public string observacoes { get; set; }

        public int id_animal { get; set; }

        public int id_cliente { get; set; }

        public int id_funcionario { get; set; }

        public int? id_venda { get; set; }
        public int? id_servico { get; set; }

        public bool status { get; set; }

        public virtual Servicos servico { get; set; } 

        public virtual animal animal { get; set; }

        public virtual funcionario funcionario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exame> exame { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medicacao> medicacao { get; set; }
    }
}
