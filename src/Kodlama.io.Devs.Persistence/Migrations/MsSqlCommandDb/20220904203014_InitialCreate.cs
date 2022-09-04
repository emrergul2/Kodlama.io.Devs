using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kodlama.io.Devs.Persistence.Migrations.MsSqlCommandDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "FirstReleaseDate", "Name" },
                values: new object[] { new Guid("3022cff5-dba4-45cd-be6f-414a97a3655b"), "23/01/1996", "Java" });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "FirstReleaseDate", "Name" },
                values: new object[] { new Guid("9b223aab-fd15-4277-afb7-86275896549d"), "10/11/2009", "Go" });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "FirstReleaseDate", "Name" },
                values: new object[] { new Guid("9fbe5384-8b9b-4b77-ba73-317a1984fc55"), "08/10/2001", "C#" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");
        }
    }
}
