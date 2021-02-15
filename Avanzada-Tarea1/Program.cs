using System;

namespace AvanzadaTarea1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dueno d = new Dueno
            {
                Nombre = "Jeffrey Munoz Castro"
            };

            Console.WriteLine(d.Nombre);
        }
    }
}
