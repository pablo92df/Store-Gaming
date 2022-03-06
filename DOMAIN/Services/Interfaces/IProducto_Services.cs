using DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services.Interfaces
{
	public interface IProducto_Services
	{
		Task<List<ProductoDomain>> GetProductos();

	}
}
