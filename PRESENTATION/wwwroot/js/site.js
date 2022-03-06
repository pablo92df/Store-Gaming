// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    $("#agregarProducto").click(function () {


        agregarProductoLista();
    });
});

function agregarProductoLista() {

    let listProducto = $("#tablaProducto");

    let precioUnidad = $("#precioProducto").val();
    let cantidad = $("#cantidad").val();
    let subTotal = $("#precioProducto").val() * $("#cantidad").val();
    let marca = $("#marcas option:selected").text();
    let idMarca = $("#marcas option:selected").val();
    let categoria = $("#categorias option:selected").text();
    let idCategoria = $("#categorias option:selected").val();
    let nombre = $("#nombre").val();
    let descripcion = $("#descripcion").val();

    let detalleProducto =
        "<tr><td>" + nombre
        + "</td><td>" + marca
        + "</td><td>" + idMarca
        + "</td><td>" + categoria
        + "</td><td>" + idCategoria
        + "</td><td>" + descripcion
        + "</td><td>" + '$' + parseFloat(precioUnidad).toFixed(2)
        + "</td><td>" + cantidad
        + "</td><td>" + '$' + parseFloat(subTotal).toFixed(2)
        + "</td><td> <input type='button' value='Remove' name='remove' class='btn btn-danger' onclick='RemoveItem(this)' </td></tr > ";

    listProducto.append(detalleProducto);
    CalcularMontoTotal(subTotal);
    ResetProductos();
}

function ResetProductos() {

    $("#cantidad").val('');
    $("#subTotal").val('');
    $("#precioProducto").val('');
    $("#marcas option:selected").text();
    $("#categorias option:selected").text();
    $("#nombre").val('');
    $("#descripcion").val('');

}

window.onload = function () {

    var fecha = new Date();
    var mes = fecha.getMonth() + 1;
    var dia = fecha.getDate();
    var ano = fecha.getFullYear();
    if (dia < 10)
        dia = '0' + dia;
    if (mes < 10)
        mes = '0' + mes
    console.log(ano + " - " + mes + " -" + dia);
    //document.getElementById('fechaActual').value = ano + "-" + mes + "-" + dia;

}

function RemoveItem(itemId) {

    $(itemId).closest('tr').remove();

}

function CalcularMontoTotal(subtotal) {

    let monto = parseFloat($("#montoTotal").val()) + subtotal;
    console.log($("#montoTotal").val(parseFloat(monto).toFixed(2)));

}

$("#btnGuardar").click(function () {
    var comprasViewModel = {};

    //var ListCompraDetalle = new Array();

    var Productos = new Array();


    comprasViewModel.idProveedor = parseInt($("#proveedor").val());
    comprasViewModel.montoTotal = parseFloat($("#montoTotal").val());

    $("#tablaProducto").find("tr:gt(0)").each(function () {
        var Producto = {};

        Producto.nombre = $(this).find("td:eq(0)").text();
        Producto.idMarca = $(this).find("td:eq(2)").text();
        Producto.idCategoria = $(this).find("td:eq(4)").text();
        Producto.descripcion = $(this).find("td:eq(5)").text();
        Producto.precio = $(this).find("td:eq(6)").text();
        Producto.stock = $(this).find("td:eq(7)").text();
        Productos.push(Producto);
        comprasViewModel.productos = Productos;
        comprasViewModel.ComprasDetalles = {};

    });

    $.ajax({
        async: true,
        type: 'POST',
        dataType: "application/json; charset=UTF-8",
        data: comprasViewModel,
        url: "https://localhost:44379/ComprasViewModel/Create",
        success: function (data) {

        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(errorThrown);
        }
    });

});

