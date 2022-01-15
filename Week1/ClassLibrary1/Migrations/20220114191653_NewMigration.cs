using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplane_companies",
                columns: table => new
                {
                    Company_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplane_companies", x => x.Company_id);
                });

            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    airplane_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    total_number_of_seats = table.Column<int>(type: "int", nullable: false),
                    airplane_models = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    airplane_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    airplane_companyCompany_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.airplane_id);
                    table.ForeignKey(
                        name: "FK_Airplanes_Airplane_companies_airplane_companyCompany_id",
                        column: x => x.airplane_companyCompany_id,
                        principalTable: "Airplane_companies",
                        principalColumn: "Company_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Airplanes_airplane_companyCompany_id",
                table: "Airplanes",
                column: "airplane_companyCompany_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airplanes");

            migrationBuilder.DropTable(
                name: "Airplane_companies");
        }
    }
}
