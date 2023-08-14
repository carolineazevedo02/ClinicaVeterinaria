using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVetWF.Services
{
    internal class FornecedorService
    {
        private readonly Context dbContext;

        public FornecedorService(Context context)
        {
            dbContext = context;
        }

        public void CadastrarFornecedor(fornecedor fornecedor)
        {
            dbContext.fornecedor.Add(fornecedor);
            dbContext.SaveChangesAsync();
        }

        public void EditarFornecedor(fornecedor fornecedor)
        {
            dbContext.fornecedor.AddOrUpdate(fornecedor);
            dbContext.SaveChangesAsync();
        }

        public void ExcluirFornecedor(int fornecedorId)
        {
            var fornecedor =  dbContext.fornecedor.Find(fornecedorId);
            if (fornecedor != null)
            {
                dbContext.fornecedor.Remove(fornecedor);
                dbContext.SaveChangesAsync();
            }
        }
    }
}
