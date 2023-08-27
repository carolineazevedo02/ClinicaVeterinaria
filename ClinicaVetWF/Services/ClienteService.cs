using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClinicaVetWF.Services.AnimalService;

namespace ClinicaVetWF.Services
{
    internal class ClienteService
    {
        private readonly Context dbContext;

        public ClienteService(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CadastrarCliente(int idEndereco, string nome, string telefone, string email, string cpf, string rg, DateTime dataCriacao)
        {
            try
            {
                // Verifica se o CPF já existe no banco de dados.
                if (VerificarExistenciaCPF(cpf))
                {
                    MessageBox.Show("CPF já cadastrado no sistema.");
                    return; 
                }
                var novoCliente = new cliente
                {
                    rg = rg,
                    id = 0,
                    nome = nome,
                    id_endereco = idEndereco,
                    cpf = cpf.Replace(",", "").Replace("-", ""),
                    telefone = telefone,
                    email = email,
                    status = true,
                    dataCadastro = dataCriacao,
                   
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

        public void ExcluirCliente(int idCliente)
        {
            try
            {
                var cliente = dbContext.cliente.FirstOrDefault(a => a.id == idCliente);

                if (cliente != null)
                {
                    cliente.status = false;
                    dbContext.SaveChanges();
                }

            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarCliente(int idCliente, int idEndereco, string nome, string telefone, string email, string cpf, string rg)
        {
            try
            {
                var cliente = dbContext.cliente.FirstOrDefault(a => a.id == idCliente);

                if (cliente != null)
                {
                    cliente.id_endereco = idEndereco;
                    cliente.cpf = cpf.Replace(",", "").Replace("-", "");
                    cliente.email = email;
                    cliente.telefone = telefone;
                    cliente.nome = nome;
                    cliente.rg = rg;
                    dbContext.SaveChanges();
                }

            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<ClienteInfo> BuscarCliente(int id)
        {
            var query = from cliente in dbContext.cliente
                        join endereco in dbContext.endereco on cliente.id_endereco equals endereco.id
                        where cliente.id == id

                        select new ClienteInfo
                        {
                            IdCliente = cliente.id,
                            ClienteNome = cliente.nome,
                            ClienteTelefone = cliente.telefone,
                            ClienteCPF = cliente.cpf,
                            ClienteRg = cliente.rg,
                            ClienteEmail = cliente.email,
                            ClienteRua = endereco.endereco1,
                            ClienteCEP = endereco.cep,
                            ClienteCidade = endereco.cidade,
                            ClienteEstado = endereco.estado,
                            ClienteReferencia = endereco.referencia
                        };

            List<ClienteInfo> resultados = query.ToList();

            return resultados;

        }
        public bool VerificarExistenciaCPF(string cpf)
        {
            cpf = cpf.Replace(",", "").Replace("-", "");

            var clienteExistente = dbContext.cliente.FirstOrDefault(c => c.cpf == cpf);

            return clienteExistente != null;
        }
        public class ClienteInfo
        {
            public int IdCliente { get; set; }
            public string ClienteNome { get; set; }
            public string ClienteCPF { get; set; }
            public string ClienteRg { get; set; }
            public string ClienteTelefone { get; set; }
            public string ClienteEmail { get; set; }
            public string ClienteRua { get; set; }
            public string ClienteCidade { get; set; }
            public string ClienteEstado { get; set; }
            public string ClienteCEP { get; set; }
            public string ClienteReferencia { get; set; }
           
        }
    }
}
