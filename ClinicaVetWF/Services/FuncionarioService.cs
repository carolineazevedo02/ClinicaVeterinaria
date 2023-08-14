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
        private readonly Context dbContext; 

        public FuncionarioService(Context dbContext) 
        {
            this.dbContext = dbContext;
        }

        public int ValidarLogin(string login, string senha)
        {
            var funcionario = dbContext.funcionario.FirstOrDefault(f => f.login == login);

            if (funcionario != null && funcionario.senha == senha)
            {
                return funcionario.id; 
            }

            return 0; 
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
