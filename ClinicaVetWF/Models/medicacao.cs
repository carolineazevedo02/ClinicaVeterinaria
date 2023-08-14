namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medicacao")]
    public partial class medicacao
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [StringLength(100)]
        public string dosagem { get; set; }

        public int id_consulta { get; set; }

        [Required]
        [StringLength(54)]
        public string lote { get; set; }

        [Column(TypeName = "date")]
        public DateTime validade { get; set; }

        public bool status { get; set; }

        public virtual consulta consulta { get; set; }
    }
}
