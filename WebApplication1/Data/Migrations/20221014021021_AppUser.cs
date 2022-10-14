using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Data.Migrations
{
    public partial class AppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "highscore1",
                table: "AspNetUsers",
                type: "decimal(20,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "highscore2",
                table: "AspNetUsers",
                type: "decimal(20,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "highscore3",
                table: "AspNetUsers",
                type: "decimal(20,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "highscore4",
                table: "AspNetUsers",
                type: "decimal(20,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "highscore5",
                table: "AspNetUsers",
                type: "decimal(20,0)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "highscore1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "highscore2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "highscore3",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "highscore4",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "highscore5",
                table: "AspNetUsers");
        }
    }
}
