using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entities
{
	public class Compra
	{
		[Key]
		public int idCompra { get; set; }
		[Required]
		public Proveedor Proveedor { get; set; }
		[Required]
		public decimal montoTotal { get; set; }
		[Required]
		public DateTime fechaCompra { get; set; }

		public List<ComprasDetalle> ComprasDetalles { get; set; }

	}
}
