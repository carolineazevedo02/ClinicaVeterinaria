using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
        public List<VendaInfo> BuscarVendas()
        {
            var query = from venda in dbContext.venda
                        join funcionario in dbContext.funcionario on venda.id_funcionario equals funcionario.id
                        select new VendaInfo
                        {
                            Id = venda.id,
                            IdFucionario = funcionario.id,
                            FuncionarioNome = funcionario.nome,
                            DataVenda = venda.data_venda,
                            Valor = venda.valor_total,
                            status = venda.status,
                        };

            return query.ToList();
        }
        public void ExcluirVenda(int vendaId)
        {
            var vendaParaExcluir = dbContext.venda.Find(vendaId);

            if (vendaParaExcluir != null)
            {
                vendaParaExcluir.status = false;
                dbContext.venda.AddOrUpdate(vendaParaExcluir);
                dbContext.SaveChanges();
            }
        }

        public class VendaInfo
        {
            public int Id { get; set; }
            public int IdFucionario { get; set; }
            public string FuncionarioNome { get; set; }
            public DateTime DataVenda { get; set; }
            public decimal? Valor { get; set; }
            public bool status { get; set; }
        }
    }
}
