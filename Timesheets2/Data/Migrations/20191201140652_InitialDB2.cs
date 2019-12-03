using Microsoft.EntityFrameworkCore.Migrations;

namespace Timesheets2.Data.Migrations
{
    public partial class InitialDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentsProject_Projects_ProjectId1",
                table: "DepartmentsProject");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentsProject_ProjectId1",
                table: "DepartmentsProject");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "DepartmentsProject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProjectId1",
                table: "DepartmentsProject",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsProject_ProjectId1",
                table: "DepartmentsProject",
                column: "ProjectId1",
                unique: true,
                filter: "[ProjectId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentsProject_Projects_ProjectId1",
                table: "DepartmentsProject",
                column: "ProjectId1",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
