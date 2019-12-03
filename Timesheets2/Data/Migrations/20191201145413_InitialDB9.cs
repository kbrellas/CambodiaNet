﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Timesheets2.Data.Migrations
{
    public partial class InitialDB9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheets_Projects_RelatedProjectProjectId",
                table: "Timesheets");

            migrationBuilder.DropIndex(
                name: "IX_Timesheets_RelatedProjectProjectId",
                table: "Timesheets");

            migrationBuilder.DropColumn(
                name: "RelatedProjectProjectId",
                table: "Timesheets");

            migrationBuilder.AddColumn<long>(
                name: "Project",
                table: "Timesheets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_Project",
                table: "Timesheets",
                column: "Project");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheets_Projects_Project",
                table: "Timesheets",
                column: "Project",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheets_Projects_Project",
                table: "Timesheets");

            migrationBuilder.DropIndex(
                name: "IX_Timesheets_Project",
                table: "Timesheets");

            migrationBuilder.DropColumn(
                name: "Project",
                table: "Timesheets");

            migrationBuilder.AddColumn<long>(
                name: "RelatedProjectProjectId",
                table: "Timesheets",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_RelatedProjectProjectId",
                table: "Timesheets",
                column: "RelatedProjectProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheets_Projects_RelatedProjectProjectId",
                table: "Timesheets",
                column: "RelatedProjectProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
