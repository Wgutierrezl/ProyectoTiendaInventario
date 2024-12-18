using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInventarioController.Entidades
{
	public class Ordenes
	{
		[Key]
		public int OrderID { get; set; }
		public string? TipoOrden { get; set; }
		public DateTime FechaOrden { get; set; }
		public decimal Total {  get; set; }
	}
}
