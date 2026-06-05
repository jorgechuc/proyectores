using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class RelacionDepartamentosProyectores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Proyectores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Proyectores_DepartamentoId",
                table: "Proyectores",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proyectores_Departamentos_DepartamentoId",
                table: "Proyectores",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proyectores_Departamentos_DepartamentoId",
                table: "Proyectores");

            migrationBuilder.DropIndex(
                name: "IX_Proyectores_DepartamentoId",
                table: "Proyectores");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Proyectores");
        }
    }
}
