using System;

namespace AvanzadaTarea1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Operaciones op = new Operaciones();

            bool continuar = true;

            do
            {
                Console.WriteLine("***AGROGANADERA MI FINCA***\n\n");
                Console.WriteLine("Por favor ingrese una de las siguientes opciones:\n");
                Console.WriteLine("1. Registrar finca");
                Console.WriteLine("2. Registrar dueño");
                Console.WriteLine("3. Registrar empleado");
                Console.WriteLine("4. Registrar raza de animales");
                Console.WriteLine("5. Registrar animales");
                Console.WriteLine("6. Mostrar los registros");
                Console.WriteLine("7. Salir\n");
                Console.Write("Tu elección: ");

                string opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":   Console.WriteLine(op.RegistrarFinca());
                                break;
                    case "2":   Console.WriteLine(op.RegistrarDueno());
                                break;
                    case "3":   Console.WriteLine(op.RegistrarEmpleado());
                                break;
                    case "4": break;
                    case "5": break;
                    case "6": break;
                    case "7":
                        bool salir = false;
                        Console.Clear();

                        do
                        {

                            Console.WriteLine("\n¿Está realmente seguro de que desea salir? S/N");
                            Console.Write("\nTu elección: ");
                            string respuesta = Console.ReadLine().ToUpper();

                            if (respuesta == "S")
                            {
                                continuar = false;
                                salir = true;
                                Console.WriteLine("\n¡Hasta luego!\n\n");
                            }
                            else if (respuesta == "N")
                            {
                                salir = true;
                                Console.Clear();

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\nPor favor ingrese una opción válida: S/N");

                            }
                        }while (!salir);

                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("\nPor favor ingrese una opción válida.\n");
                        break;
                } 

            } while (continuar);

            //Fecha de nacimiento
            //DateTime thisDate1 = new DateTime(2020, 2, 12);
            //Console.WriteLine(thisDate1.ToString("dd-MM-yy") + ".");
        }
    }
}
