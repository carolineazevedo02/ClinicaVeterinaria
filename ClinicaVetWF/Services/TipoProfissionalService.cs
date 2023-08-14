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
    internal class TipoProfissionalService
    {
        private readonly Context dbContext;
        public TipoProfissionalService(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CadastrarTipoProfissional(string descricao)
        {
            try
            {
                var novoTipoProfissional = new TiposProfissionais
                {
                    Nome = descricao,
                };

                dbContext.TiposProfissionais.Add(novoTipoProfissional);
                dbContext.SaveChanges();

                MessageBox.Show("Novo tipo de profissional cadastrado com sucesso!");
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<TiposProfissionais> BuscarTipoProfissional()
        {
            try
            {
                return dbContext.TiposProfissionais.ToList(); ;
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<TiposProfissionais>();
        }
    }
}
