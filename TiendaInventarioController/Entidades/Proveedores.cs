using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInventarioController.Entidades
{
	public class Proveedores
	{
		[Key]
		public int CodigoProveedor { get;set; }
		public string NombreProveedor { get; set; } = null!;
		public string Telefono { get; set; }= null!;
		public string Email { get; set; } = null!;
	}
}
