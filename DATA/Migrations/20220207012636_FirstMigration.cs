using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DATA.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCategoria = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    idEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pass = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.idEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    idMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreMarca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.idMarca);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    idProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.idProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    idVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empleadoidEmpleado = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fechaVenta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.idVenta);
                    table.ForeignKey(
                        name: "FK_Venta_Empleado_empleadoidEmpleado",
                        column: x => x.empleadoidEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "idEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    MarcaidMarca = table.Column<int>(type: "int", nullable: true),
                    CategoriaidCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaidCategoria",
                        column: x => x.CategoriaidCategoria,
                        principalTable: "Categoria",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Marca_MarcaidMarca",
                        column: x => x.MarcaidMarca,
                        principalTable: "Marca",
                        principalColumn: "idMarca",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    idCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProveedoridProveedor = table.Column<int>(type: "int", nullable: false),
                    montoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fechaCompra = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.idCompra);
                    table.ForeignKey(
                        name: "FK_Compra_Proveedor_ProveedoridProveedor",
                        column: x => x.ProveedoridProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "idProveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    idDetalleVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentaidVenta = table.Column<int>(type: "int", nullable: false),
                    ProductoidProducto = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.idDetalleVenta);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Producto_ProductoidProducto",
                        column: x => x.ProductoidProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Venta_VentaidVenta",
                        column: x => x.VentaidVenta,
                        principalTable: "Venta",
                        principalColumn: "idVenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productoProveedor",
                columns: table => new
                {
                    idProductoProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProveedoridProveedor = table.Column<int>(type: "int", nullable: true),
                    ProductoidProducto = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productoProveedor", x => x.idProductoProveedor);
                    table.ForeignKey(
                        name: "FK_productoProveedor_Producto_ProductoidProducto",
                        column: x => x.ProductoidProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_productoProveedor_Proveedor_ProveedoridProveedor",
                        column: x => x.ProveedoridProveedor,
                        principalTable: "Proveedor",
                        principalColumn: "idProveedor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComprasDetalle",
                columns: table => new
                {
                    idComprasDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompraidCompra = table.Column<int>(type: "int", nullable: true),
                    ProductoidProducto = table.Column<int>(type: "int", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasDetalle", x => x.idComprasDetalle);
                    table.ForeignKey(
                        name: "FK_ComprasDetalle_Compra_CompraidCompra",
                        column: x => x.CompraidCompra,
                        principalTable: "Compra",
                        principalColumn: "idCompra",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComprasDetalle_Producto_ProductoidProducto",
                        column: x => x.ProductoidProducto,
                        principalTable: "Producto",
                        principalColumn: "idProducto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_ProveedoridProveedor",
                table: "Compra",
                column: "ProveedoridProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasDetalle_CompraidCompra",
                table: "ComprasDetalle",
                column: "CompraidCompra");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasDetalle_ProductoidProducto",
                table: "ComprasDetalle",
                column: "ProductoidProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_ProductoidProducto",
                table: "DetalleVenta",
                column: "ProductoidProducto");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_VentaidVenta",
                table: "DetalleVenta",
                column: "VentaidVenta");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaidCategoria",
                table: "Producto",
                column: "CategoriaidCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_MarcaidMarca",
                table: "Producto",
                column: "MarcaidMarca");

            migrationBuilder.CreateIndex(
                name: "IX_productoProveedor_ProductoidProducto",
                table: "productoProveedor",
                column: "ProductoidProducto");

            migrationBuilder.CreateIndex(
                name: "IX_productoProveedor_ProveedoridProveedor",
                table: "productoProveedor",
                column: "ProveedoridProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_empleadoidEmpleado",
                table: "Venta",
                column: "empleadoidEmpleado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprasDetalle");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "productoProveedor");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
