using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PR2.Migrations
{
    public partial class TableInputDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InputDatas",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Layer_H = table.Column<double>(type: "REAL", nullable: false),
                    T_material = table.Column<double>(type: "REAL", nullable: false),
                    T_gas = table.Column<double>(type: "REAL", nullable: false),
                    V_gas = table.Column<double>(type: "REAL", nullable: false),
                    C_gas = table.Column<double>(type: "REAL", nullable: false),
                    Consum = table.Column<double>(type: "REAL", nullable: false),
                    C_material = table.Column<double>(type: "REAL", nullable: false),
                    Koef = table.Column<double>(type: "REAL", nullable: false),
                    Diam = table.Column<double>(type: "REAL", nullable: false),
                    DateAdd = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputDatas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InputDatas");
        }
    }
}
