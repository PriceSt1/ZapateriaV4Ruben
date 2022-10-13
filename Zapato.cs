using System;

public class Zapato
{
	private string Marca { get; set; }
	private string Nombre { get; set; }
	private string Color { get; set; }
	private string Precio { get; set; }
	private string Formatouno { get; set; }
	private string Formatodos { get; set; }
	private string Formatotres { get; set; }
	private string Estado { get; set; }
	private string Borrado { get; set; }

	public Zapato(string marca, string nombre, string color, string precio, string formatouno, string formatodos, string formatotres, string estado)
    {
		Marca = marca;
		Nombre = nombre;
		Color = color;
		Precio = precio;
		Formatouno = formatouno;
		Formatodos = formatodos;
		Formatotres = formatotres;
		Estado = estado;
    }

	public Zapato(){}

    public override string ToString()
    {
        return base.ToString();
    }
}
