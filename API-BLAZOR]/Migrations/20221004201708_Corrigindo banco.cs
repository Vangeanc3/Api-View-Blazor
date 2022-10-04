using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_BLAZOR_.Migrations
{
    public partial class Corrigindobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gerentes_Gerencias_Id",
                table: "Gerentes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Gerentes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Gerentes_GerenciaId",
                table: "Gerentes",
                column: "GerenciaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gerentes_Gerencias_GerenciaId",
                table: "Gerentes",
                column: "GerenciaId",
                principalTable: "Gerencias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gerentes_Gerencias_GerenciaId",
                table: "Gerentes");

            migrationBuilder.DropIndex(
                name: "IX_Gerentes_GerenciaId",
                table: "Gerentes");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Gerentes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Gerentes_Gerencias_Id",
                table: "Gerentes",
                column: "Id",
                principalTable: "Gerencias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
