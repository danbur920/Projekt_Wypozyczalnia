using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_ASP_NET.Migrations
{
    /// <inheritdoc />
    public partial class MigrationNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "ReservationId1",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "VehicleId1",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_AspNetUsers_UserId1",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Reservations_ReservationId1",
                table: "Rentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Vehicles_VehicleId1",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_UserId1",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_ReservationId1",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_VehicleId1",
                table: "Rentals");

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Branches",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        NumberOfVehicles = table.Column<int>(type: "int", nullable: true),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Branches", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Branches_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vehicles",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        IsAvailable = table.Column<bool>(type: "bit", nullable: false),
            //        PricePerHour = table.Column<float>(type: "real", nullable: true),
            //        PricePerDay = table.Column<float>(type: "real", nullable: true),
            //        PricePerMonth = table.Column<float>(type: "real", nullable: true),
            //        PurchasePrice = table.Column<float>(type: "real", nullable: true),
            //        Length = table.Column<float>(type: "real", nullable: true),
            //        Width = table.Column<float>(type: "real", nullable: true),
            //        Weight = table.Column<float>(type: "real", nullable: true),
            //        Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Horsepower = table.Column<float>(type: "real", nullable: true),
            //        IsCombustionVehicle = table.Column<bool>(type: "bit", nullable: false),
            //        IsElectricVehicle = table.Column<bool>(type: "bit", nullable: false),
            //        BranchId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vehicles", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Vehicles_Branches_BranchId",
            //            column: x => x.BranchId,
            //            principalTable: "Branches",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Reservations",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StartOfRental = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        EndOfRental = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        VehicleId = table.Column<int>(type: "int", nullable: false),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Reservations", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Reservations_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Reservations_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Rentals",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        StartOfRental = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        EndOfRental = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        VehicleId = table.Column<int>(type: "int", nullable: false),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ReservationId = table.Column<int>(type: "int", nullable: false),
            //        ReservationId1 = table.Column<int>(type: "int", nullable: true),
            //        UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //        VehicleId1 = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Rentals", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Rentals_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Rentals_AspNetUsers_UserId1",
            //            column: x => x.UserId1,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Rentals_Reservations_ReservationId",
            //            column: x => x.ReservationId,
            //            principalTable: "Reservations",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Rentals_Reservations_ReservationId1",
            //            column: x => x.ReservationId1,
            //            principalTable: "Reservations",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Rentals_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Rentals_Vehicles_VehicleId1",
            //            column: x => x.VehicleId1,
            //            principalTable: "Vehicles",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "AspNetRoleClaims",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "RoleNameIndex",
            //    table: "AspNetRoles",
            //    column: "NormalizedName",
            //    unique: true,
            //    filter: "[NormalizedName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserClaims_UserId",
            //    table: "AspNetUserClaims",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "AspNetUserLogins",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "AspNetUserRoles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "EmailIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedEmail");

            //migrationBuilder.CreateIndex(
            //    name: "UserNameIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedUserName",
            //    unique: true,
            //    filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Branches_UserId",
            //    table: "Branches",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Rentals_ReservationId",
            //    table: "Rentals",
            //    column: "ReservationId",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Rentals_ReservationId1",
            //    table: "Rentals",
            //    column: "ReservationId1",
            //    unique: true,
            //    filter: "[ReservationId1] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Rentals_UserId",
            //    table: "Rentals",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Rentals_UserId1",
            //    table: "Rentals",
            //    column: "UserId1");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Rentals_VehicleId",
            //    table: "Rentals",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Rentals_VehicleId1",
            //    table: "Rentals",
            //    column: "VehicleId1");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Reservations_UserId",
            //    table: "Reservations",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Reservations_VehicleId",
            //    table: "Reservations",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vehicles_BranchId",
            //    table: "Vehicles",
            //    column: "BranchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
