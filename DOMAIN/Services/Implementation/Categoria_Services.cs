using DATA.Entities;
using DATA.Functions.Crud;
using DATA.Interface;
using DOMAIN.Models;
using DOMAIN.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services.Implementation
{
	public class Categoria_Services : ICategoria_Services
	{
		private ICRUD _crud = new CRUD();

		public async Task<CategoriaDomain> AddSingleCategoria(string name)
		{

			Categoria categoria = new Categoria();
			categoria.nombreCategoria = name;
			var categoriaResponse = await _crud.Create<Categoria>(categoria);

		
			CategoriaDomain categoriaDomain = new CategoriaDomain();
			categoriaDomain.idCategoria = categoria.idCategoria;
			categoriaDomain.nombreCategoria = categoria.nombreCategoria;
			return categoriaDomain;
		}

		public async Task<bool> DeleteCategoria(int idCategoria)
		{
			bool confirm = await _crud.Delete<Categoria>(idCategoria);

			return confirm;
		}

		public async Task<CategoriaDomain> GetById(int idCategoria)
		{
			var categoria = await _crud.Read<Categoria>(idCategoria);

			CategoriaDomain categoriaDomain = new CategoriaDomain
			{
				idCategoria = categoria.idCategoria,
				nombreCategoria = categoria.nombreCategoria
			};

			return categoriaDomain;
		}

		public async Task<List<CategoriaDomain>> GetCategoria()
		{
			List<Categoria> categoria = await _crud.ReadAll<Categoria>();

			List<CategoriaDomain> categoria_Services = new List<CategoriaDomain>();
			foreach (var i in categoria)
			{
				categoria_Services.Add(new CategoriaDomain { idCategoria = i.idCategoria, nombreCategoria = i.nombreCategoria });
			}
			return categoria_Services;
		}

		public async Task<CategoriaDomain> UpdateCategoria(int idCategoria, string nombre)
		{
			Categoria categoria = new Categoria
			{
				idCategoria = idCategoria,
				nombreCategoria = nombre,
			};

			categoria = await _crud.Update<Categoria>(categoria, idCategoria);
			CategoriaDomain categoriaDomain = new CategoriaDomain
			{
				idCategoria = categoria.idCategoria,
				nombreCategoria = categoria.nombreCategoria
			};

			return categoriaDomain;
		}
	}
}
