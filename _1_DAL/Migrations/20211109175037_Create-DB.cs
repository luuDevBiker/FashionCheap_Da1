using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CUSTOMERS",
                columns: table => new
                {
                    id_Customer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<bool>(type: "bit", nullable: false),
                    account_Number = table.Column<int>(type: "int", nullable: false),
                    customer_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMERS", x => x.id_Customer);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYEES",
                columns: table => new
                {
                    id_Employee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<bool>(type: "bit", nullable: false),
                    bridDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEES", x => x.id_Employee);
                });

            migrationBuilder.CreateTable(
                name: "IMAGES_PRODUCTS",
                columns: table => new
                {
                    id_Image = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imge_Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGES_PRODUCTS", x => x.id_Image);
                });

            migrationBuilder.CreateTable(
                name: "OPTIONS",
                columns: table => new
                {
                    id_Option = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    option_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPTIONS", x => x.id_Option);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    id_Product = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    products_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.id_Product);
                });

            migrationBuilder.CreateTable(
                name: "ROLES",
                columns: table => new
                {
                    id_roles = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roles_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLES", x => x.id_roles);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    id_Order = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Customer = table.Column<int>(type: "int", nullable: false),
                    id_Employee = table.Column<int>(type: "int", nullable: false),
                    order_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    discount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount_Pay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paying_Customer = table.Column<decimal>(type: "money", nullable: false),
                    refunds = table.Column<decimal>(type: "money", nullable: false),
                    payments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS", x => x.id_Order);
                    table.ForeignKey(
                        name: "FK_ORDERS_CUSTOMERS_id_Customer",
                        column: x => x.id_Customer,
                        principalTable: "CUSTOMERS",
                        principalColumn: "id_Customer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDERS_EMPLOYEES_id_Employee",
                        column: x => x.id_Employee,
                        principalTable: "EMPLOYEES",
                        principalColumn: "id_Employee",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OPTIONS_VALUES",
                columns: table => new
                {
                    id_Option = table.Column<int>(type: "int", nullable: false),
                    id_Values = table.Column<int>(type: "int", nullable: false),
                    option_Values = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPTIONS_VALUES", x => new { x.id_Option, x.id_Values });
                    table.ForeignKey(
                        name: "FK_OPTIONS_VALUES_OPTIONS_id_Option",
                        column: x => x.id_Option,
                        principalTable: "OPTIONS",
                        principalColumn: "id_Option",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS_OPTIONS",
                columns: table => new
                {
                    id_Product = table.Column<int>(type: "int", nullable: false),
                    id_Option = table.Column<int>(type: "int", nullable: false),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS_OPTIONS", x => new { x.id_Product, x.id_Option });
                    table.ForeignKey(
                        name: "FK_PRODUCTS_OPTIONS_OPTIONS_id_Option",
                        column: x => x.id_Option,
                        principalTable: "OPTIONS",
                        principalColumn: "id_Option",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_OPTIONS_PRODUCTS_id_Product",
                        column: x => x.id_Product,
                        principalTable: "PRODUCTS",
                        principalColumn: "id_Product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS_VARIANTS",
                columns: table => new
                {
                    id_Product = table.Column<int>(type: "int", nullable: false),
                    id_Variant = table.Column<int>(type: "int", nullable: false),
                    sku_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS_VARIANTS", x => new { x.id_Product, x.id_Variant });
                    table.ForeignKey(
                        name: "FK_PRODUCTS_VARIANTS_PRODUCTS_id_Product",
                        column: x => x.id_Product,
                        principalTable: "PRODUCTS",
                        principalColumn: "id_Product",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ROLES_EMPLOYEE",
                columns: table => new
                {
                    id_Employee = table.Column<int>(type: "int", nullable: false),
                    id_Roles = table.Column<int>(type: "int", nullable: false),
                    StatusDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ROLES_EMPLOYEE_EMPLOYEES_id_Employee",
                        column: x => x.id_Employee,
                        principalTable: "EMPLOYEES",
                        principalColumn: "id_Employee",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ROLES_EMPLOYEE_ROLES_id_Roles",
                        column: x => x.id_Roles,
                        principalTable: "ROLES",
                        principalColumn: "id_roles",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VARIANTS_VALUES",
                columns: table => new
                {
                    id_Product = table.Column<int>(type: "int", nullable: false),
                    id_Variant = table.Column<int>(type: "int", nullable: false),
                    id_Option = table.Column<int>(type: "int", nullable: false),
                    id_Values = table.Column<int>(type: "int", nullable: false),
                    id_Image = table.Column<int>(type: "int", nullable: false),
                    import_Price = table.Column<decimal>(type: "money", nullable: false),
                    price = table.Column<decimal>(type: "money", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VARIANTS_VALUES", x => new { x.id_Product, x.id_Variant, x.id_Option });
                    table.ForeignKey(
                        name: "FK_VARIANTS_VALUES_IMAGES_PRODUCTS_id_Image",
                        column: x => x.id_Image,
                        principalTable: "IMAGES_PRODUCTS",
                        principalColumn: "id_Image",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VARIANTS_VALUES_OPTIONS_VALUES_id_Option_id_Values",
                        columns: x => new { x.id_Option, x.id_Values },
                        principalTable: "OPTIONS_VALUES",
                        principalColumns: new[] { "id_Option", "id_Values" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VARIANTS_VALUES_PRODUCTS_OPTIONS_id_Product_id_Option",
                        columns: x => new { x.id_Product, x.id_Option },
                        principalTable: "PRODUCTS_OPTIONS",
                        principalColumns: new[] { "id_Product", "id_Option" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VARIANTS_VALUES_PRODUCTS_VARIANTS_id_Product_id_Variant",
                        columns: x => new { x.id_Product, x.id_Variant },
                        principalTable: "PRODUCTS_VARIANTS",
                        principalColumns: new[] { "id_Product", "id_Variant" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS_DETAILS",
                columns: table => new
                {
                    id_Order = table.Column<int>(type: "int", nullable: false),
                    id_Product = table.Column<int>(type: "int", nullable: false),
                    id_Variant = table.Column<int>(type: "int", nullable: false),
                    id_Option = table.Column<int>(type: "int", nullable: false),
                    id_Values = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    unit_Price = table.Column<decimal>(type: "money", nullable: false),
                    price_Each = table.Column<decimal>(type: "money", nullable: false),
                    Discount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS_DETAILS", x => new { x.id_Order, x.id_Product, x.id_Variant, x.id_Option });
                    table.ForeignKey(
                        name: "FK_ORDERS_DETAILS_ORDERS_id_Order",
                        column: x => x.id_Order,
                        principalTable: "ORDERS",
                        principalColumn: "id_Order",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORDERS_DETAILS_VARIANTS_VALUES_id_Product_id_Variant_id_Option",
                        columns: x => new { x.id_Product, x.id_Variant, x.id_Option },
                        principalTable: "VARIANTS_VALUES",
                        principalColumns: new[] { "id_Product", "id_Variant", "id_Option" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_id_Customer",
                table: "ORDERS",
                column: "id_Customer");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_id_Employee",
                table: "ORDERS",
                column: "id_Employee");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_DETAILS_id_Product_id_Variant_id_Option",
                table: "ORDERS_DETAILS",
                columns: new[] { "id_Product", "id_Variant", "id_Option" });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_OPTIONS_id_Option",
                table: "PRODUCTS_OPTIONS",
                column: "id_Option");

            migrationBuilder.CreateIndex(
                name: "IX_ROLES_EMPLOYEE_id_Employee",
                table: "ROLES_EMPLOYEE",
                column: "id_Employee");

            migrationBuilder.CreateIndex(
                name: "IX_ROLES_EMPLOYEE_id_Roles",
                table: "ROLES_EMPLOYEE",
                column: "id_Roles");

            migrationBuilder.CreateIndex(
                name: "IX_VARIANTS_VALUES_id_Image",
                table: "VARIANTS_VALUES",
                column: "id_Image");

            migrationBuilder.CreateIndex(
                name: "IX_VARIANTS_VALUES_id_Option_id_Values",
                table: "VARIANTS_VALUES",
                columns: new[] { "id_Option", "id_Values" });

            migrationBuilder.CreateIndex(
                name: "IX_VARIANTS_VALUES_id_Product_id_Option",
                table: "VARIANTS_VALUES",
                columns: new[] { "id_Product", "id_Option" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDERS_DETAILS");

            migrationBuilder.DropTable(
                name: "ROLES_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "VARIANTS_VALUES");

            migrationBuilder.DropTable(
                name: "ROLES");

            migrationBuilder.DropTable(
                name: "CUSTOMERS");

            migrationBuilder.DropTable(
                name: "EMPLOYEES");

            migrationBuilder.DropTable(
                name: "IMAGES_PRODUCTS");

            migrationBuilder.DropTable(
                name: "OPTIONS_VALUES");

            migrationBuilder.DropTable(
                name: "PRODUCTS_OPTIONS");

            migrationBuilder.DropTable(
                name: "PRODUCTS_VARIANTS");

            migrationBuilder.DropTable(
                name: "OPTIONS");

            migrationBuilder.DropTable(
                name: "PRODUCTS");
        }
    }
}
