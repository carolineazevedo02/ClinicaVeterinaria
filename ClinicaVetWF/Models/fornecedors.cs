namespace ClinicaVetWF.Utils
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class fornecedors
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string CNPJ { get; set; }

        [StringLength(15)]
        public string Telefone { get; set; }

        [StringLength(100)]
        public string Endereco { get; set; }
    }
}
