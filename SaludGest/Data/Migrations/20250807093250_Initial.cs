using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SaludGest.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEspecialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspecialidadId);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    MedicamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Laboratorio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Presentacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.MedicamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSeguroSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    NumeroSala = table.Column<int>(type: "int", nullable: false),
                    TipoSala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaId);
                    table.ForeignKey(
                        name: "FK_Salas_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    MedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.MedicoId);
                    table.ForeignKey(
                        name: "FK_Medicos_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "DepartamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicos_Especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidades",
                        principalColumn: "EspecialidadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontoTotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaId);
                    table.ForeignKey(
                        name: "FK_Facturas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorialMedico",
                columns: table => new
                {
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialMedico", x => x.HistorialMedicoId);
                    table.ForeignKey(
                        name: "FK_HistorialMedico_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    CitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.CitaId);
                    table.ForeignKey(
                        name: "FK_Citas_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "MedicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescripciones",
                columns: table => new
                {
                    PrescripcionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistorialMedicoId = table.Column<int>(type: "int", nullable: false),
                    MedicamentoId = table.Column<int>(type: "int", nullable: false),
                    Dosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Frecuencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPrescripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Eliminado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescripciones", x => x.PrescripcionId);
                    table.ForeignKey(
                        name: "FK_Prescripciones_HistorialMedico_HistorialMedicoId",
                        column: x => x.HistorialMedicoId,
                        principalTable: "HistorialMedico",
                        principalColumn: "HistorialMedicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescripciones_Medicamentos_MedicamentoId",
                        column: x => x.MedicamentoId,
                        principalTable: "Medicamentos",
                        principalColumn: "MedicamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "DepartamentoId", "Activo", "Eliminado", "FechaCreacion", "NombreDepartamento", "Ubicacion" },
                values: new object[,]
                {
                    { 1, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1483), "Cardiología", "Piso 1" },
                    { 2, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1500), "Neurología", "Piso 2" },
                    { 3, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1501), "Pediatría", "Piso 3" },
                    { 4, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1503), "Urgencias", "Piso 0" },
                    { 5, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1504), "Oncología", "Piso 4" }
                });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "EspecialidadId", "Activo", "Descripcion", "Eliminado", "FechaCreacion", "NombreEspecialidad" },
                values: new object[,]
                {
                    { 1, true, "Especialista en corazón", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1713), "Cardiólogo" },
                    { 2, true, "Especialista en sistema nervioso", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1717), "Neurólogo" },
                    { 3, true, "Especialista en niños", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1718), "Pediatra" },
                    { 4, true, "Especialista en cáncer", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1720), "Oncólogo" },
                    { 5, true, "Médico general", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1721), "General" }
                });

            migrationBuilder.InsertData(
                table: "Medicamentos",
                columns: new[] { "MedicamentoId", "Activo", "Eliminado", "FechaCreacion", "Laboratorio", "Nombre", "Presentacion" },
                values: new object[,]
                {
                    { 1, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1872), "Genéricos MX", "Paracetamol", "Tabletas 500mg" },
                    { 2, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1876), "Farmacéutica Alfa", "Ibuprofeno", "Cápsulas 200mg" },
                    { 3, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1877), "Laboratorios Beta", "Amoxicilina", "Suspensión 250mg" },
                    { 4, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1879), "Genéricos MX", "Omeprazol", "Cápsulas 20mg" },
                    { 5, true, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1880), "Pharma Salud", "Loratadina", "Tabletas 10mg" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "Activo", "ApellidoMaterno", "ApellidoPaterno", "Direccion", "Eliminado", "Email", "FechaCreacion", "FechaNacimiento", "Genero", "Nombre", "NumeroSeguroSocial", "Telefono" },
                values: new object[,]
                {
                    { 1, true, "Gómez", "Pérez", "Av. Siempre Viva 123", false, "juanp@correo.com", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1815), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Juan", "ABC123456", "5551112221" },
                    { 2, true, "Hernández", "Martínez", "Calle Luna 456", false, "lauram@correo.com", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1825), new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Laura", "DEF789012", "5551112222" },
                    { 3, true, "López", "Gómez", "Calle Sol 789", false, "carlosg@correo.com", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1828), new DateTime(1978, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Carlos", "GHI345678", "5551112223" },
                    { 4, true, "Ramírez", "Torres", "Calle Estrella 101", false, "elenat@correo.com", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1831), new DateTime(1992, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Elena", "JKL901234", "5551112224" },
                    { 5, true, "Vega", "Sánchez", "Calle Río 202", false, "diegos@correo.com", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1834), new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Diego", "MNO567890", "5551112225" }
                });

            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "FacturaId", "Activo", "Eliminado", "Estado", "FechaCreacion", "FechaEmision", "MontoTotal", "PacienteId" },
                values: new object[,]
                {
                    { 1, true, false, "Pagada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2157), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.00m, 1 },
                    { 2, true, false, "Pendiente", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2163), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.00m, 2 },
                    { 3, true, false, "Pagada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2165), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 180.00m, 3 },
                    { 4, true, false, "Cancelada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2167), new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 220.00m, 4 },
                    { 5, true, false, "Pagada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2169), new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.00m, 5 }
                });

            migrationBuilder.InsertData(
                table: "HistorialMedico",
                columns: new[] { "HistorialMedicoId", "Activo", "Diagnostico", "Eliminado", "FechaCreacion", "FechaRegistro", "Notas", "PacienteId" },
                values: new object[,]
                {
                    { 1, true, "Gripe", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2051), new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reposo y paracetamol", 1 },
                    { 2, true, "Migraña", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2057), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibuprofeno cada 8h", 2 },
                    { 3, true, "Alergia", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2059), new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loratadina por 7 días", 3 },
                    { 4, true, "Gastritis", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2061), new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Omeprazol en ayunas", 4 },
                    { 5, true, "Infección de garganta", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2062), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amoxicilina cada 12h", 5 }
                });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "MedicoId", "Activo", "ApellidoMaterno", "ApellidoPaterno", "DepartamentoId", "Eliminado", "Email", "EspecialidadId", "FechaCreacion", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, true, "Soto", "García", 1, false, "lgarcia@saludgest.com", 1, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1764), "Luis", "5551234561" },
                    { 2, true, "Díaz", "López", 2, false, "alopez@saludgest.com", 2, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1768), "Ana", "5551234562" },
                    { 3, true, "Fernández", "Ramírez", 3, false, "cramirez@saludgest.com", 3, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1771), "Carlos", "5551234563" },
                    { 4, true, "Torres", "Núñez", 5, false, "mnunez@saludgest.com", 4, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1773), "María", "5551234564" },
                    { 5, true, "Ruiz", "Castro", 4, false, "pcastro@saludgest.com", 5, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1776), "Pedro", "5551234565" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "Activo", "DepartamentoId", "Eliminado", "FechaCreacion", "NumeroSala", "TipoSala" },
                values: new object[,]
                {
                    { 1, true, 1, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1923), 101, "Consulta" },
                    { 2, true, 2, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1927), 201, "Consulta" },
                    { 3, true, 3, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1929), 301, "Emergencia" },
                    { 4, true, 4, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1931), 1, "Emergencia" },
                    { 5, true, 5, false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1932), 401, "Quirófano" }
                });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "CitaId", "Activo", "Eliminado", "Estado", "FechaCreacion", "FechaHora", "MedicoId", "Observaciones", "PacienteId" },
                values: new object[,]
                {
                    { 1, true, false, "Completada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2209), new DateTime(2025, 1, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, "Consulta general", 1 },
                    { 2, true, false, "Completada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2215), new DateTime(2025, 3, 3, 11, 30, 0, 0, DateTimeKind.Unspecified), 2, "Revisión por migraña", 2 },
                    { 3, true, false, "Completada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2218), new DateTime(2025, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Consulta por alergia", 3 },
                    { 4, true, false, "Completada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2220), new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 4, "Consulta de seguimiento", 4 },
                    { 5, true, false, "Programada", new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2222), new DateTime(2025, 6, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), 5, "Primera cita", 5 }
                });

            migrationBuilder.InsertData(
                table: "Prescripciones",
                columns: new[] { "PrescripcionId", "Activo", "Dosis", "Eliminado", "FechaCreacion", "FechaFin", "FechaPrescripcion", "Frecuencia", "HistorialMedicoId", "MedicamentoId" },
                values: new object[,]
                {
                    { 1, true, "500mg", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2108), new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cada 8h", 1, 1 },
                    { 2, true, "200mg", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2114), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cada 8h", 2, 2 },
                    { 3, true, "10mg", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2117), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cada 24h", 3, 5 },
                    { 4, true, "20mg", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2119), new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cada 24h", 4, 4 },
                    { 5, true, "250mg", false, new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2121), new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cada 12h", 5, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_MedicoId",
                table: "Citas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_PacienteId",
                table: "Citas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_PacienteId",
                table: "Facturas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialMedico_PacienteId",
                table: "HistorialMedico",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_DepartamentoId",
                table: "Medicos",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadId",
                table: "Medicos",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescripciones_HistorialMedicoId",
                table: "Prescripciones",
                column: "HistorialMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescripciones_MedicamentoId",
                table: "Prescripciones",
                column: "MedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_DepartamentoId",
                table: "Salas",
                column: "DepartamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Prescripciones");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "HistorialMedico");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
