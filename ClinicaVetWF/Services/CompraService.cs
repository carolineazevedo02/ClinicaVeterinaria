using ClinicaVetWF.Models;
using ClinicaVetWF.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVetWF.Services
{
    internal class CompraService
    {
        private readonly Context dbContext;
        public CompraService(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AdicionarCompra(compra novaCompra)
        {
            try
            {
                using (var context = new Context())
                {
                    context.compra.Add(novaCompra);
                    context.SaveChanges();
                    MessageBox.Show("Compra cadastrada com sucesso!");
                }
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarCompra(compra compraEditada)
        {
            using (var context = new Context())
            {
                var compraExistente = context.compra.Find(compraEditada.Id);

                if (compraExistente != null)
                {
                    context.Entry(compraExistente).CurrentValues.SetValues(compraEditada);
                    context.SaveChanges();
                }
            }
        }

        public void ExcluirCompra(int idCompra)
        {
            using (var context = new Context())
            {
                var compraExistente = context.compra.Find(idCompra);

                if (compraExistente != null)
                {
                    compraExistente.Cancelada = true;
                    context.SaveChanges();
                }
            }
        }

        public List<compra> BuscarCompra(int idCompra)
        {
            try
            {
                var query = from compra in dbContext.compra
                            where compra.Id == idCompra
                            where compra.Cancelada == false
                            select compra;
                List<compra> resultados = query.ToList();

                return resultados;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public List<compra> BuscarCompras()
        {

            var query = dbContext.compra.AsQueryable();
            query = query.Where(p => p.Cancelada == false);

            return query.ToList();
        }

    }
}
