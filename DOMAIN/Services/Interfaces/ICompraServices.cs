using DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Services.Interfaces
{
	public interface ICompraServices
	{
		Task<CompraDomain> AddCompra(int proveedroID, decimal monto, DateTime fechaCompra);
		Task<List<CompraDomain>> GetCompras();
	}
}
