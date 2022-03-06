using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Models
{
	public class ProveedorDomain
	{
		public int idProveedor { get; set; }

		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string nombre { get; set; }
		[Required(ErrorMessage = "Ingrese Telefono")]
		[StringLength(10, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string telefono { get; set; }
		[Required(ErrorMessage = "Ingrese Celular")]
		[StringLength(12, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string celular { get; set; }
		[Required(ErrorMessage = "Ingrese EMAIL")]
		[StringLength(100, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string email { get; set; }
	}
}
