using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVetWF.Services
{
    internal class VendaService
    {
        private readonly Context dbContext;
        public VendaService(Context dbContext)
        {
            this.dbContext = dbContext;
        }
        public int CadastrarVenda(venda novaVenda)
        {
            novaVenda.status = true;
            dbContext.venda.Add(novaVenda);
            dbContext.SaveChanges();
            return novaVenda.id;
        }

        public void ExcluirVenda(int vendaId)
        {
            var vendaParaExcluir = dbContext.venda.Find(vendaId);

            if (vendaParaExcluir != null)
            {     

                dbContext.venda.Remove(vendaParaExcluir);
                dbContext.SaveChanges();
            }
        }
    }
}
