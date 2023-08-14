using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF.Services
{
    internal class ServicoService
    {
        private readonly Context dbContext;
        public ServicoService(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CadastrarServico(string descricao, decimal valor, int idTipoProfissional, string medidaReferencia)
        {
            try
            {
                var novoServico = new Servicos
                {
                    Descricao = descricao,
                    Valor = valor,
                    TipoProfissionalID = idTipoProfissional,
                    MedidaReferencia = medidaReferencia,
         
                };
                dbContext.Servicos.Add(novoServico);
                dbContext.SaveChanges();

                MessageBox.Show("Serviço cadastrado com sucesso!");
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Servicos> BuscarServicos()
        {
            try
            {
                return dbContext.Servicos.ToList();
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
    }
}
