class Animal {

   public virtual void HacerSonido()
    {
        System.Console.WriteLine("Hacer sonido de animal");
    }
}


class Perro : Animal
{
    public override void HacerSonido()
    {
        System.Console.WriteLine("GUAU!");
    }
}

class Gato : Animal
{
    public override void HacerSonido()
    {
        System.Console.WriteLine("MIAU!");
    }
}


/*
 * 
 * 2. Crea una clase Animal y dos clases derivadas, Perro y Gato, que implementen un método HacerSonido().
 * 
 */