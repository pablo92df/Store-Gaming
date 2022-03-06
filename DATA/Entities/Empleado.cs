using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entities
{
	public class Empleado
	{

		[Key]
		public int idEmpleado { get; set; }
		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		[Display(Name = "nombre")]
		public string nombre { get; set; }
		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string apellido { get; set; }

		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string usuario { get; set; }

		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(100, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string pass { get; set; }

		[Required(ErrorMessage = "Ingrese descripcion")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string email { get; set; }

		public List<Venta> Ventas { get; set; }
	}
}
