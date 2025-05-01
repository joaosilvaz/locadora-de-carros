using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace locadora_de_carros.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CARRO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ds_modelo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ds_marca = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    nr_ano = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    nr_valordiaria = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARRO", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CARRO");
        }
    }
}
