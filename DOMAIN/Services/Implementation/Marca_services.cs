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
	public class Marca_services : IMarca_Services
	{
		private ICRUD _crud = new CRUD();

		public async Task<MarcaDomain> AddSingleMarca(string name)
		{
			Marca marca = new Marca();
			marca.nombreMarca = name;
			var asd = await _crud.Create<Marca>(marca);
			MarcaDomain marcaDomain = new MarcaDomain();
			marcaDomain.idMarca = marca.idMarca;
			marcaDomain.nombreMarca = marca.nombreMarca;
			return marcaDomain;
		}

		public async Task<List<MarcaDomain>> GetMarca()
		{
			List<Marca> marca = await _crud.ReadAll<Marca>();

			List<MarcaDomain> marca_Services = new List<MarcaDomain>();
			foreach (var i in marca) {
				marca_Services.Add(new MarcaDomain { idMarca = i.idMarca, nombreMarca = i.nombreMarca });
			}
			return marca_Services;
		}
	}
}
