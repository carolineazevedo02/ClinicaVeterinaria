using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try {

                fornecedor.dataCadastro = DateTime.Now;
                dbContext.fornecedor.Add(fornecedor);
                dbContext.SaveChanges();
                MessageBox.Show("Fornecedor cadastrado com sucesso!");
            }
            catch(System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarFornecedor(fornecedor fornecedor)
        {
            try
            {
                dbContext.fornecedor.AddOrUpdate(fornecedor);
                dbContext.SaveChanges();
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<fornecedor> BuscarFornecedores()
        {
            return dbContext.fornecedor.ToList();
            
        }

        public List<fornecedor> BuscarFornecedor(int id)
        {
            try
            {
                var query = from fornecedor in dbContext.fornecedor
                            where fornecedor.Id == id
                            select fornecedor;
                List<fornecedor> resultados = query.ToList();

                return resultados;
            }
            catch (Exception ex)
            {

            }
            return null;

        }
    }
}
