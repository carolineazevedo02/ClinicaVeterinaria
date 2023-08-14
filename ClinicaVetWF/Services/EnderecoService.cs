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
    internal class EnderecoService
    {
        private readonly Context dbContext;
        public class Estado
        {
            public string Nome { get; set; }
            public string Sigla { get; set; }
        }

        public EnderecoService(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public int CadastrarEndereco(string rua, string cidade, string cep, string referencia, string estado)
        {
            try
            {
                // Criar um novo objeto endereco com os dados fornecidos.
                var novoEndereco = new endereco
                {
                    endereco1 = rua,
                    cidade = cidade,
                    cep = cep,
                    referencia = referencia,
                    estado = estado,
                    status = true
                };

                // Adiciona o endereco ao contexto e salva as mudanças no banco de dados.
                dbContext.endereco.Add(novoEndereco);
                dbContext.SaveChanges();

                return novoEndereco.id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        public List<Estado> GetEstadosList()
        {
            List<Estado> estados = new List<Estado>
{
                new Estado { Nome = "Acre", Sigla = "AC" },
                new Estado { Nome = "Alagoas", Sigla = "AL" },
                new Estado { Nome = "Amapá", Sigla = "AP" },
                new Estado { Nome = "Amazonas", Sigla = "AM" },
                new Estado { Nome = "Bahia", Sigla = "BA" },
                new Estado { Nome = "Ceará", Sigla = "CE" },
                new Estado { Nome = "Distrito Federal", Sigla = "DF" },
                new Estado { Nome = "Espírito Santo", Sigla = "ES" },
                new Estado { Nome = "Goiás", Sigla = "GO" },
                new Estado { Nome = "Maranhão", Sigla = "MA" },
                new Estado { Nome = "Mato Grosso", Sigla = "MT" },
                new Estado { Nome = "Mato Grosso do Sul", Sigla = "MS" },
                new Estado { Nome = "Minas Gerais", Sigla = "MG" },
                new Estado { Nome = "Pará", Sigla = "PA" },
                new Estado { Nome = "Paraíba", Sigla = "PB" },
                new Estado { Nome = "Paraná", Sigla = "PR" },
                new Estado { Nome = "Pernambuco", Sigla = "PE" },
                new Estado { Nome = "Piauí", Sigla = "PI" },
                new Estado { Nome = "Rio de Janeiro", Sigla = "RJ" },
                new Estado { Nome = "Rio Grande do Norte", Sigla = "RN" },
                new Estado { Nome = "Rio Grande do Sul", Sigla = "RS" },
                new Estado { Nome = "Rondônia", Sigla = "RO" },
                new Estado { Nome = "Roraima", Sigla = "RR" },
                new Estado { Nome = "Santa Catarina", Sigla = "SC" },
                new Estado { Nome = "São Paulo", Sigla = "SP" },
                new Estado { Nome = "Sergipe", Sigla = "SE" },
                new Estado { Nome = "Tocantins", Sigla = "TO" }
            };
            return estados;
        }

    }
}
