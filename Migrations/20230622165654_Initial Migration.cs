using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Szkolenie_techniczne_3_projekt.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ulica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numer_domu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    specjalizacja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsTeachers",
                columns: table => new
                {
                    Studentsid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Teachersid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsTeachers", x => new { x.Studentsid, x.Teachersid });
                    table.ForeignKey(
                        name: "FK_StudentsTeachers_Students_Studentsid",
                        column: x => x.Studentsid,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsTeachers_Teachers_Teachersid",
                        column: x => x.Teachersid,
                        principalTable: "Teachers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsTeachers_Teachersid",
                table: "StudentsTeachers",
                column: "Teachersid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsTeachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
