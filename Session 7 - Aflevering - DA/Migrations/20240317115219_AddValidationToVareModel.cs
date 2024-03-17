using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_7___Aflevering___DA.Migrations
{
    public partial class AddValidationToVareModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vare_Varegruppe_VaregruppeId",
                table: "Varer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varegruppe",
                table: "Varegruppe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vare",
                table: "Varer");

            migrationBuilder.RenameTable(
                name: "Varegruppe",
                newName: "Varegrupper");

            migrationBuilder.RenameTable(
                name: "Varer",
                newName: "Varer");

            migrationBuilder.RenameIndex(
                name: "IX_Vare_VaregruppeId",
                table: "Varer",
                newName: "IX_Varer_VaregruppeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Varer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Varer",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varegrupper",
                table: "Varegrupper",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varer",
                table: "Varer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Varer_Varegrupper_VaregruppeId",
                table: "Varer",
                column: "VaregruppeId",
                principalTable: "Varegrupper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Varer_Varegrupper_VaregruppeId",
                table: "Varer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varer",
                table: "Varer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varegrupper",
                table: "Varegrupper");

            migrationBuilder.RenameTable(
                name: "Varer",
                newName: "Varer");

            migrationBuilder.RenameTable(
                name: "Varegrupper",
                newName: "Varegruppe");

            migrationBuilder.RenameIndex(
                name: "IX_Varer_VaregruppeId",
                table: "Varer",
                newName: "IX_Vare_VaregruppeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Varer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Varer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vare",
                table: "Varer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varegruppe",
                table: "Varegruppe",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vare_Varegruppe_VaregruppeId",
                table: "Varer",
                column: "VaregruppeId",
                principalTable: "Varegruppe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
