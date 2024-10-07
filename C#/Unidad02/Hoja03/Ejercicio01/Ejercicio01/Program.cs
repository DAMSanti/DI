using System.ComponentModel.Design;

public class Figuras {
    double area;
    double perimetro;

    public Figuras() {
    }
    public virtual double CalcularArea() {
        return area;
    }
    public virtual double CalcularPerimetro() {
        return perimetro;
    }
}

class Rectangulo : Figuras {
    public double baseRectangulo { set; get; }
    public double alturaRectangulo { set; get; }

    public override double CalcularArea() {
        return baseRectangulo * alturaRectangulo;
    }
    public override double CalcularPerimetro() {
        return baseRectangulo * 2 + alturaRectangulo * 2;
    }
}

class Triangulo : Figuras {
    public double baseTriangulo { set; get; }
    public double alturaTriangulo { set; get; }
    public double[] ladosTriangulo { set; get; } = new double[3];

    public override double CalcularArea() {
        return (baseTriangulo * alturaTriangulo) / 2;
    }
    public override double CalcularPerimetro() {
        return ladosTriangulo[0] + ladosTriangulo[1] + ladosTriangulo[2];
    }
}

class Cuadrado : Figuras {
    public double ladoCuadrado { set; get; }

    public override double CalcularArea() {
        return ladoCuadrado * ladoCuadrado;
    }
    public override double CalcularPerimetro() {
        return ladoCuadrado * 4;
    }
}
class Rombo : Figuras {
    public double diagonalMayor { set; get; }
    public double diagonalMenor { set; get; }
    public double ladoA { set; get; }
    public double ladoB { set; get; }

    public void setDiagonalMayor(double diagonalMayor) {
        this.diagonalMayor = diagonalMayor;
    }
    public void setDiagonalMenor(double diagonalMenor) {
        this.diagonalMenor = diagonalMenor;
    }
    public override double CalcularArea() {
        return (diagonalMayor * diagonalMenor) / 2;
    }
    public override double CalcularPerimetro() {
        return ladoA*2 + ladoB*2;
    }

}
class Trapecio : Figuras {
    public double baseMayor { get; set; }
    public double baseMenor { get; set; }
    public double alturaTrapecio { get; set;}
    public override double CalcularArea() {
        return ((baseMayor + baseMenor) * alturaTrapecio) / 2;
    }
    public override double CalcularPerimetro() {
        double x = (baseMayor - baseMenor) / 2.0;
        double l = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(alturaTrapecio, 2));
        return baseMayor + baseMenor + 2*l;
    }
}

public class Programa {
    public static void Main(string[] args) {
        bool salir = false;
        int valor = 0;
        while (!salir) {
            string opcion = Menu();
            switch (opcion) {
                case "1":
                    valor = int.Parse(Menu2());
                    var rectangulo = new Rectangulo();
                    if (valor == 1) {
                        Console.WriteLine("Introduce la base del rectangulo: ");
                        rectangulo.baseRectangulo = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Introduce la altura del rectangulo: ");
                        rectangulo.alturaRectangulo = (int.Parse(Console.ReadLine()));
                        Console.WriteLine(rectangulo.CalcularArea());
                    } else if (valor == 2) {
                        Console.WriteLine("Introduce la base del rectangulo: ");
                        rectangulo.baseRectangulo = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Introduce la altura del rectangulo: ");
                        rectangulo.alturaRectangulo = (int.Parse(Console.ReadLine()));
                        Console.WriteLine(rectangulo.CalcularPerimetro());
                    } else {
                        Console.WriteLine("Atrás");
                    }
                    break;
                case "2":
                    valor = int.Parse(Menu2());
                    var triangulo = new Triangulo();
                    if (valor == 1) {
                        Console.WriteLine("Introduce la base del triangulo: ");
                        triangulo.baseTriangulo = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Introduce la altura del triangulo: ");
                        triangulo.alturaTriangulo = (int.Parse(Console.ReadLine()));
                        Console.WriteLine(triangulo.CalcularArea());
                    } else if (valor == 2) {
                        for (int i = 0; i < triangulo.ladosTriangulo.Length; i++) {
                            Console.WriteLine("Introduce el lado " + i + " del triangulo: ");
                            triangulo.ladosTriangulo[i] = (int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine(triangulo.CalcularPerimetro());
                    } else {
                        Console.WriteLine("Atrás");
                    }
                    break;
                case "3":
                    valor = int.Parse(Menu2());
                    var cuadrado = new Cuadrado();
                    if (valor == 1) {
                        Console.WriteLine("Introduce el lado del cuadrado: ");
                        cuadrado.ladoCuadrado = (int.Parse(Console.ReadLine()));
                        Console.WriteLine(cuadrado.CalcularArea());
                    } else if (valor == 2) {
                        Console.WriteLine("Introduce el lado del cuadrado: ");
                        cuadrado.ladoCuadrado = (int.Parse(Console.ReadLine()));
                        Console.WriteLine(cuadrado.CalcularPerimetro());
                    } else {
                        Console.WriteLine("Atrás");
                    }
                    break;
                case "4":
                    valor = int.Parse(Menu2());
                    var rombo = new Rombo();
                    if (valor == 1) {
                        Console.WriteLine("Introduce la diagonal mayor del rombo: ");
                        rombo.setDiagonalMayor(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Introduce la diagonal menor del rombo: ");
                        rombo.setDiagonalMenor(int.Parse(Console.ReadLine()));
                        Console.WriteLine(rombo.CalcularArea());
                    } else if (valor == 2) {
                        Console.WriteLine("Introduce el lado A del rombo: ");
                        rombo.ladoA = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el lado B del rombo: ");
                        rombo.ladoB = int.Parse(Console.ReadLine());
                        Console.WriteLine(rombo.CalcularPerimetro());
                    } else {
                        Console.WriteLine("Atrás");
                    }
                    break;
                case "5":
                     valor = int.Parse(Menu2());
                     var trapecio = new Trapecio();
                    if (valor == 1) {
                        Console.WriteLine("Introduce la base mayor del trapecio: ");
                        trapecio.baseMayor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la base menor del trapecio: ");
                        trapecio.baseMenor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del trapecio: ");
                        trapecio.alturaTrapecio = int.Parse(Console.ReadLine());
                        Console.WriteLine(trapecio.CalcularArea());
                    } else if (valor == 2) {
                        Console.WriteLine("Introduce la base mayor del trapecio: ");
                        trapecio.baseMayor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la base menor del trapecio: ");
                        trapecio.baseMenor = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura del trapecio: ");
                        trapecio.alturaTrapecio = int.Parse(Console.ReadLine());
                        Console.WriteLine(trapecio.CalcularArea());
                    } else {
                        Console.WriteLine("Atrás");
                    }
                    break;
                    case "6":
                        salir = true;
                        break;
                    }
                }
            }
        
        public static string Menu() {
            Console.WriteLine("CALCULADORA DE FIGURAS\n\t1. Rectangulo\n\t2. Triangulo\n\t3. Cuadrado\n\t4. Rombo\n\t5. Trapecio\n\t6. Salir\n\nElige una opcion: ");
            return Console.ReadLine();
        }

        public static String Menu2() {
            Console.WriteLine("CALCULADORA DE FIGURAS\n\t1. Calcular Area\n\t2. Calcular Perimetro\n\t3. Atrás\n\nElige una opcion: ");
            return Console.ReadLine();
        }
    }




/*
 * 
 * 1. Crea una clase Figuras y varias clases derivadas para calcular el área y el perímetro de rectángulo, triángulo, cuadrado, rombo y trapecio.
 * 
 */