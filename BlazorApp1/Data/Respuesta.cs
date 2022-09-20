using System.Collections.Generic;

namespace BlazorApp1.Data
{
	public class Respuesta<T>
	{
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public T Data { get; set; }

    }
}
