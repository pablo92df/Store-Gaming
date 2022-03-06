using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entities
{
	public class productoProveedor
	{
		[Key]
		public int idProductoProveedor { get; set; }
		public Proveedor Proveedor { get; set; }

		public Producto Producto { get; set; }


	}
}
