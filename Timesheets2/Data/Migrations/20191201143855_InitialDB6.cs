using Microsoft.EntityFrameworkCore.Migrations;

namespace Timesheets2.Data.Migrations
{
    public partial class InitialDB6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimesheetProject");

            migrationBuilder.AddColumn<long>(
                name: "ProjectId",
                table: "Timesheets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_ProjectId",
                table: "Timesheets",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheets_Projects_ProjectId",
                table: "Timesheets",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheets_Projects_ProjectId",
                table: "Timesheets");

            migrationBuilder.DropIndex(
                name: "IX_Timesheets_ProjectId",
                table: "Timesheets");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Timesheets");

            migrationBuilder.CreateTable(
                name: "TimesheetProject",
                columns: table => new
                {
                    ProjectId = table.Column<long>(type: "bigint", nullable: false),
                    TimesheetId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimesheetProject", x => new { x.ProjectId, x.TimesheetId });
                    table.ForeignKey(
                        name: "FK_TimesheetProject_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimesheetProject_Timesheets_TimesheetId",
                        column: x => x.TimesheetId,
                        principalTable: "Timesheets",
                        principalColumn: "TimesheetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimesheetProject_TimesheetId",
                table: "TimesheetProject",
                column: "TimesheetId",
                unique: true);
        }
    }
}
