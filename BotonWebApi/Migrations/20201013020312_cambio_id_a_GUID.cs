﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BotonWebApi.Migrations
{
    public partial class cambio_id_a_GUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE[dbo].[Buttons] DROP CONSTRAINT PK_Buttons");
            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Buttons",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
            migrationBuilder.Sql("ALTER TABLE [dbo].[Buttons] ADD CONSTRAINT PK_Buttons PRIMARY KEY([Id])");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Buttons",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid));
        }
    }
}
