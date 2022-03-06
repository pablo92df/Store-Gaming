using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entities
{
	public class ComprasDetalle
	{
		[Key]
		public int idComprasDetalle { get; set; }

		public Compra Compra { get; set; }

		public Producto Producto { get; set; }

		[Required]
		public int cantidad { get; set; }

		[Required]
		public decimal monto { get; set; }
	}
}
