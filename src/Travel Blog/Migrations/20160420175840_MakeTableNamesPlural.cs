using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace TravelBlog.Migrations
{
    public partial class MakeTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Experience_Location_LocationId", table: "Experience");
            migrationBuilder.DropForeignKey(name: "FK_People_Experience_ExperienceId", table: "People");
            migrationBuilder.RenameTable(
                name: "People",
                newName: "Peoples");
            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");
            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");
            migrationBuilder.AddForeignKey(
                name: "FK_People_Experience_ExperienceId",
                table: "Peoples",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Location_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Experience_Location_LocationId", table: "Experiences");
            migrationBuilder.DropForeignKey(name: "FK_People_Experience_ExperienceId", table: "Peoples");
            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Location_LocationId",
                table: "Experience",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_People_Experience_ExperienceId",
                table: "People",
                column: "ExperienceId",
                principalTable: "Experience",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.RenameTable(
                name: "Peoples",
                newName: "People");
            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");
            migrationBuilder.RenameTable(
                name: "Experiences",
                newName: "Experience");
        }
    }
}
