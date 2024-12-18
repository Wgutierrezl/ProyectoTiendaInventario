using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaInventarioController.Entidades
{
	public class Productos
	{
		[Key]
		public int CodigoProducto { get; set; }
		public string NombreProducto { get; set; }= null!;
		public string Descripcion { get; set; } = null!;
		public int CategoriaID { get; set; }
		public int ProveedorID { get;set; }
		public decimal PrecioVenta {  get; set; }
		public decimal PrecioCompra {  get; set; }
		public int Stock {  get; set; }
	}
}
