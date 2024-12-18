﻿using System.Text.Json;
using System.Text;

namespace TiendaFrontInventario.Services
{
	public class ServiciosProveedores : IServiciosProveedores
	{
		private readonly HttpClient _httpClient;

		private JsonSerializerOptions _jsonDefaultOptions => new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true,
		};

		public ServiciosProveedores(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		private async Task<T> UnserializeAnswer<T>(HttpResponseMessage responseHttp)
		{
			var response = await responseHttp.Content.ReadAsStringAsync();
			return JsonSerializer.Deserialize<T>(response, _jsonDefaultOptions)!;
		}
		public async Task<HttpResponseWrapper<object>> DeleteProveedores(string url)
		{
			var responseHttp = await _httpClient.DeleteAsync(url);
			return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
		}

		public async Task<HttpResponseWrapper<TActionResponse>> DeleteProveedores<TActionResponse>(string url)
		{
			var responseHttp = await _httpClient.DeleteAsync(url);

			if (responseHttp.IsSuccessStatusCode)
			{
				var response = await UnserializeAnswer<TActionResponse>(responseHttp);
				return new HttpResponseWrapper<TActionResponse>(response, false, responseHttp);
			}

			return new HttpResponseWrapper<TActionResponse>(default, !responseHttp.IsSuccessStatusCode, responseHttp);
		}

		public async Task<HttpResponseWrapper<T>> GetProveedores<T>(string url)
		{
			var responseHttp = await _httpClient.GetAsync(url);
			if (responseHttp.IsSuccessStatusCode)
			{
				var response = await UnserializeAnswer<T>(responseHttp);
				return new HttpResponseWrapper<T>(response, false, responseHttp);
			}

			return new HttpResponseWrapper<T>(default, true, responseHttp);
		}

		public async Task<HttpResponseWrapper<object>> PostProveedores<T>(string url, T model)
		{
			var messageJSON = JsonSerializer.Serialize(model);
			var messageContet = new StringContent(messageJSON, Encoding.UTF8, "application/json");
			var responseHttp = await _httpClient.PostAsync(url, messageContet);
			return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
		}

		public async Task<HttpResponseWrapper<TActionResponse>> PostProveedores<T, TActionResponse>(string url, T model)
		{
			var messageJSON = JsonSerializer.Serialize(model);
			var messageContet = new StringContent(messageJSON, Encoding.UTF8, "application/json");
			var responseHttp = await _httpClient.PostAsync(url, messageContet);
			if (responseHttp.IsSuccessStatusCode)
			{
				var response = await UnserializeAnswer<TActionResponse>(responseHttp);
				return new HttpResponseWrapper<TActionResponse>(response, false, responseHttp);
			}

			return new HttpResponseWrapper<TActionResponse>(default, !responseHttp.IsSuccessStatusCode, responseHttp);
		}

		public async Task<HttpResponseWrapper<object>> PutProveedores<T>(string url, T model)
		{
			var messageJSON = JsonSerializer.Serialize(model);
			var messageContet = new StringContent(messageJSON, Encoding.UTF8, "application/json");
			var responseHttp = await _httpClient.PutAsync(url, messageContet);
			return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
		}

		public async Task<HttpResponseWrapper<TActionResponse>> PutProveedores<T, TActionResponse>(string url, T model)
		{
			var messageJSON = JsonSerializer.Serialize(model);
			var messageContent = new StringContent(messageJSON, Encoding.UTF8, "application/json");
			var responseHttp = await _httpClient.PutAsync(url, messageContent);

			if (responseHttp.IsSuccessStatusCode)
			{
				var response = await UnserializeAnswer<TActionResponse>(responseHttp);
				return new HttpResponseWrapper<TActionResponse>(response, false, responseHttp);
			}

			return new HttpResponseWrapper<TActionResponse>(default, !responseHttp.IsSuccessStatusCode, responseHttp);
		}
	}

}
