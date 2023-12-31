﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prova.Migrations
{
	/// <inheritdoc />
	public partial class initial : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Actives",
				columns: table => new
				{
					Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
					Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Actives", x => x.Code);
				});

			migrationBuilder.CreateTable(
				name: "Orders",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					CodeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
					Type = table.Column<int>(type: "int", nullable: false),
					Qty = table.Column<int>(type: "int", nullable: false),
					Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					Data = table.Column<DateTime>(type: "datetime2", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Orders", x => x.Id);
					table.ForeignKey(
						name: "FK_Orders_Actives_CodeId",
						column: x => x.CodeId,
						principalTable: "Actives",
						principalColumn: "Code",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Orders_CodeId",
				table: "Orders",
				column: "CodeId");

			migrationBuilder.InsertData(
				table: "Actives",
				columns: new[] { "Code", "Price" },
				values: new object[,]
				{
				{ "EMBR3", 19.21 },
				{ "ITUB4", 29.81 },
				{ "BBAS3", 31.82 },
				{ "VALE3", 114.62 }
				}
			);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Orders");

			migrationBuilder.DropTable(
				name: "Actives");
		}
	}
}
