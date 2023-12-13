using System;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int Calificacion { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Calificación: {Calificacion}");
    }
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

        estudiante1.MostrarInformacion();
    }
}
