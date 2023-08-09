using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using ClinicaVetWF.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF.Services
{
    internal class FuncionarioService
    {
        private readonly db_clinicaEntities1 dbContext; 

        public FuncionarioService(db_clinicaEntities1 dbContext) 
        {
            this.dbContext = dbContext;
        }

        public bool ValidarLogin(string login, string senha)
        {
            // Buscar funcionário com o login fornecido.
            var funcionario = dbContext.funcionario.FirstOrDefault(f => f.login == login);

            // Verificar se encontrou algum funcionário com o login fornecido e se a senha está correta.
            if (funcionario != null && funcionario.senha == senha)
            {
                return true; // Login válido.
            }

            return false; // Login inválido.
        }

        public void CadastrarFuncionario(int idCargo, string nome, string email, string login, string senha, DateTime dataCriacao)
        {
            try
            {
                // Criar um novo objeto Funcionario com os dados fornecidos.
                var novoFuncionario = new funcionario
                {
                    id_cargo = idCargo,
                    nome = nome,
                    email = email,
                    login = login,
                    senha = senha,
                    data_criacao = dataCriacao,
                    status = true
                };

                // Adicionar o funcionário ao contexto e salvar as mudanças no banco de dados.
                dbContext.funcionario.Add(novoFuncionario);
                dbContext.SaveChanges();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<cargo> BuscarCargos()
        {
            List<cargo> lista = dbContext.cargo.ToList();

            return lista;
        }
    }
}
