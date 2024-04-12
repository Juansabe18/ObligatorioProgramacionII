using Dominio;

namespace Consola
{
    internal class MainConsole
    {
        static void Main(string[] args)        {
            Console.WriteLine("No se ha roto nada!");

            DateTime fecha = DateTime.Now;
            DateTime fecha2 = fecha.AddYears(1);
            Console.WriteLine(fecha);
            Console.WriteLine(fecha2);

        }
    }
}
