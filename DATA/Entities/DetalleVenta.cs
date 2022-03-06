using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entities
{
	public class DetalleVenta
	{
		[Key]
		public int idDetalleVenta { get; set; }
		[Required]

		public Venta Venta { get; set; }

		[Required]

		public Producto Producto { get; set; }


		[Required]

		public int cantidad { get; set; }
		[Required]

		public decimal monto { get; set; }
	}
}
