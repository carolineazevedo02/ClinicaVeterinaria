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
    internal class ClienteService
    {
        private readonly db_clinicaEntities1 dbContext;

        public ClienteService(db_clinicaEntities1 dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CadastrarCliente(int idEndereco, string nome, string telefone, string email, string cpf, string rg, DateTime dataCriacao)
        {
            try
            {
                // Criar um novo objeto Cliente com os dados fornecidos.
                var novoCliente = new cliente
                {
                    id_endereco = idEndereco,
                    nome = nome,
                    telefone = telefone,
                    email = email,
                    cpf = cpf.Replace(",", "").Replace("-", ""),
                    rg = rg,
                    status = true
                };

                // Adiciona o Cliente ao contexto e salva as mudanças no banco de dados.
                dbContext.cliente.Add(novoCliente);
                dbContext.SaveChanges();

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<cliente> BuscarTutores()
        {
            List<cliente> lista = dbContext.cliente.ToList();

            return lista;
        }

    }
}
