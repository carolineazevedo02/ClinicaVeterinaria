namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Servicos
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

        public decimal? Valor { get; set; }

        public int? TipoProfissionalID { get; set; }

        [StringLength(50)]
        public string MedidaReferencia { get; set; }

        public virtual TiposProfissionais TiposProfissionais { get; set; }
    }
}
