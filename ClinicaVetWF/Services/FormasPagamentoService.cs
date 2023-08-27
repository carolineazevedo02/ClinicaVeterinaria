using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVetWF.Services
{
    internal class FormasPagamentoService
    {
        private readonly Context dbContext;
        public FormasPagamentoService(Context context)
        {
            this.dbContext = context;
        }

        public List<formas_pagamento> BuscarFormasPagamento()
        {
            return this.dbContext.formas_pagamento.ToList();    
        }
    }
}
