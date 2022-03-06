using DOMAIN.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRESENTATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTATION.Controllers
{
	public class CompraController : Controller
	{
		private ICategoria_Services _categoria_Services;
		private IMarca_Services _marca_Services;
		private ICompraServices _compraServices;
		private IProveedor_Services _proveedor_Services;
		public CompraController(ICategoria_Services categoria_Services, IMarca_Services marca_Services, ICompraServices compraServices, IProveedor_Services proveedor_Services)
		{
			_categoria_Services = categoria_Services;
			_marca_Services = marca_Services;
			_compraServices = compraServices;
			_proveedor_Services = proveedor_Services;
		}
		public async Task<IActionResult> Index()
		{

			var compras = await _compraServices.GetCompras();
			return View(compras);
		}


		public async Task<IActionResult> Create()
		{

			ViewData["Marcas"] = new SelectList(await _marca_Services.GetMarca(), "idMarca", "nombreMarca");
			ViewData["Categorias"] = new SelectList( await _categoria_Services.GetCategoria(), "idCategoria", "nombreCategoria");
			ViewData["Proveedor"] = new SelectList(await _proveedor_Services.GetProveedores(), "idProveedor", "nombre");
			return View();

		}

		[HttpPost]
		public async Task<IActionResult> Create(Compra compra)
		{

			if (!ModelState.IsValid)
			{
				compra.fechaCompra = DateTime.Now;

				var compraRealizada = await _compraServices.AddCompra(compra.ProveedorId, compra.montoTotal, compra.fechaCompra);
				


			}

			return View("Index");

		}

	}
}
