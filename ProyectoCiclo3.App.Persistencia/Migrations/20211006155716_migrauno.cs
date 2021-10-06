using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class migrauno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "presentacion",
                table: "Aviones");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Aviones",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "peso",
                table: "Aviones",
                newName: "num_baños");

            migrationBuilder.AddColumn<int>(
                name: "cap_max_peso",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "modelo",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "num_asientos",
                table: "Aviones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Aeropuertos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coord_x = table.Column<int>(type: "int", nullable: false),
                    coord_y = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeropuertos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeropuertos");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropColumn(
                name: "cap_max_peso",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "modelo",
                table: "Aviones");

            migrationBuilder.DropColumn(
                name: "num_asientos",
                table: "Aviones");

            migrationBuilder.RenameColumn(
                name: "num_baños",
                table: "Aviones",
                newName: "peso");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Aviones",
                newName: "tipo");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "Aviones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "presentacion",
                table: "Aviones",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
