﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questor.Questao2.Library.Contexto;

namespace Questor.Questao2.Library.Migrations
{
    [DbContext(typeof(QuestorContext))]
    [Migration("20200510021108_CargaDeDados")]
    partial class CargaDeDados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(800);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Descricao = "OUTROS MATERIAIS",
                            Nome = "OUTROS"
                        },
                        new
                        {
                            CategoriaId = 2,
                            Descricao = "MATERIAIS PARA PAPELARIA",
                            Nome = "PAPELARIA"
                        });
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Nome = "DOMINGOS ASSUNÇÃO"
                        },
                        new
                        {
                            ClienteId = 2,
                            Nome = "SANDRA CORDEIRO"
                        },
                        new
                        {
                            ClienteId = 3,
                            Nome = "MARCOS AZEVEDO"
                        },
                        new
                        {
                            ClienteId = 4,
                            Nome = "STEFANO GARCIA"
                        },
                        new
                        {
                            ClienteId = 5,
                            Nome = "ELENA GRANDE"
                        },
                        new
                        {
                            ClienteId = 6,
                            Nome = "LAIS CAROLINE"
                        });
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.Lancamentos", b =>
                {
                    b.Property<int>("LancamentoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataLancamento");

                    b.Property<string>("Observacao")
                        .HasMaxLength(800);

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("LancamentoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Lançamentos");

                    b.HasData(
                        new
                        {
                            LancamentoId = 1,
                            DataLancamento = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observacao = "",
                            ProdutoId = 1,
                            Quantidade = 800
                        },
                        new
                        {
                            LancamentoId = 2,
                            DataLancamento = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observacao = "",
                            ProdutoId = 5,
                            Quantidade = 600
                        },
                        new
                        {
                            LancamentoId = 3,
                            DataLancamento = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observacao = "",
                            ProdutoId = 4,
                            Quantidade = 100
                        },
                        new
                        {
                            LancamentoId = 4,
                            DataLancamento = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observacao = "",
                            ProdutoId = 3,
                            Quantidade = 750
                        },
                        new
                        {
                            LancamentoId = 5,
                            DataLancamento = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Observacao = "",
                            ProdutoId = 2,
                            Quantidade = 600
                        });
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataVenda");

                    b.Property<int>("QtdTotal");

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("PedidoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedido");

                    b.HasData(
                        new
                        {
                            PedidoId = 1,
                            ClienteId = 1,
                            DataVenda = new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QtdTotal = 20,
                            ValorTotal = 17.75m
                        },
                        new
                        {
                            PedidoId = 2,
                            ClienteId = 2,
                            DataVenda = new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QtdTotal = 30,
                            ValorTotal = 88m
                        },
                        new
                        {
                            PedidoId = 3,
                            ClienteId = 3,
                            DataVenda = new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QtdTotal = 15,
                            ValorTotal = 60m
                        },
                        new
                        {
                            PedidoId = 4,
                            ClienteId = 4,
                            DataVenda = new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QtdTotal = 15,
                            ValorTotal = 60m
                        },
                        new
                        {
                            PedidoId = 5,
                            ClienteId = 4,
                            DataVenda = new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            QtdTotal = 15,
                            ValorTotal = 60m
                        });
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.PedidoItens", b =>
                {
                    b.Property<int>("PedidoItensId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PedidoId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Qtd");

                    b.Property<decimal>("Valor");

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("PedidoItensId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("PedidoItens");

                    b.HasData(
                        new
                        {
                            PedidoItensId = 1,
                            PedidoId = 1,
                            ProdutoId = 1,
                            Qtd = 5,
                            Valor = 1.75m,
                            ValorTotal = 7.75m
                        },
                        new
                        {
                            PedidoItensId = 2,
                            PedidoId = 1,
                            ProdutoId = 2,
                            Qtd = 5,
                            Valor = 1.8m,
                            ValorTotal = 9m
                        },
                        new
                        {
                            PedidoItensId = 3,
                            PedidoId = 2,
                            ProdutoId = 3,
                            Qtd = 10,
                            Valor = 1.6m,
                            ValorTotal = 16m
                        },
                        new
                        {
                            PedidoItensId = 4,
                            PedidoId = 2,
                            ProdutoId = 4,
                            Qtd = 12,
                            Valor = 4m,
                            ValorTotal = 48m
                        },
                        new
                        {
                            PedidoItensId = 5,
                            PedidoId = 2,
                            ProdutoId = 5,
                            Qtd = 8,
                            Valor = 3m,
                            ValorTotal = 24m
                        },
                        new
                        {
                            PedidoItensId = 6,
                            PedidoId = 3,
                            ProdutoId = 4,
                            Qtd = 15,
                            Valor = 4m,
                            ValorTotal = 60m
                        },
                        new
                        {
                            PedidoItensId = 7,
                            PedidoId = 4,
                            ProdutoId = 4,
                            Qtd = 15,
                            Valor = 4m,
                            ValorTotal = 60m
                        },
                        new
                        {
                            PedidoItensId = 8,
                            PedidoId = 4,
                            ProdutoId = 4,
                            Qtd = 15,
                            Valor = 4m,
                            ValorTotal = 60m
                        });
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Descricao")
                        .HasMaxLength(800);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Preco");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            CategoriaId = 1,
                            Nome = "CANETA ESFEROGRÁFICA PRETA",
                            Preco = 1.75m
                        },
                        new
                        {
                            ProdutoId = 2,
                            CategoriaId = 1,
                            Nome = "CANETA ESFEROGRÁFICA AZUL",
                            Preco = 1.8m
                        },
                        new
                        {
                            ProdutoId = 3,
                            CategoriaId = 1,
                            Nome = "CANETA ESFEROGRÁFICA VERMELHA",
                            Preco = 1.6m
                        },
                        new
                        {
                            ProdutoId = 4,
                            CategoriaId = 2,
                            Nome = "PAPEL A4 XAMEX 100 FOLHAS",
                            Preco = 4m
                        },
                        new
                        {
                            ProdutoId = 5,
                            CategoriaId = 1,
                            Nome = "BORRACHA PRETA",
                            Preco = 3m
                        });
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.Lancamentos", b =>
                {
                    b.HasOne("Questor.Questao2.Library.Domain.Entities.Produto", "Produto")
                        .WithMany("Lancalentos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Questor.Questao2.Library.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.PedidoItens", b =>
                {
                    b.HasOne("Questor.Questao2.Library.Domain.Entities.Pedido", "Pedido")
                        .WithMany("PedidoItens")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Questor.Questao2.Library.Domain.Entities.Produto", "Produto")
                        .WithMany("PedidoItens")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Questor.Questao2.Library.Domain.Entities.Produto", b =>
                {
                    b.HasOne("Questor.Questao2.Library.Domain.Entities.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
