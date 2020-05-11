using Microsoft.EntityFrameworkCore;
using Questor.Questao2.Library.Domain.Entities;
using Questor.Questao2.Library.Repository.Config;
using System;

namespace Questor.Questao2.Library.Contexto
{
    public class QuestorContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Lancamentos> Lancamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItens> PedidoItens { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public QuestorContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CatagoriaConfig());
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new LancamentosConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new PedidoItensConfig());
            modelBuilder.ApplyConfiguration(new ProdutoConfig());

            #region CATEGORIA
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria(){CategoriaId = 1, Nome = "OUTROS", Descricao = "OUTROS MATERIAIS"},
                new Categoria(){CategoriaId = 2, Nome = "PAPELARIA", Descricao = "MATERIAIS PARA PAPELARIA"}
            );
            #endregion
            #region CLIENTES
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente() { ClienteId = 1, Nome = "DOMINGOS ASSUNÇÃO" },
                new Cliente() { ClienteId = 2, Nome = "SANDRA CORDEIRO" },
                new Cliente() { ClienteId = 3, Nome = "MARCOS AZEVEDO" },
                new Cliente() { ClienteId = 4, Nome = "STEFANO GARCIA" },
                new Cliente() { ClienteId = 5, Nome = "ELENA GRANDE" },
                new Cliente() { ClienteId = 6, Nome = "LAIS CAROLINE" }
            );
            #endregion

            #region PRODUTOS
            modelBuilder.Entity<Produto>().HasData(
                new Produto() { ProdutoId = 1, Nome = "CANETA ESFEROGRÁFICA PRETA", Preco = Convert.ToDecimal(1.75), CategoriaId = 1 },
                new Produto() { ProdutoId = 2, Nome = "CANETA ESFEROGRÁFICA AZUL", Preco = Convert.ToDecimal(1.80), CategoriaId = 1 },
                new Produto() { ProdutoId = 3, Nome = "CANETA ESFEROGRÁFICA VERMELHA", Preco = Convert.ToDecimal(1.60), CategoriaId = 1 },
                new Produto() { ProdutoId = 4, Nome = "PAPEL A4 XAMEX 100 FOLHAS", Preco = Convert.ToDecimal(4.00), CategoriaId = 2 },
                new Produto() { ProdutoId = 5, Nome = "BORRACHA PRETA", Preco = Convert.ToDecimal(3.00), CategoriaId = 1 }
            );
            #endregion

            #region LANCAMENTOS
            modelBuilder.Entity<Lancamentos>().HasData(
                new Lancamentos() { LancamentoId = 1, ProdutoId = 1, Observacao = "", Quantidade = 800, DataLancamento = Convert.ToDateTime("2020-01-10") },
                new Lancamentos() { LancamentoId = 2, ProdutoId = 5, Observacao = "", Quantidade = 600, DataLancamento = Convert.ToDateTime("2020-01-10") },
                new Lancamentos() { LancamentoId = 3, ProdutoId = 4, Observacao = "", Quantidade = 100, DataLancamento = Convert.ToDateTime("2020-01-10") },
                new Lancamentos() { LancamentoId = 4, ProdutoId = 3, Observacao = "", Quantidade = 750, DataLancamento = Convert.ToDateTime("2020-01-10") },
                new Lancamentos() { LancamentoId = 5, ProdutoId = 2, Observacao = "", Quantidade = 600, DataLancamento = Convert.ToDateTime("2020-01-10") }
            );
            #endregion

            #region PEDIDOS
            modelBuilder.Entity<Pedido>().HasData(
                new Pedido() { PedidoId = 1, DataVenda = Convert.ToDateTime("2020-03-10"), QtdTotal = 20, ValorTotal = Convert.ToDecimal(17.75), ClienteId = 1 },
                new Pedido() { PedidoId = 2, DataVenda = Convert.ToDateTime("2020-03-10"), QtdTotal = 30, ValorTotal = Convert.ToDecimal(88.00), ClienteId = 2 },
                new Pedido() { PedidoId = 3, DataVenda = Convert.ToDateTime("2020-03-10"), QtdTotal = 15, ValorTotal = Convert.ToDecimal(60.00), ClienteId = 3 },
                new Pedido() { PedidoId = 4, DataVenda = Convert.ToDateTime("2020-03-11"), QtdTotal = 15, ValorTotal = Convert.ToDecimal(60.00), ClienteId = 4 },
                new Pedido() { PedidoId = 5, DataVenda = Convert.ToDateTime("2020-03-12"), QtdTotal = 15, ValorTotal = Convert.ToDecimal(60.00), ClienteId = 4 }
            );
            #endregion

            #region PEDIDOSITENS
            modelBuilder.Entity<PedidoItens>().HasData(
                new PedidoItens() { PedidoItensId = 1, PedidoId = 1, ProdutoId = 1, Qtd = 5, Valor = Convert.ToDecimal(1.75), ValorTotal = Convert.ToDecimal(7.75) },
                new PedidoItens() { PedidoItensId = 2, PedidoId = 1, ProdutoId = 2, Qtd = 5, Valor = Convert.ToDecimal(1.80), ValorTotal = Convert.ToDecimal(9.00) },
                new PedidoItens() { PedidoItensId = 3, PedidoId = 2, ProdutoId = 3, Qtd = 10, Valor = Convert.ToDecimal(1.60), ValorTotal = Convert.ToDecimal(16.00) },
                new PedidoItens() { PedidoItensId = 4, PedidoId = 2, ProdutoId = 4, Qtd = 12, Valor = Convert.ToDecimal(4.00), ValorTotal = Convert.ToDecimal(48.00) },
                new PedidoItens() { PedidoItensId = 5, PedidoId = 2, ProdutoId = 5, Qtd = 8, Valor = Convert.ToDecimal(3.00), ValorTotal = Convert.ToDecimal(24.00) },
                new PedidoItens() { PedidoItensId = 6, PedidoId = 3, ProdutoId = 4, Qtd = 15, Valor = Convert.ToDecimal(4.00), ValorTotal = Convert.ToDecimal(60.00) },
                new PedidoItens() { PedidoItensId = 7, PedidoId = 4, ProdutoId = 4, Qtd = 15, Valor = Convert.ToDecimal(4.00), ValorTotal = Convert.ToDecimal(60.00) },
                new PedidoItens() { PedidoItensId = 8, PedidoId = 4, ProdutoId = 4, Qtd = 15, Valor = Convert.ToDecimal(4.00), ValorTotal = Convert.ToDecimal(60.00) }
            );
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
