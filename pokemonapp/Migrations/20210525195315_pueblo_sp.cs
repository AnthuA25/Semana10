using Microsoft.EntityFrameworkCore.Migrations;

namespace pokemonapp.Migrations
{
    public partial class pueblo_sp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pueblos_Regiones_RegionId",
                table: "Pueblos");

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Pueblos",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pueblos_Regiones_RegionId",
                table: "Pueblos",
                column: "RegionId",
                principalTable: "Regiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pueblos_Regiones_RegionId",
                table: "Pueblos");

            migrationBuilder.AlterColumn<int>(
                name: "RegionId",
                table: "Pueblos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Pueblos_Regiones_RegionId",
                table: "Pueblos",
                column: "RegionId",
                principalTable: "Regiones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
