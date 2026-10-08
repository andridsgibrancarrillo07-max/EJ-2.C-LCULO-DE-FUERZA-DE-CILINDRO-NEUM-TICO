Console.WriteLine("CÁLCULO DE FUERZA DE CILINDRO NEUMÁTICO");
Console.WriteLine();

                                                                   // Crear un objeto de la clase Cilindro
Cilindro cilindro1 = new Cilindro();

                                                                  // Capturar la información del objeto
Console.Write("Ingrese la presión en kPa: ");
cilindro1.Presion = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el área efectiva del pistón en cm²: ");
cilindro1.Area = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el requerimiento mínimo de fuerza en N: ");
double fuerzaMinima = Convert.ToDouble(Console.ReadLine());

                                                                // Solicitar al objeto que calcule la fuerza
double fuerza = cilindro1.CalcularFuerza();

                                                               // Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Presión: {cilindro1.Presion:F2} kPa");
Console.WriteLine($"Área: {cilindro1.Area:F2} cm²");
Console.WriteLine($"Fuerza generada: {fuerza:F2} N");
Console.WriteLine($"Estado: {cilindro1.ObtenerEstado(fuerzaMinima)}");

                                                             // Definición de la clase
class Cilindro
{
                                                              // Propiedades
    public double Presion { get; set; }

    public double Area { get; set; }

                                                             // Método para calcular la fuerza
    public double CalcularFuerza()
    {
        double presionPa;
        double areaM2;
        double fuerza;

        presionPa = Presion * 1000.0;
        areaM2 = Area / 10000.0;
        fuerza = presionPa * areaM2;

        return fuerza;
    }

                                                           // Método para determinar el estado
    public string ObtenerEstado(double fuerzaMinima)
    {
        double fuerza = CalcularFuerza();

        if (fuerza >= fuerzaMinima)
        {
            return "Cumple el requerimiento";
        }
        else
        {
            return "No cumple el requerimiento";
        }
    }
}