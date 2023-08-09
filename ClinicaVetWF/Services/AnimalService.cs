using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF.Services
{

    internal class AnimalService
    {
        private readonly db_clinicaEntities1 dbContext;
        public AnimalService(db_clinicaEntities1 dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CadastrarAnimal(int idTutor, int idEspecie, string nome, string cor, string codIdentificacao, DateTime dataNascimento, string observacoes)
        {
            try
            {
                var novoAnimal = new animal
                {
                    id_cliente = idTutor,
                    id_especie = idEspecie,
                    nome = nome,
                    cor = cor,
                    numero_identificacao = codIdentificacao,
                    data_nascimento = dataNascimento,
                    observacoes = observacoes,
                    status = true
                };

                dbContext.animal.Add(novoAnimal);
                dbContext.SaveChanges();

                MessageBox.Show("Pet cadastrado com sucesso!");
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<especie> BuscarEspecies()
        {
            List<especie> lista = dbContext.especie.ToList();

            return lista;
        }

        public List<AnimalInfo> BuscarAnimais()
        {
            var query = from animal in dbContext.animal
                        join cliente in dbContext.cliente on animal.id_cliente equals cliente.id
                        join especie in dbContext.especie on animal.id_especie equals especie.id
                        where animal.status

                        select new AnimalInfo
                        {
                            IdAnimal = animal.id,
                            TutorNome = cliente.nome,
                            EspecieNome = especie.nome,
                            AnimalNome = animal.nome,
                            DataNascimento = animal.data_nascimento,
                            Cor = animal.cor,
                            Observacoes = animal.observacoes,
                            NumeroIdentificacao = animal.numero_identificacao
                        };

            List<AnimalInfo> resultados = query.ToList();

            return resultados;

        }

        public List<AnimalInfo> BuscarAnimal(int id)
        {
            var query = from animal in dbContext.animal
                        join cliente in dbContext.cliente on animal.id_cliente equals cliente.id
                        join especie in dbContext.especie on animal.id_especie equals especie.id
                        where animal.status where animal.id == id

                        select new AnimalInfo
                        {
                            IdAnimal = animal.id,
                            TutorNome = cliente.nome,
                            EspecieNome = especie.nome,
                            AnimalNome = animal.nome,
                            DataNascimento = animal.data_nascimento,
                            Cor = animal.cor,
                            Observacoes = animal.observacoes,
                            NumeroIdentificacao = animal.numero_identificacao
                        };

            List<AnimalInfo> resultados = query.ToList();

            return resultados;

        }

        public void ExcluirAnimal(int idAnimal)
        {
            try
            {
                var animal = dbContext.animal.FirstOrDefault(a => a.id == idAnimal);

                if (animal != null)
                {
                    animal.status = false;
                    dbContext.SaveChanges();
                }

            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public class AnimalInfo
        {
            public int IdAnimal { get; set; }
            public string TutorNome { get; set; }
            public string EspecieNome { get; set; }
            public string AnimalNome { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Observacoes { get; set; }
            public string Cor { get; set; }
            public string NumeroIdentificacao { get; set; }
        }
    }
}
