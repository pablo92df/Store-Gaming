using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRESENTATION.Models
{
	public class Categoria
	{
		
		public int idCategoria { get; set; }
		[Required(ErrorMessage = "Ingrese categoria")]
		[StringLength(50, ErrorMessage = "El {0} debe se al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
		public string nombreCategoria { get; set; }


	}
}
