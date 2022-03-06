using DATA;
using DOMAIN.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PRESENTATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTATION.Controllers
{
	public class MarcaController : Controller
	{
		private IMarca_Services _marca_Services;

		public MarcaController(IMarca_Services marca_Services) {
			_marca_Services = marca_Services;
		}
		public async Task<IActionResult> Index()
		{
			var result = await _marca_Services.GetMarca();
			return View(result);
		}

		//Http Get Create
		public IActionResult Create()
		{
			return View();
		}

		//Http Post Create
		[HttpPost]
		public async Task<IActionResult> Create(Marca marca) {

			var result = await _marca_Services.AddSingleMarca(marca.Nombre);

			return View();
		}
	}
}
