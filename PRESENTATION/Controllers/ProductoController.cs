using DOMAIN.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTATION.Controllers
{
	public class ProductoController : Controller
	{
		private IProducto_Services _producto_Services;

		 public ProductoController(IProducto_Services producto_Services)
		{
			_producto_Services = producto_Services;
		}
		public async Task<IActionResult> Index()
		{
			var productos = await _producto_Services.GetProductos();
			return View(productos);
		}
	}
}
