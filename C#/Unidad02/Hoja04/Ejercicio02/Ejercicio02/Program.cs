interface IDispositivoElectronico {
    void Encender();
    void Apagar();
}

class Television : IDispositivoElectronico {
    public bool Estado { get; set; }

    public void Encender() {
        Estado = true;
    }

    public void Apagar() {
        Estado = false;
    }
}

class Radio : IDispositivoElectronico {
    public bool Estado { get; set; }

    public void Encender() {
        Estado = true;
    }

    public void Apagar() {
        Estado = false;
    }
}

class  Program {
    static void Main() {
        Television television = new Television();
        television.Encender();
        System.Console.WriteLine(television.Estado);

        Radio radio = new Radio();
        radio.Encender();
        System.Console.WriteLine(radio.Estado);
    }
}

/*
 * 
 * 2. Crea una interfaz llamada IDispositivoElectronico que tenga los métodos Encender y Apagar.
 * Luego crea las clases Televisión y Radio, las cuales implementará esta interfaz. 
 * Ambas clases deben tener una propiedad Estado que indique si el dispositivo está encendido o apagado 
 * Escribe un programa que instancie objetos de ambas clases, los encienda, y luego imprima el estado actual del dispositivo
 * 
 */