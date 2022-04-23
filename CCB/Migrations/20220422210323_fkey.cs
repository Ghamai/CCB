using Microsoft.EntityFrameworkCore.Migrations;

namespace CCB.Migrations
{
    public partial class fkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContractorId",
                table: "Renewals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Renewals_ContractorId",
                table: "Renewals",
                column: "ContractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Renewals_Contractors_ContractorId",
                table: "Renewals",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Renewals_Contractors_ContractorId",
                table: "Renewals");

            migrationBuilder.DropIndex(
                name: "IX_Renewals_ContractorId",
                table: "Renewals");

            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "Renewals");
        }
    }
}
