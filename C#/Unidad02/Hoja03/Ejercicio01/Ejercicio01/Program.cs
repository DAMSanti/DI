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
        return baseRectangulo*2 + alturaRectangulo*2;
    }
}

class  Triangulo : Figuras {
    double baseTriangulo { set; get; }
    double alturaTriangulo { set; get;}
    double[] ladosTriangulo { set; get; } = new double[3];

    public override double CalcularArea() {
        return (baseTriangulo * alturaTriangulo) / 2;
    }
    public override double CalcularPerimetro() {
        return ladosTriangulo[0]+ladosTriangulo[1]+ladosTriangulo[2];
    }
}

class Cuadrado : Figuras {
    double ladoCuadrado { set; get;}

    public override double CalcularArea() {
        return ladoCuadrado * ladoCuadrado;
    }
    public override double CalcularPerimetro() {
        return ladoCuadrado * 4;
    }
}
class Rombo : Figuras {
    double diagonalMayor { set; get; }
    double diagonalMenor { set; get; }
    public void setDiagonalMayor(double diagonalMayor) {
        this.diagonalMayor = diagonalMayor;
    }
    public void setDiagonalMenor(double diagonalMenor) {
        this.diagonalMenor = diagonalMenor;
    }
    public override double CalcularArea() {
        return (diagonalMayor * diagonalMenor) / 2;
    }

}
class Trapecio : Figuras {
    double baseMayor;
    double baseMenor;
    double alturaTrapecio;
    public override double CalcularArea() {
        return ((baseMayor + baseMenor) * alturaTrapecio) / 2;
    }
    public override double CalcularPerimetro() {
        return baseMayor + baseMenor + alturaTrapecio;
    }
}

public class Programa {
    public static void Main(string[] args) {
        bool salir = false;
        while (!salir) {
            string opcion = Menu();
            switch (opcion) {
                case "1":
                    int valor = int.Parse(Menu2());
                    var rectangulo = new Rectangulo();
                    if (valor == 1) {
                        Console.WriteLine("Introduce la base del rectangulo: ");
                        rectangulo.SetBaseRectangulo(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Introduce la altura del rectangulo: ");
                        rectangulo.SetAlturaRectangulo(int.Parse(Console.ReadLine()));
                        Console.WriteLine(rectangulo.CalcularArea());
                    } else if (valor == 2) {
                        Console.WriteLine("Introduce la base del rectangulo: ");
                        rectangulo.SetBaseRectangulo(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Introduce la altura del rectangulo: ");
                        rectangulo.SetAlturaRectangulo(int.Parse(Console.ReadLine()));
                        Console.WriteLine(rectangulo.CalcularPerimetro);
                    } else {
                        Console.WriteLine("Atrás");
                        break;
                    }
                    break;
                case "2":
                    Menu2();
                    var triangulo = new Triangulo();
                    Console.WriteLine(triangulo.CalcularArea());
                    break;
                case "3":
                    Menu2();
                    var cuadrado = new Cuadrado();
                    Console.WriteLine(cuadrado.CalcularArea());
                    break;
                case "4":
                    Menu2();
                    var rombo = new Rombo();
                    Console.WriteLine(rombo.CalcularArea());
                    break;
                case "5":
                    Menu2();
                    var trapecio = new Trapecio();
                    Console.WriteLine(trapecio.CalcularArea());
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