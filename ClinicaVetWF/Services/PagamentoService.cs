using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVetWF.Services
{
   
    internal class PagamentoService
    {
        private readonly Context dbContext;
        public PagamentoService(Context context) {
            this.dbContext = context;
        } 
        public void CadastrarPagamento(pagamentos novoPagamento)
        {
            dbContext.pagamentos.Add(novoPagamento);
            dbContext.SaveChanges();
        }

        public void CancelarPagamento(int pagamentoId)
        {
            var pagamento = dbContext.pagamentos.FirstOrDefault(p => p.id == pagamentoId);

            if (pagamento != null)
            {
                pagamento.status = false; 
                dbContext.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Pagamento não encontrado");
            }
        }
    }
}
