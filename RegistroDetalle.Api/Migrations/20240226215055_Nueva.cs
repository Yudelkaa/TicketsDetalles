using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistroDetalle.Api.Migrations
{
    /// <inheritdoc />
    public partial class Nueva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketsDetalle_Tickets_TicketId",
                table: "TicketsDetalle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketsDetalle",
                table: "TicketsDetalle");

            migrationBuilder.RenameTable(
                name: "TicketsDetalle",
                newName: "TicketsDetalles");

            migrationBuilder.RenameIndex(
                name: "IX_TicketsDetalle_TicketId",
                table: "TicketsDetalles",
                newName: "IX_TicketsDetalles_TicketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketsDetalles",
                table: "TicketsDetalles",
                column: "DetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketsDetalles_Tickets_TicketId",
                table: "TicketsDetalles",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketsDetalles_Tickets_TicketId",
                table: "TicketsDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketsDetalles",
                table: "TicketsDetalles");

            migrationBuilder.RenameTable(
                name: "TicketsDetalles",
                newName: "TicketsDetalle");

            migrationBuilder.RenameIndex(
                name: "IX_TicketsDetalles_TicketId",
                table: "TicketsDetalle",
                newName: "IX_TicketsDetalle_TicketId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketsDetalle",
                table: "TicketsDetalle",
                column: "DetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketsDetalle_Tickets_TicketId",
                table: "TicketsDetalle",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
