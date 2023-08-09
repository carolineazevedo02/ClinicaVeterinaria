namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class item_venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int quantidade { get; set; }

        public decimal valor_unitario { get; set; }

        public int id_produto { get; set; }

        public int id_venda { get; set; }

        public virtual produto produto { get; set; }

        public virtual venda venda { get; set; }
    }
}
