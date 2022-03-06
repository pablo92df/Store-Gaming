
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Models
{
	public class ProductoDomain
	{
		
		public int idProducto { get; set; }
		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		[Display(Name = "nombre")]
		public string nombre { get; set; }

		[Required(ErrorMessage = "Ingrese precio")]
		public decimal precio { get; set; }

		[Required(ErrorMessage = "Ingrese stock")]
		public int stock { get; set; }

		public string MarcaNombre { get; set; }

		public string CategoriaNombre { get; set; }


	}
}
