class Autobus {
    public bool[] plazas;

    public Autobus(int plazas) {
        this.plazas = new bool[plazas];
    }

    public Autobus this[int i] {   
        get {
            foreach (bool plaza in plazas) {
                if (plaza) {
                    return this;
                }
            }
            return null;
        }
    }

    public int Ocupadas {
        get {
            int ocupadas = 0;
            for (int i = 0; i < plazas.Length; i++) {
                if (plazas[i]) {
                    ocupadas++;
                }
            }
            return ocupadas;
        }
    }

    public int Plazas {
        get {
            return plazas.Length;
        }
    }

    public int[] PlazasLibres {
        get {
            int[] libres = new int[plazas.Length - Ocupadas];
            int j = 0;
            for (int i = 0; i < plazas.Length; i++) {
                if (!plazas[i]) {
                    libres[j] = i;
                    j++;
                }
            }
            return libres;
        }
    }
}

class Program {
     public static void Main(string[] args) {
        Autobus bus = new Autobus(10);
        Autobus buses = bus[3];
        if (buses != null) {
            Console.WriteLine("Plaza ocupada");
        } else {
            Console.WriteLine("Plaza libre");
        }
    }
}



/*
 * 
 * 1. INDIZADORES. Implementa la clase autobús, la clase autobús dispondrá de un array de booleanos para indicar si una plaza está ocupada, el número de plazas será necesario indicarlo a la hora de instanciar un autobús. Se podrá saber si una plaza está ocupada a través de un indizador que reciba como parámetro el número de plaza y devuelva verdadero o falso en función de si el asiento está ocupado o no.

Implementar una propiedad Ocupadas que me indique el número de plazas reservadas, otra propiedad Plazas que me indique el número de plazas totales del autobús. Una función PlazasLibres que me devuelva los números de plaza libres y otra función ReservarPlaza que reciba el número de plaza y trate de reservarla, si la plaza ya está ocupada devolverá false y se notificara al usuario.

Crear el código necesario para poder probar toda la funcionalidad requerida ofertándola al usuario a través de un menú de selección.

*/