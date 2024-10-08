class Mascota : IComparable
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public int CompareTo(object obj)
    {
        Mascota m = (Mascota)obj;
        return this.Edad.CompareTo(m.Edad);
    }
}

class Program
{
    static void Main()
    {
        Mascota[] mascotas = new Mascota[5];
        for (int i = 0; i < mascotas.Length; i++)
        {
            mascotas[i] = new Mascota();
            Console.Write("Nombre de la mascota: ");
            mascotas[i].Nombre = Console.ReadLine();
            Console.Write("Edad de la mascota: ");
            mascotas[i].Edad = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(mascotas);
        Console.WriteLine("Mascotas ordenadas por edad:");
        foreach (Mascota m in mascotas)
        {
            Console.WriteLine(m.Nombre);
        }
    }
}

/*
 * 
 * 2. Interfaces, ordenación, IComparable Crea una clase Mascota que disponga de las propiedades nombre y edad, 
 * la clase implementara la interfaz IComparable la cual permite comparar dos objetos. 
 * Después se pedirá al usuario los datos de 5 mascotas y el programa mostrará sus nombres ordenados por edad usando el método CompareTo de la interfaz.
 * 
 */