namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pagamentos_parcelados
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? numero_parcelas { get; set; }

        public decimal? valor_parcela { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vencimento { get; set; }

        public int id_pagamento { get; set; }

        public bool status { get; set; }

        public virtual pagamentos pagamentos { get; set; }
    }
}
