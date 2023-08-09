using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ClinicaVetWF.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<animal> animal { get; set; }
        public virtual DbSet<cargo> cargo { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<consulta> consulta { get; set; }
        public virtual DbSet<endereco> endereco { get; set; }
        public virtual DbSet<especie> especie { get; set; }
        public virtual DbSet<exame> exame { get; set; }
        public virtual DbSet<formas_pagamento> formas_pagamento { get; set; }
        public virtual DbSet<funcionario> funcionario { get; set; }
        public virtual DbSet<item_venda> item_venda { get; set; }
        public virtual DbSet<medicacao> medicacao { get; set; }
        public virtual DbSet<pagamentos> pagamentos { get; set; }
        public virtual DbSet<pagamentos_parcelados> pagamentos_parcelados { get; set; }
        public virtual DbSet<produto> produto { get; set; }
        public virtual DbSet<venda> venda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<animal>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<animal>()
                .Property(e => e.observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<animal>()
                .HasMany(e => e.consulta)
                .WithRequired(e => e.animal)
                .HasForeignKey(e => e.id_animal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<cargo>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.funcionario)
                .WithRequired(e => e.cargo)
                .HasForeignKey(e => e.id_cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.cpf)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.animal)
                .WithRequired(e => e.cliente)
                .HasForeignKey(e => e.id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<consulta>()
                .Property(e => e.observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<consulta>()
                .HasMany(e => e.exame)
                .WithRequired(e => e.consulta)
                .HasForeignKey(e => e.id_consulta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<consulta>()
                .HasMany(e => e.medicacao)
                .WithRequired(e => e.consulta)
                .HasForeignKey(e => e.id_consulta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.endereco1)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.cidade)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.cep)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .HasMany(e => e.cliente)
                .WithRequired(e => e.endereco)
                .HasForeignKey(e => e.id_endereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<especie>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<especie>()
                .HasMany(e => e.animal)
                .WithRequired(e => e.especie)
                .HasForeignKey(e => e.id_especie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<exame>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<exame>()
                .Property(e => e.resultado)
                .IsUnicode(false);

            modelBuilder.Entity<formas_pagamento>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<formas_pagamento>()
                .Property(e => e.descricao)
                .IsUnicode(false);

            modelBuilder.Entity<formas_pagamento>()
                .HasMany(e => e.pagamentos)
                .WithRequired(e => e.formas_pagamento)
                .HasForeignKey(e => e.id_forma_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<funcionario>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<funcionario>()
                .Property(e => e.salario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<funcionario>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<funcionario>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<funcionario>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<funcionario>()
                .HasMany(e => e.consulta)
                .WithRequired(e => e.funcionario)
                .HasForeignKey(e => e.id_funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<item_venda>()
                .Property(e => e.valor_unitario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<medicacao>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<medicacao>()
                .Property(e => e.dosagem)
                .IsUnicode(false);

            modelBuilder.Entity<medicacao>()
                .Property(e => e.lote)
                .IsUnicode(false);

            modelBuilder.Entity<pagamentos>()
                .Property(e => e.valor)
                .HasPrecision(10, 2);

            modelBuilder.Entity<pagamentos>()
                .HasMany(e => e.pagamentos_parcelados)
                .WithRequired(e => e.pagamentos)
                .HasForeignKey(e => e.id_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pagamentos_parcelados>()
                .Property(e => e.valor_parcela)
                .HasPrecision(10, 2);

            modelBuilder.Entity<produto>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .Property(e => e.preco)
                .HasPrecision(10, 2);

            modelBuilder.Entity<produto>()
                .Property(e => e.preco_custo)
                .HasPrecision(10, 2);

            modelBuilder.Entity<produto>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .HasMany(e => e.item_venda)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda>()
                .Property(e => e.valor_total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<venda>()
                .Property(e => e.desconto)
                .HasPrecision(10, 2);

            modelBuilder.Entity<venda>()
                .HasMany(e => e.item_venda)
                .WithRequired(e => e.venda)
                .HasForeignKey(e => e.id_venda)
                .WillCascadeOnDelete(false);
        }
    }
}
