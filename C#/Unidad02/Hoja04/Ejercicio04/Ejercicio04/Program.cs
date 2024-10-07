class Aula {
    private int[] alumnos;

    public Aula(int numeroAlumnos)
    {
        alumnos = new int[numeroAlumnos];
    }

    public int this[int index] {
        get {
            foreach (int alumno in alumnos) {
                if (alumno == index) {
                    return alumno;
                }
            }
            return -1;
        }
    }
}

/*
 * 
 * 4. Crea una clase llamada Aula que represente un aula con un número determinado de alumnos. La clase debe tener un indizador que permita acceder a los alumnos por su índice
 * 
 */