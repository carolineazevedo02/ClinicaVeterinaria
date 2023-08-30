using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace ClinicaVetWF.Services
{
    public class RelatoriosService
    {
        private readonly Context dbContext;

        public RelatoriosService(Context context) {

            dbContext = context;
        }

       
       public List<cliente> GerarRelatorioCliente(string dataInicial, string dataFinal)
        {
            DateTime dataInicio;
            DateTime dataFim;
            DateTime.TryParse(dataInicial, out dataInicio);
            DateTime.TryParse(dataFinal, out dataFim);

            List<cliente> clientesNoIntervalo = dbContext.cliente
                .Where(c => c.dataCadastro >= dataInicio && c.dataCadastro <= dataFim)
                .ToList();

            return clientesNoIntervalo;
       }

        public List<fornecedor> GerarRelatorioFornecedor(string dataInicial, string dataFinal)
        {
            DateTime dataInicio;
            DateTime dataFim;
            DateTime.TryParse(dataInicial, out dataInicio);
            DateTime.TryParse(dataFinal, out dataFim);

            List<fornecedor> fornecedoresNoIntervalo = dbContext.fornecedor
                .Where(c => c.dataCadastro >= dataInicio && c.dataCadastro <= dataFim)
                .ToList();

            return fornecedoresNoIntervalo;
        }

        public List<compra> GerarRelatorioCompras(string dataInicial, string dataFinal)
        {
            DateTime dataInicio;
            DateTime dataFim;
            DateTime.TryParse(dataInicial, out dataInicio);
            DateTime.TryParse(dataFinal, out dataFim);

            List<compra> comprasNoIntervalo = dbContext.compra
                .Where(c => c.DataCompra >= dataInicio && c.DataCompra <= dataFim)
                .ToList();

            return comprasNoIntervalo;
        }

        public List<VendaRelatorio> GerarRelatorioVendas(string dataInicial, string dataFinal, bool canceladas, bool listagem)
        {
            DateTime dataInicio;
            DateTime dataFim;
            DateTime.TryParse(dataInicial, out dataInicio);
            DateTime.TryParse(dataFinal, out dataFim);


            var query = from venda in dbContext.venda
                        join funcionario in dbContext.funcionario on venda.id_funcionario equals funcionario.id
                        join pagamentos in dbContext.pagamentos on venda.id equals pagamentos.id_venda
                        join formasPagamento in dbContext.formas_pagamento on pagamentos.id_forma_pagamento
                        equals formasPagamento.id
                        where venda.data_venda >= dataInicio && venda.data_venda <= dataFim
                        select new VendaRelatorio
                        {
                            Id = venda.id,
                            FuncionarioNome = funcionario.nome,
                            Valor = venda.valor_total,
                            TipoPagamento = formasPagamento.descricao,
                            DataVenda = venda.data_venda,
                            Status = venda.status
                        };


            List<VendaRelatorio> listaVendas = new List<VendaRelatorio>();
            if (listagem)
            {
                return query.ToList();
            }

            if (canceladas)
            {
                query = query.Where(p => p.Status == false);
            }
            else
            {
                query = query.Where(p => p.Status == true);
            }

            listaVendas = query.ToList();
            return listaVendas;
        }

        public List<ServicosRelatorio> GerarRelatorioServicos(string dataInicial, string dataFinal)
        {
            DateTime dataInicio;
            DateTime dataFim;
            DateTime.TryParse(dataInicial, out dataInicio);
            DateTime.TryParse(dataFinal, out dataFim);


            var query = from consulta in dbContext.consulta
                        join funcionarioAgendou in dbContext.funcionario on consulta.id_funcionario equals funcionarioAgendou.id
                        join servico in dbContext.Servicos on consulta.id equals servico.ID
                        join funcionarioExecutara in dbContext.funcionario on servico.FuncionarioID equals funcionarioExecutara.id
                        join cliente in dbContext.cliente on consulta.id_cliente equals cliente.id
                        select new ServicosRelatorio
                        {
                            Id = consulta.id,
                            FuncionarioNomeAgendou = funcionarioAgendou.nome,
                            FuncionarioNomeExecutara = funcionarioExecutara.nome,
                            DescricaoServico = servico.Descricao,
                            Cancelado = consulta.status,
                            Data = consulta.data,
                            ClienteNome = cliente.nome,
                            
                        };




            List<ServicosRelatorio> servicosRelatorios = new List<ServicosRelatorio>();
            servicosRelatorios = query.ToList();
            return servicosRelatorios;
        }

        public class VendaRelatorio
        {
            public int Id { get; set; }
            public string FuncionarioNome { get; set; }
            public DateTime DataVenda { get; set; }
            public string TipoPagamento { get; set; }
            public decimal Valor { get; set; }
            public bool Status { get; set; }

        }

        public class ServicosRelatorio
        {
            public int Id { get; set; }
            public string FuncionarioNomeAgendou { get; set; }
            public string FuncionarioNomeExecutara { get; set; }
            public string ClienteNome { get; set; }
            public DateTime Data { get; set; }
            public string DescricaoServico { get; set; }
            public bool Cancelado { get; set; }

        }
    }
}
