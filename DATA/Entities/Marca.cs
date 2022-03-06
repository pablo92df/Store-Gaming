using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Entities
{
	public class Marca
	{
		[Key]
		public int idMarca { get; set; }
		[Required(ErrorMessage = "Ingrese marca")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string nombreMarca { get; set; }
		public List<Producto> Productos { get; set; }
	}
}
