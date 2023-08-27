using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVetWF.Services
{
    internal class ItemVendaService
    {
        private readonly Context dbContext;
        public ItemVendaService(Context dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CadastrarItemVenda(item_venda item)
        {
            dbContext.item_venda.Add(item);
            dbContext.SaveChanges();
        }
    }
}
