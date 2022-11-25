using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace codeFirstExampleNew.Migrations
{
    public partial class hopitalmig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    docpatientId = table.Column<int>(type: "int", nullable: false),
                    doctordocid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.id);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_doctordocid",
                        column: x => x.doctordocid,
                        principalTable: "Doctors",
                        principalColumn: "docid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_doctordocid",
                table: "Patients",
                column: "doctordocid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
