using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInventarioController.Entidades
{
	public class DetalleOrden
	{ 
		[Key]
		public int DetalleOrderID { get; set; }
		public int IdOrden { get; set; }
		public int ProductoID { get; set; }
		public int Cantidad {  get; set; }
		public decimal PrecioUnitario { get; set; }
	}
}
