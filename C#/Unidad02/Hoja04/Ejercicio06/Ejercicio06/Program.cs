interface IVolador
{
    void Volar();
}

class Ave : IVolador
{
    public void Volar()
    {
        System.Console.WriteLine("El ave está volando.");
    }
}

class Avion : IVolador
{
    public void Volar()
    {
        System.Console.WriteLine("El avión está volando.");
    }
}

class Program
{
    static void Main()
    {
        Ave ave = new Ave();
        Avion avion = new Avion();

        ave.Volar();
        avion.Volar();
    }
}

/*
 * 
 * 6. Crea una interfaz llamada IVolador que tenga un método Volar(). Luego, crea dos clases, Ave y Avion, que implementen esta interfaz. 
 * Escribe un programa que haga volar tanto a un ave como a un avión.
 * 
 * */