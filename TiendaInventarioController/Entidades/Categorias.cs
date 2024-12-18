using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInventarioController.Entidades
{
	public class Categorias
	{
		[Key]
		public int CodigoCategoria { get; set; }
		public string NombreCategoria { get; set; } = null!;
		public string Descripcion { get; set; } = null!;
	}
}
