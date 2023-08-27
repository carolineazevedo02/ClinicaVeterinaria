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
    internal class ProdutoService
    {
        private readonly Context dbContext;

        public ProdutoService(Context context)
        {
            dbContext = context;
        }

        public void CadastrarProduto(produto produto)
        {
            try
            {
                dbContext.produto.Add(produto);
                dbContext.SaveChanges();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (System.Data.Entity.Core.EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarProduto(produto produto)
        {
            dbContext.produto.AddOrUpdate(produto);
            dbContext.SaveChanges();
        }

        public void ExcluirProduto(int produtoId)
        {
            var produto = dbContext.produto.Find(produtoId);
            if (produto != null)
            {
                dbContext.produto.Remove(produto);
                dbContext.SaveChanges();
            }
        }

        public List<produto> BuscarProdutos()
        {
            var query = from produto in dbContext.produto
                        where produto.status
                        select new produto
                        {
                            nome = produto.nome,
                            codigo = produto.codigo,
                            preco = produto.preco,
                            status = produto.status
                        };
                       
            return dbContext.produto.ToList();
        }

        public List<produto> BuscarProduto(int id)
        {
            try
            {
                var query = from produto in dbContext.produto
                            where produto.id == id 
                            where produto.status
                            select produto;
                List<produto> resultados = query.ToList();

                return resultados;
            }
            catch (Exception ex)
            {

            }
            return null;

        }

        public List<produto> ProdutosFiltrados(bool codigo, bool id, bool descricao, string parametro)
        {
            var query = dbContext.produto.AsQueryable();

            if (codigo)
            {
                query = query.Where(p => p.codigo.Contains(parametro));
            }

            if (descricao)
            {
                query = query.Where(p => p.nome.Contains(parametro));
            }

            if (id)
            {
                if (int.TryParse(parametro, out int idFiltro))
                {
                    query = query.Where(p => p.id == idFiltro);
                }
            }

            List<produto> resultados = query.ToList();
            return resultados.ToList();
        }
    }
}
