using Microsoft.EntityFrameworkCore.Migrations;

namespace Questor.Questao2.Library.Migrations
{
    public partial class AcrescimoQntItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "PedidoId",
                keyValue: 5,
                column: "ClienteId",
                value: 2);

            migrationBuilder.InsertData(
                table: "PedidoItens",
                columns: new[] { "PedidoItensId", "PedidoId", "ProdutoId", "Qtd", "Valor", "ValorTotal" },
                values: new object[] { 9, 5, 4, 15, 4m, 60m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PedidoItens",
                keyColumn: "PedidoItensId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Pedido",
                keyColumn: "PedidoId",
                keyValue: 5,
                column: "ClienteId",
                value: 4);
        }
    }
}
