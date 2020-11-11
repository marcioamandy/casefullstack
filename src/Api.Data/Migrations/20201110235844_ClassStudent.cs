using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ClassStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassStudent",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    IdClass = table.Column<string>(maxLength: 36, nullable: false),
                    IdStudent = table.Column<string>(maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStudent", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudent_IdClass",
                table: "ClassStudent",
                column: "IdClass",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudent_IdStudent",
                table: "ClassStudent",
                column: "IdStudent",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassStudent");
        }
    }
}
