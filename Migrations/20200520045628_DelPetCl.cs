using Microsoft.EntityFrameworkCore.Migrations;

namespace PetBook.Migrations
{
    public partial class DelPetCl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetCalendar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetCalendar",
                columns: table => new
                {
                    IdexNumber = table.Column<int>(name: "Idex Number", type: "int", nullable: false),
                    CalendarID = table.Column<int>(name: "Calendar ID", type: "int", nullable: true),
                    MedicalFileID = table.Column<int>(name: "Medical File ID", type: "int", nullable: true),
                    PetID = table.Column<int>(name: "Pet ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PetCalen__36E7A3C7BD7B7EAA", x => x.IdexNumber);
                    table.ForeignKey(
                        name: "FK__PetCalend__Calen__2B3F6F97",
                        column: x => x.CalendarID,
                        principalTable: "Calendar",
                        principalColumn: "Calendar ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PetCalend__Medic__29572725",
                        column: x => x.MedicalFileID,
                        principalTable: "MedicalFile",
                        principalColumn: "Medical File ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PetCalend__Pet I__2A4B4B5E",
                        column: x => x.PetID,
                        principalTable: "Pet",
                        principalColumn: "Pet ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetCalendar_Calendar ID",
                table: "PetCalendar",
                column: "Calendar ID");

            migrationBuilder.CreateIndex(
                name: "IX_PetCalendar_Medical File ID",
                table: "PetCalendar",
                column: "Medical File ID");

            migrationBuilder.CreateIndex(
                name: "IX_PetCalendar_Pet ID",
                table: "PetCalendar",
                column: "Pet ID");
        }
    }
}
