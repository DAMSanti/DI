class Alumno
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Alumno(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}";
    }
}

class Aula
{
    private Alumno[] alumnos;

    public Aula(int cantidadAlumnos)
    {
        alumnos = new Alumno[cantidadAlumnos];
    }

    public Alumno this[int index]
    {
        get
        {
            return alumnos[index];
        }
        set
        {
            alumnos[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Aula aula = new Aula(5);
        aula[0] = new Alumno("Juan", 20);
        aula[1] = new Alumno("Pedro", 21);
        aula[2] = new Alumno("Maria", 22);
        aula[3] = new Alumno("Ana", 23);
        aula[4] = new Alumno("Luis", 24);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(aula[i]);
        }
    }
}

/*
 * 
 * 9. Crea una clase llamada Aula que represente un aula con un número determinado de alumnos. 
 * La clase debe tener un indizador que permita acceder a los alumnos por su índice
 * 
 * */