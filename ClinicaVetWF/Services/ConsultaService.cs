using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicaVetWF.Services.AnimalService;

namespace ClinicaVetWF.Services
{
    internal class ConsultaService
    {
        private readonly Context dbContext;

        public ConsultaService(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CadastrarConsulta(consulta consulta)
        {
            try
            {
                consulta.status = true;
                dbContext.consulta.Add(consulta);
                dbContext.SaveChanges();

                MessageBox.Show("Consulta cadastrada com sucesso!");
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<ConsultaInfo> BuscarConsultas()
        {
            try
            {
                var query = from consulta in dbContext.consulta
                            join cliente in dbContext.cliente on consulta.id_cliente equals cliente.id
                            join animal in dbContext.animal on consulta.id_animal equals animal.id

                            select new ConsultaInfo
                            {
                                IdConsulta = consulta.id,
                                TutorNome = cliente.nome,
                                AnimalNome = animal.nome,
                                DataConsulta = (DateTime)consulta.data,
                                Observacoes = consulta.observacoes,
                            };

                List<ConsultaInfo> resultados = query.ToList();

                return resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return null;
        }

        public List<ConsultaInfo> BuscarConsultasDoDia(int idConsulta = 0, bool edicao = false)
        {
            try
            {
                DateTime dataAtual = DateTime.Today;

                var query = from consulta in dbContext.consulta
                            join cliente in dbContext.cliente on consulta.id_cliente equals cliente.id
                            join animal in dbContext.animal on consulta.id_animal equals animal.id
                            join funcionario in dbContext.funcionario on consulta.id_funcionario equals funcionario.id
                            join Servicos in dbContext.Servicos on consulta.id_servico equals Servicos.ID into serviceGroup
                            from Servicos in serviceGroup.DefaultIfEmpty()
                            where consulta.status
                            select new ConsultaInfo
                            {
                                IdConsulta = consulta.id,
                                IdTutor = cliente.id,
                                IdAnimal = animal.id,
                                TutorNome = cliente.nome,
                                AnimalNome = animal.nome,
                                FuncionarioNome = funcionario.nome,
                                DescricaoServico = Servicos.Descricao,
                                DataConsulta = (DateTime)consulta.data,
                                Observacoes = consulta.observacoes,
                                Valor = Servicos != null ? Servicos.Valor : 0,
                                pago = consulta.id_venda != null
                            };

                if (idConsulta != 0)
                {
                    query = query.Where(c => c.IdConsulta == idConsulta);
                }

                List<ConsultaInfo> todasAsConsultas = query.ToList();
                List<ConsultaInfo> consultasDoDia = new List<ConsultaInfo>();
                consultasDoDia = todasAsConsultas;
                if (!edicao)
                {
                    consultasDoDia = todasAsConsultas.Where(c => c.DataConsulta.Date == dataAtual).ToList();

                }

                return consultasDoDia;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return null;
        }

        public void ExcluirConsulta(int idConsulta)
        {
            try
            {
                var consulta = dbContext.consulta.FirstOrDefault(a => a.id == idConsulta);

                if (consulta != null)
                {
                    consulta.status = false;
                    dbContext.SaveChanges();
                }

            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public consulta BuscarConsulta(int idConsulta)
        {
            try
            {
                return dbContext.consulta.FirstOrDefault(a => a.id == idConsulta);
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void AtualizarConsulta(consulta consulta)
        {
            try
            {
                dbContext.consulta.AddOrUpdate(consulta);
                dbContext.SaveChanges();
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class ConsultaInfo
        {
            public int IdConsulta { get; set; }
            public int IdTutor { get; set; }
            public int IdAnimal { get; set; }
            public string TutorNome { get; set; }
            public string FuncionarioNome { get; set; }
            public string AnimalNome { get; set; }
            public string DescricaoServico { get; set; }
            public DateTime DataConsulta { get; set; }
            public string Observacoes { get; set; }
            public decimal? Valor { get; set; }
            public bool pago { get; set; }
        }
    }
}
