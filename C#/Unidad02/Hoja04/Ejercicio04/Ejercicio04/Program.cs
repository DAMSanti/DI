interface ITransporte
{
    void Arrancar();
    void Detener();
}

class Vehiculo
{
    public string Marca { get; set; }

    public void MostrarInformacion()
    {
        System.Console.WriteLine($"Marca: {Marca}");
    }
}

class Coche : Vehiculo, ITransporte
{
    public void Arrancar()
    {
        System.Console.WriteLine("Coche arrancado");
    }

    public void Detener()
    {
        System.Console.WriteLine("Coche detenido");
    }
}

class Moto : Vehiculo, ITransporte
{
    public void Arrancar()
    {
        System.Console.WriteLine("Moto arrancada");
    }

    public void Detener()
    {
        System.Console.WriteLine("Moto detenida");
    }
}

class Program
{
    static void Main()
    {
        Coche coche = new Coche();
        coche.Marca = "Ford";
        coche.Arrancar();
        coche.MostrarInformacion();
        coche.Detener();

        Moto moto = new Moto();
        moto.Marca = "Yamaha";
        moto.Arrancar();
        moto.MostrarInformacion();
        moto.Detener();
    }
}

//*
// * 
// * 
// * 4. Crea una interfaz ITransporte con los métodos Arrancar() y Detener(). Luego, crea una clase base Vehiculo que tenga una propiedad Marca y un método MostrarInformacion() que muestre la marca del vehículo.
//
//A partir de Vehiculo, crea dos clases derivadas: Coche y Moto, que implementen la interfaz ITransporte. Ambas clases deben proporcionar una implementación para los métodos de la interfaz, además de heredar el método MostrarInformacion() de la clase base.
//
//Escribe un programa que cree un objeto de tipo Coche y otro de tipo Moto, llame a sus métodos de la interfaz y muestre la información de cada vehículo.
//
//