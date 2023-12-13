using System;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Calificacion { get; set; }
}

class Program
{
    static void Main()
    {
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Juan",
            Edad = 20,
            Calificacion = 5
        };

        Console.WriteLine($"Nombre: {estudiante1.Nombre}, Edad: {estudiante1.Edad}, Calificación: {estudiante1.Calificacion}");
    }
}
