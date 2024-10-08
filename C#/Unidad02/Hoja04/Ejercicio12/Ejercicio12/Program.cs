class Libro : IComparable {
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public int CompareTo(object obj) {
        Libro libro = (Libro)obj;
        return this.Titulo.CompareTo(libro.Titulo);
    }
}

class Program {
    static void Main() {
        List<Libro> libros = new List<Libro> {
            new Libro { Titulo = "El señor de los anillos", Autor = "J.R.R. Tolkien" },
            new Libro { Titulo = "Harry Potter", Autor = "J.K. Rowling" },
            new Libro { Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez" }
        };

        libros.Sort();

        foreach (Libro libro in libros) {
            Console.WriteLine($"{libro.Titulo} - {libro.Autor}");
        }
    }
}

/*
 * 
 * 12. Crea una clase llamada Libro con propiedades para Titulo y Autor. Luego, implementa un comparador que ordene los libros alfabéticamente por título.
 * 
 */