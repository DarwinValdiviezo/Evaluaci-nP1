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

class EstudianteGraduado : Estudiante
{
    public string Titulo { get; set; }
}

class Program
{
    static void Main()
    {
        EstudianteGraduado graduado1 = new EstudianteGraduado
        {
            Nombre = "Juan",
            Edad = 20,
            Calificacion = 5,
            Titulo = "Ingeniero en Software"
        };

        graduado1.MostrarInformacion();
        Console.WriteLine($"Título obtenido: {graduado1.Titulo}");
    }
}
