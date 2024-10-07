class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("Sonido de animal");
    }
}

class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Guau");
    }
}

class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Miau");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animales = new List<Animal>();
        animales.Add(new Perro());
        animales.Add(new Gato());

        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
        }
    }
}

/*
 * 
 * 3. Crea una lista Animal y añade diferentes tipos de animales. Usa polimorfismo para llamar al método HacerSonido().
 * 
 */
