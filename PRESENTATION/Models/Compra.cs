using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTATION.Models
{
	public class Compra
	{
		public int idCompra { get; set; }

		public int ProveedorId { get; set; }
		public string ProveedorName { get; set; }
		public decimal montoTotal { get; set; }
		public DateTime fechaCompra { get; set; }

		public List<Producto> productos { get; set; }

	}
}
