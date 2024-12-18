namespace TiendaFrontInventario.Services
{
	public interface IServiciosProveedores
	{
		Task<HttpResponseWrapper<T>> GetProveedores<T>(string url);
		Task<HttpResponseWrapper<object>> PostProveedores<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PostProveedores<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> PutProveedores<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PutProveedores<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> DeleteProveedores(string url);
		Task<HttpResponseWrapper<TActionResponse>> DeleteProveedores<TActionResponse>(string url);

	}

	public interface IServiciosCategorias
	{
		Task<HttpResponseWrapper<T>> GetCategorias<T>(string url);
		Task<HttpResponseWrapper<object>> PostCategorias<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PostCategorias<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> PutCategorias<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PutCategorias<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> DeleteCategorias(string url);
		Task<HttpResponseWrapper<TActionResponse>> DeleteCategorias<TActionResponse>(string url);

	}

	public interface IServiciosProductos
	{
		Task<HttpResponseWrapper<T>> GetProductos<T>(string url);
		Task<HttpResponseWrapper<object>> PostProductos<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PostProductos<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> PutProductos<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PutProductos<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> DeleteProductos(string url);
		Task<HttpResponseWrapper<TActionResponse>> DeleteProductos<TActionResponse>(string url);
	}

	public interface IServiciosOrdenes
	{
		Task<HttpResponseWrapper<T>> GetOrdenes<T>(string url);
		Task<HttpResponseWrapper<object>> PostOrdenes<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PostOrdenes<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> PutOrdenes<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PutOrdenes<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> DeleteOrdenes(string url);
		Task<HttpResponseWrapper<TActionResponse>> DeleteOrdenes<TActionResponse>(string url);
	}

	public interface IServiciosDetalleOrden
	{
		Task<HttpResponseWrapper<T>> GetDetalleOrden<T>(string url);
		Task<HttpResponseWrapper<object>> PostDetalleOrden<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PostDetalleOrden<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> PutDetalleOrden<T>(string url, T model);
		Task<HttpResponseWrapper<TActionResponse>> PutDetalleOrden<T, TActionResponse>(string url, T model);
		Task<HttpResponseWrapper<object>> DeleteDetalleOrden(string url);
		Task<HttpResponseWrapper<TActionResponse>> DeleteDetalleOrden<TActionResponse>(string url);
	}
}
