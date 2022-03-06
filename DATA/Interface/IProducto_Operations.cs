using DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Interface
{
	public interface IProducto_Operations
	{
		Task<List<Producto>> GetAllProductos();
	}
}
