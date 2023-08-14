namespace ClinicaVetWF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pagamentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pagamentos()
        {
            pagamentos_parcelados = new HashSet<pagamentos_parcelados>();
        }

        public int id { get; set; }

        public decimal valor { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_pagamento { get; set; }

        public int id_forma_pagamento { get; set; }

        public bool parcelado { get; set; }

        public int? numero_parcelas { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vencimento { get; set; }

        public int id_venda { get; set; }

        public bool status { get; set; }

        public virtual formas_pagamento formas_pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pagamentos_parcelados> pagamentos_parcelados { get; set; }
    }
}
