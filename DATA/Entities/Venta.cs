using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entities
{
	public class Venta
	{
		[Key]
		public int idVenta { get; set; }
		[Required]
		public Empleado empleado { get; set; }

		[Required]
		public decimal total { get; set; }
		[Required]
		public DateTime fechaVenta { get; set; }

		public List<DetalleVenta> DetalleVentas { get; set; }
	}
}
