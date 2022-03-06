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
	public class Proveedor_Services : IProveedor_Services
	{
		private ICRUD _crud = new CRUD();

		public async Task<List<ProveedorDomain>> GetProveedores()
		{
			List<Proveedor> proveedor = new List<Proveedor>();
			proveedor = await _crud.ReadAll<Proveedor>();

			List<ProveedorDomain> proveedorDomain = new List<ProveedorDomain>();

			foreach (var p in proveedor) 
			{
				proveedorDomain.Add(new ProveedorDomain {
					idProveedor = p.idProveedor,
					celular = p.celular,
					nombre = p.nombre,
					email = p.email,
					telefono = p.telefono
				});
			}
			return proveedorDomain;
		}
	}
}
