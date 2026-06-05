using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class DataSeededDepartamentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Titulo" },
                values: new object[,]
                {
                    { 1, "DEPARTAMENTO DE SISTEMAS Y COMPUTACION" },
                    { 2, "DEPARTAMENTO DE INGENIERIA INDUSTRIAL" },
                    { 3, "DEPARTAMENTO DE CIENCIAS DE LA TIERRA" },
                    { 4, "DEPARTAMENTO DE CIENCIAS ECONOMICO-ADMINISTRATIVAS" },
                    { 5, "DEPARTAMENTO DE INGENIERIA METAL-MECANICA" },
                    { 6, "DEPARTAMENTO DE INGENIERIA QUIMICA Y BIOQUIMICA" },
                    { 7, "DEPARTAMENTO DE CIENCIAS BASICAS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
