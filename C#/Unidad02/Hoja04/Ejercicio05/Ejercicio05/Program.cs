interface ITrabajador
{
    void Trabajar();
    void CobrarSalario();
}

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void MostrarInformacion()
    {
        System.Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}

class Empleado : Persona, ITrabajador
{
    public void Trabajar()
    {
        System.Console.WriteLine("El empleado está trabajando.");
    }

    public void CobrarSalario()
    {
        System.Console.WriteLine("El empleado cobra un salario fijo.");
    }
}

class Freelancer : Persona, ITrabajador
{
    public void Trabajar()
    {
        System.Console.WriteLine("El freelancer está trabajando.");
    }

    public void CobrarSalario()
    {
        System.Console.WriteLine("El freelancer cobra por proyecto.");
    }
}

class Program
{
    static void Main()
    {
        Empleado empleado = new Empleado();
        empleado.Nombre = "Juan";
        empleado.Edad = 30;
        empleado.MostrarInformacion();
        empleado.Trabajar();
        empleado.CobrarSalario();

        Freelancer freelancer = new Freelancer();
        freelancer.Nombre = "Ana";
        freelancer.Edad = 25;
        freelancer.MostrarInformacion();
        freelancer.Trabajar();
        freelancer.CobrarSalario();
    }
}

/*
 * 
 * 5. Crea una interfaz ITrabajador que tenga los métodos Trabajar() y CobrarSalario(). Luego, crea una clase base Persona que tenga las propiedades Nombre y Edad, y un método MostrarInformacion() que muestre el nombre y la edad de la persona.

A partir de la clase Persona, crea dos clases derivadas: Empleado y Freelancer, que implementen la interfaz ITrabajador. El método Trabajar() debe mostrar mensajes diferentes para un empleado y un freelancer, y el método CobrarSalario() debe reflejar sus diferencias, por ejemplo, un empleado cobra un salario fijo y un freelancer cobra por proyecto.

Escribe un programa que cree un objeto de tipo Empleado y otro de tipo Freelancer, muestre su información y haga que trabajen y cobren su salario.

*/