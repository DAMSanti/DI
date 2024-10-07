class Agenda() {
    List<Contacto> Contactos = new List<Contacto>();

    public void CrearContacto(string nombre, string telefono, string correo){
        Contacto contacto = new Contacto(nombre, telefono, correo);
        Contactos.Add(contacto);
    }

    public Contacto BuscarContacto(string nombre){
        return Contactos.Find(c => c.Nombre == nombre);
    }

    public void BorrarContacto(Contacto contacto){
        Contactos.Remove(contacto);
    }

    public void VerContactos(){
        foreach(Contacto contacto in Contactos){
            Console.WriteLine(contacto.ToString());
        }
    }

    public void VerCitas(){
        foreach(Contacto contacto in Contactos){
            contacto.VerCitas();
        }
    }
}

class Contacto {
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    List<Cita> Citas = new List<Cita>();

    public Contacto(string nombre, string telefono, string correo) {
        this.Nombre = nombre;
        this.Telefono = telefono;
        this.Correo = correo;
    }

    public void CrearCita(DateTime fechaCita, string lugar) {
        Cita cita = new Cita(fechaCita, lugar);
        Citas.Add(cita);
    }

    public Cita BuscarCita(DateTime fechaCita) {
        return Citas.Find(c => c.Fecha == fechaCita);
    }

    public void BorrarCita(Cita cita) {
        Citas.Remove(cita);
    }

    public void VerCitas() {
        foreach (Cita cita in Citas) {
            Console.WriteLine(cita.ToString());
        }
    }

    public override string ToString() {
        return $"Id: {id}, Nombre: {Nombre}, Telefono: {Telefono}, Correo: {Correo}";
    }

}

class Cita {
    public int idContacto { get; set; }
    public DateTime Fecha { get; set; }
    public string Lugar { get; set; }

    public Cita(DateTime fecha, string lugar) {
        Fecha = fecha;
        Lugar = lugar;
    }

    public override string ToString() {
        return $"IdContacto: {idContacto}, Fecha: {Fecha}, Lugar: {Lugar}";
    }
}


/*
 * 
 * 
 * 5. Escribe un programa que permita gestionar una agenda, para ello hará falta definir las entidades Agenda, Contacto y Cita.

La entidad Agenda consta de los siguientes atributos y métodos:

-Contactos -> colección con los contactos de la agenda

-CrearContacto(nombre, teléfono, correo)-> crea un nuevo contacto asignándole como Id el tamaño de la propiedad Contactos + 1.

-BuscarContacto(nombre):Contacto

-BorrarContacto(contacto)

-VerContactos()

-VerCitas()


La entidad Contacto consta de los siguientes atributos y métodos:

-Id

-Nombre

-Teléfono

-Correo

-Citas -> colección con las citas de la agenda

-CrearCita(fechaCita, lugar) -> crea una nueva Cita asignándole la el IdContacto.

-BuscarCita(fechaCita):Cita

-BorrarCita(Cita)

-VerCitas()


La entidad Cita consta de los siguientes atributos y métodos:

-IdContacto

-Fecha

-Lugar


Mediante un menú se podrán realizar las tareas de mantenimiento de la agenda. Evidentemente, tras seleccionar un contacto dispondremos de un submenú para gestión de sus Citas correspondientes.


*/