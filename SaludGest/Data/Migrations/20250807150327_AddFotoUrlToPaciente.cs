using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaludGest.Migrations
{
    /// <inheritdoc />
    public partial class AddFotoUrlToPaciente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoUrl",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FotoUrl" },
                values: new object[] { new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9264), null });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                columns: new[] { "FechaCreacion", "FotoUrl" },
                values: new object[] { new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9274), null });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                columns: new[] { "FechaCreacion", "FotoUrl" },
                values: new object[] { new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9277), null });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 4,
                columns: new[] { "FechaCreacion", "FotoUrl" },
                values: new object[] { new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9280), null });

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 5,
                columns: new[] { "FechaCreacion", "FotoUrl" },
                values: new object[] { new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9284), null });

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 9, 3, 25, 442, DateTimeKind.Local).AddTicks(9386));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoUrl",
                table: "Pacientes");

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "CitaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Especialidades",
                keyColumn: "EspecialidadId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "HistorialMedico",
                keyColumn: "HistorialMedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Medicamentos",
                keyColumn: "MedicamentoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "MedicoId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Prescripciones",
                keyColumn: "PrescripcionId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2025, 8, 7, 3, 32, 48, 931, DateTimeKind.Local).AddTicks(1932));
        }
    }
}
