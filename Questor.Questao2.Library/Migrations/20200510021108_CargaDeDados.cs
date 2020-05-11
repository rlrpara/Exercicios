using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Questor.Questao2.Library.Migrations
{
    public partial class CargaDeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descricao", "Nome" },
                values: new object[] { 1, "OUTROS MATERIAIS", "OUTROS" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descricao", "Nome" },
                values: new object[] { 2, "MATERIAIS PARA PAPELARIA", "PAPELARIA" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nome" },
                values: new object[] { 1, "DOMINGOS ASSUNÇÃO" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nome" },
                values: new object[] { 2, "SANDRA CORDEIRO" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nome" },
                values: new object[] { 3, "MARCOS AZEVEDO" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nome" },
                values: new object[] { 4, "STEFANO GARCIA" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nome" },
                values: new object[] { 5, "ELENA GRANDE" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nome" },
                values: new object[] { 6, "LAIS CAROLINE" });

            migrationBuilder.InsertData(
                table: "Pedido",
                columns: new[] { "PedidoId", "ClienteId", "DataVenda", "QtdTotal", "ValorTotal" },
                values: new object[] { 1, 1, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 17.75m });

            migrationBuilder.InsertData(
                table: "Pedido",
                columns: new[] { "PedidoId", "ClienteId", "DataVenda", "QtdTotal", "ValorTotal" },
                values: new object[] { 2, 2, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 88m });

            migrationBuilder.InsertData(
                table: "Pedido",
                columns: new[] { "PedidoId", "ClienteId", "DataVenda", "QtdTotal", "ValorTotal" },
                values: new object[] { 3, 3, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 60m });

            migrationBuilder.InsertData(
                table: "Pedido",
                columns: new[] { "PedidoId", "ClienteId", "DataVenda", "QtdTotal", "ValorTotal" },
                values: new object[] { 4, 4, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 60m });

            migrationBuilder.InsertData(
                table: "Pedido",
                columns: new[] { "PedidoId", "ClienteId", "DataVenda", "QtdTotal", "ValorTotal" },
                values: new object[] { 5, 4, new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 60m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "Descricao", "Nome", "Preco" },
                values: new object[] { 1, 1, null, "CANETA ESFEROGRÁFICA PRETA", 1.75m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "Descricao", "Nome", "Preco" },
                values: new object[] { 2, 1, null, "CANETA ESFEROGRÁFICA AZUL", 1.8m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "Descricao", "Nome", "Preco" },
                values: new object[] { 3, 1, null, "CANETA ESFEROGRÁFICA VERMELHA", 1.6m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "Descricao", "Nome", "Preco" },
                values: new object[] { 5, 1, null, "BORRACHA PRETA", 3m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaId", "Descricao", "Nome", "Preco" },
                values: new object[] { 4, 2, null, "PAPEL A4 XAMEX 100 FOLHAS", 4m });

            migrationBuilder.InsertData(
                table: "Lançamentos",
                columns: new[] { "LancamentoId", "DataLancamento", "Observacao", "ProdutoId", "Quantidade" },
                values: new object[] { 1, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 1, 800 });

            migrationBuilder.InsertData(
                table: "Lançamentos",
                columns: new[] { "LancamentoId", "DataLancamento", "Observacao", "ProdutoId", "Quantidade" },
                values: new object[] { 5, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 2, 600 });

            migrationBuilder.InsertData(
                table: "Lançamentos",
                columns: new[] { "LancamentoId", "DataLancamento", "Observacao", "ProdutoId", "Quantidade" },
                values: new object[] { 4, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 3, 750 });

            migrationBuilder.InsertData(
                table: "Lançamentos",
                columns: new[] { "LancamentoId", "DataLancamento", "Observacao", "ProdutoId", "Quantidade" },
                values: new object[] { 2, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 5, 600 });

            migrationBuilder.InsertData(
                table: "Lançamentos",
                columns: new[] { "LancamentoId", "DataLancamento", "Observacao", "ProdutoId", "Quantidade" },
                values: new object[] { 3, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 4, 100 });

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 1, 1, 1, 5, 1.75m, 7.75m });

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 2, 1, 2, 5, 1.8m, 9m });

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 3, 2, 3, 10, 1.6m, 16m });

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 4, 2, 4, 12, 4m, 48m });

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 5, 2, 5, 8, 3m, 24m });

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 6, 3, 4, 15, 4m, 60m });

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 7, 4, 4, 15, 4m, 60m });

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 8, 4, 4, 15, 4m, 60m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lançamentos",
                keyColumn: "LancamentoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lançamentos",
                keyColumn: "LancamentoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lançamentos",
                keyColumn: "LancamentoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lançamentos",
                keyColumn: "LancamentoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lançamentos",
                keyColumn: "LancamentoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pedido",
                keyColumn: "PedidoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pedido",
                keyColumn: "PedidoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pedido",
                keyColumn: "PedidoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pedido",
                keyColumn: "PedidoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pedido",
                keyColumn: "PedidoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 4);
        }
    }
}
