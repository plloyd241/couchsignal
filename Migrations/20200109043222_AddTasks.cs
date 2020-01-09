using Microsoft.EntityFrameworkCore.Migrations;

namespace CouchSignal.Migrations
{
    public partial class AddTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Roles_RoleID",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Roles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Devices",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Devices",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Devices_RoleID",
                table: "Devices",
                newName: "IX_Devices_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Devices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Devices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Roles_RoleId",
                table: "Devices",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Roles_RoleId",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roles",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Devices",
                newName: "RoleID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Devices",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Devices_RoleId",
                table: "Devices",
                newName: "IX_Devices_RoleID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Devices",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Devices",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Roles_RoleID",
                table: "Devices",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
