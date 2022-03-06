using DOMAIN.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PRESENTATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTATION.Controllers
{
	public class CategoriaController : Controller
	{
		private ICategoria_Services _categoria_Services;

		public CategoriaController(ICategoria_Services categoria_Services)
		{
			_categoria_Services = categoria_Services;
		}
		public async Task<IActionResult> Index()
		{
			var categorias = await _categoria_Services.GetCategoria();
			return View(categorias);
		}

		//Http Get Create

		public IActionResult Create()
		{
			return View();
		}

		//Http Post Create
		[HttpPost]
		public async Task<IActionResult> Create(Categoria categoria)
		{
			if (ModelState.IsValid) {
				var result = await _categoria_Services.AddSingleCategoria(categoria.nombreCategoria);
				return RedirectToAction("Index");

			}

			return RedirectToAction("Index");
		}


		public async Task<IActionResult> Edit(int id)
		{
			
			var categoria = await _categoria_Services.GetById(id);
		
			return View(categoria);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(Categoria categoria, int idCategoria) {

			if (ModelState.IsValid) {
				if (categoria.idCategoria == idCategoria) 
				{
					var result = await _categoria_Services.UpdateCategoria(categoria.idCategoria, categoria.nombreCategoria);
					return RedirectToAction("Index");

				}
			}
			return View();

		}

		public async Task<IActionResult> Delete(int id)
		{

			var categoria = await _categoria_Services.GetById(id);

			return View(categoria);
		}
		[HttpPost]
		public async Task<IActionResult> Delete(int idCategoria, string nameCategoria) {

			var result = await _categoria_Services.DeleteCategoria(idCategoria);

			return RedirectToAction("Index");

		}
	}
}
