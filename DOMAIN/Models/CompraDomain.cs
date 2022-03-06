using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Models
{
	public class CompraDomain
	{
		public int idCompra { get; set; }

		public int ProveedorId { get; set; }

		public string ProveedorName { get; set; }
		public decimal montoTotal { get; set; }

		public DateTime fechaCompra { get; set; }


	}
}
