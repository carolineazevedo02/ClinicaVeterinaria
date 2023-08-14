using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
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

        public void CadastrarConsulta(int idCliente, int idAnimal, int idVenda, int idFuncionario,  string observacoes, DateTime dataConsulta)
        {
            try
            {
                var novaConsulta = new consulta
                {
                    id_cliente = idCliente,
                    id_animal = idAnimal,
                    id_funcionario = idFuncionario,
                    id_venda = null,
                    observacoes = observacoes,
                    data = dataConsulta,
                    status = true,

                };
                dbContext.consulta.Add(novaConsulta);
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

            }
            return null;
        }

        public class ConsultaInfo
        {
            public int IdConsulta { get; set; }
            public string TutorNome { get; set; }
            public string AnimalNome { get; set; }
            public DateTime DataConsulta { get; set; }
            public string Observacoes { get; set; }
            public double Valor { get; set; }
        }
    }
}
