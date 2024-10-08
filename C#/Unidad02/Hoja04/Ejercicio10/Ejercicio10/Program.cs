class Libro {
    private string[] capitulos;
    public Libro(string[] capitulos) {
        this.capitulos = capitulos;
    }
    public string this[int index] {
        get {
            return capitulos[index];
        }
    }
}

class Program {
    static void Main() {
        string[] capitulos = new string[] {
            "Capitulo 1",
            "Capitulo 2",
            "Capitulo 3",
            "Capitulo 4",
            "Capitulo 5"
        };
        Libro libro = new Libro(capitulos);
        System.Console.WriteLine(libro[0]);
        System.Console.WriteLine(libro[1]);
        System.Console.WriteLine(libro[2]);
        System.Console.WriteLine(libro[3]);
        System.Console.WriteLine(libro[4]);
    }
}


/*
 * 
 * 10. Crea una clase llamada Libro que contenga una colección de capítulos. Implementa un indizador que permita acceder a los capítulos por su índice.
 * 
 */