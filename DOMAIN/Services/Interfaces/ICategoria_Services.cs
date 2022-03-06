using DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services.Interfaces
{
	public interface ICategoria_Services
	{
		Task<CategoriaDomain> AddSingleCategoria(string name);
		Task<List<CategoriaDomain>> GetCategoria();
		Task<CategoriaDomain> UpdateCategoria(int idCategoria, string nombre);

		Task<CategoriaDomain> GetById(int idCategoria);
		Task<bool> DeleteCategoria(int idCategoria);

	}
}
