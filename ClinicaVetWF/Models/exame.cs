namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("exame")]
    public partial class exame
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nome { get; set; }

        [Column(TypeName = "text")]
        public string resultado { get; set; }

        public int id_consulta { get; set; }

        public bool cancelado { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }
        public virtual consulta consulta { get; set; }
    }
}
