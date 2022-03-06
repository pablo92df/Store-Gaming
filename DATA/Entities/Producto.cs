using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entities
{
	public class Producto
	{
		[Key]
		public int idProducto { get; set; }
		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		[Display(Name = "nombre")]
		public string nombre { get; set; }

		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string descripcion { get; set; }

		[Required(ErrorMessage = "Ingrese precio")]
		public decimal precio { get; set; }

		[Required(ErrorMessage = "Ingrese stock")]
		public int stock { get; set; }

		[ForeignKey("MarcaidMarca")]
		public Marca Marca { get; set; }



		[ForeignKey("CategoriaidCategoria")]
		public Categoria Categoria { get; set; }



		public List<DetalleVenta> DetalleVentas { get; set; }
		public List<productoProveedor> productoProveedors { get; set; }

		public List<ComprasDetalle> ComprasDetalles { get; set; }



	}
}
