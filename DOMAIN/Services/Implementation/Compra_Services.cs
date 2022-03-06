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
	public class Compra_Services : ICompraServices
	{
		private ICRUD _crud = new CRUD();

		public async Task<CompraDomain> AddCompra(int proveedroID, decimal monto, DateTime fechaCompra)
		{
			Compra  compra = new Compra();

			var proveedor = await _crud.Read<ProveedorDomain>(proveedroID);
			compra.montoTotal = monto;
			compra.fechaCompra = fechaCompra;
			compra.Proveedor.celular = proveedor.celular;
			compra.Proveedor.email = proveedor.email;
			compra.Proveedor.idProveedor = proveedor.idProveedor;
			compra.Proveedor.nombre = proveedor.nombre;
	

			var compraResponse = await _crud.Create<Compra>(compra);

			CompraDomain compraDomain = new CompraDomain();
			compraDomain.idCompra = compraResponse.idCompra;
			compraDomain.fechaCompra = compraResponse.fechaCompra;
			compraDomain.ProveedorId = compraResponse.Proveedor.idProveedor;
			compraDomain.ProveedorName = compraResponse.Proveedor.nombre;
			compraDomain.montoTotal = compraResponse.montoTotal;

			return compraDomain;
		}

		public async Task<List<CompraDomain>> GetCompras()
		{
			List<Compra> compras = new List<Compra>();

			compras = await _crud.ReadAll<Compra>();

			List<CompraDomain> compraDomains = new List<CompraDomain>();
			foreach (var c in compras) {

				compraDomains.Add(new CompraDomain {
					idCompra = c.idCompra,
					fechaCompra = c.fechaCompra,
					ProveedorId = c.Proveedor.idProveedor,
					ProveedorName = c.Proveedor.nombre,
					montoTotal = c.montoTotal

			});
			
			}

			return compraDomains;

		}
	}
}
