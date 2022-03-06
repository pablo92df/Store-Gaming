using DATA.Entities;
using DATA.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Specific
{
	public class Producto_Operations : IProducto_Operations
	{
		public async Task<List<Producto>> GetAllProductos()
		{
            try
            {
                using (var context = new DatabaseContext(DatabaseContext.Options.DatabaseOptions))
                {
                    List<Producto> producto = await context.Producto.Include(x => x.Categoria).Include(x => x.Marca).ToListAsync();

                    return producto;
                }
            }
            catch
            {
                throw;
            }
        }
	}
}
