using DATA.Entities;
using DATA.Functions.Crud;
using DATA.Interface;
using DATA.Specific;
using DOMAIN.Models;
using DOMAIN.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services.Implementation
{
	public class Producto_Services : IProducto_Services
	{
		private ICRUD _crud = new CRUD();
		private IProducto_Operations producto_Operations = new Producto_Operations();
		public async Task<List<ProductoDomain>> GetProductos()
		{
			List<Producto> productos = new List<Producto>();
			productos = await producto_Operations.GetAllProductos();

			List<ProductoDomain> productoDomains = new List<ProductoDomain>();

			foreach (Producto p in productos) {
				productoDomains.Add(new ProductoDomain { idProducto = p.idProducto, MarcaNombre = p.Marca.nombreMarca, precio = p.precio, stock = p.stock, CategoriaNombre = p.Categoria.nombreCategoria });
			}
			return productoDomains;
		}
	}
}
