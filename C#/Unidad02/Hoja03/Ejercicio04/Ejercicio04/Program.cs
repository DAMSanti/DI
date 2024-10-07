class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int Paginas { get; set; }
    public string Editorial { get; set; }
    public string Resumen { get; set; }
    public string[] Capitulos { get; set; }

    public Libro(string titulo, string autor, string isbn, int paginas, string editorial, string resumen, string[] capitulos)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Paginas = paginas;
        Editorial = editorial;
        Resumen = resumen;
        Capitulos = capitulos;
    }

    public void toString()
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Paginas: {Paginas}");
        Console.WriteLine($"Editorial: {Editorial}");
        Console.WriteLine($"Resumen: {Resumen}");
        Console.WriteLine("Capitulos:");
        foreach (var capitulo in Capitulos)
        {
            Console.WriteLine($"- {capitulo}");
        }
    }

    public void addCapitulo(string capitulo)
    {
        List<string> capitulos = Capitulos.ToList();
        capitulos.Add(capitulo);
        Capitulos = capitulos.ToArray();
    }

    public void removeCapitulo(string capitulo)
    {
        List<string> capitulos = Capitulos.ToList();
        capitulos.Remove(capitulo);
        Capitulos = capitulos.ToArray();
    }

    public void editCapitulo(string capitulo, string nuevoCapitulo)
    {
        List<string> capitulos = Capitulos.ToList();
        int index = capitulos.IndexOf(capitulo);
        capitulos[index] = nuevoCapitulo;
        Capitulos = capitulos.ToArray();
    }
}




/*
 * 
 * 4. Crea una clase Libro que contenga atributos y métodos para gestionar un libro.
 * 
 */