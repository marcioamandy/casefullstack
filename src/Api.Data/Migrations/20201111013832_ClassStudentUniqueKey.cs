using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ClassStudentUniqueKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudent",
                table: "ClassStudent");

            migrationBuilder.DropIndex(
                name: "IX_ClassStudent_IdClass",
                table: "ClassStudent");

            migrationBuilder.DropIndex(
                name: "IX_ClassStudent_IdStudent",
                table: "ClassStudent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudent",
                table: "ClassStudent",
                columns: new[] { "Id", "IdClass", "IdStudent" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudent",
                table: "ClassStudent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudent",
                table: "ClassStudent",
                column: "Id");

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
    }
}
