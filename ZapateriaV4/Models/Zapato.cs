using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaV4.Models
{
	public class Zapato
	{
		public string Marca { get; set; }
		public string Nombre { get; set; }
		public string Color { get; set; }
		public string Tipo { get; set;  }
		public string Precio { get; set; }
		public string Formatouno { get; set; }
		public string Formatodos { get; set; }
		public string Formatotres { get; set; }
		public string Estado { get; set; }

		public Zapato(string marca, string nombre, string color, string tipo, string precio, string formatouno, string formatodos, string formatotres, string estado)
		{
			Marca = marca;
			Nombre = nombre;
			Color = color;
			Tipo = tipo;
			Precio = precio;
			Formatouno = formatouno;
			Formatodos = formatodos;
			Formatotres = formatotres;
			Estado = estado;
		}

		public Zapato() {}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
