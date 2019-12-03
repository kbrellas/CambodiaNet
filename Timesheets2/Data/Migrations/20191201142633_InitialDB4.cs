using Microsoft.EntityFrameworkCore.Migrations;

namespace Timesheets2.Data.Migrations
{
    public partial class InitialDB4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProjectOwnerDepartmentId",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectOwnerDepartmentId",
                table: "Projects",
                column: "ProjectOwnerDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_ProjectOwnerDepartmentId",
                table: "Projects",
                column: "ProjectOwnerDepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_ProjectOwnerDepartmentId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectOwnerDepartmentId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectOwnerDepartmentId",
                table: "Projects");
        }
    }
}
