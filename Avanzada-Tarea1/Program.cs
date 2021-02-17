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
                    case "4":   Console.WriteLine(op.RegistrarRaza());
                                break;
                    case "5":   Console.WriteLine(op.RegistrarAnimal());
                                break;
                    case "6":

                        bool seguir = true;

                        do
                        {
                            Console.WriteLine("Elige una de las siguientes opciones:\n\n");
                            Console.WriteLine("1. Lista de fincas");
                            Console.WriteLine("2. Lista de dueños");
                            Console.WriteLine("3. Lista de empleados");
                            Console.WriteLine("4. Lista de razas");
                            Console.WriteLine("5. Lista de animales");
                            Console.WriteLine("6. Regresar al menú\n\n");

                            Console.Write("Tu elección: ");
                            string eleccion = Console.ReadLine();

                            switch (eleccion)
                            {
                                case "1":   
                                    Console.WriteLine(op.ListaFincas());
                                    Console.WriteLine("\n\nPresione una tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "2":
                                    Console.WriteLine(op.ListaDuenos());
                                    Console.WriteLine("\n\nPresione una tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "3":
                                    Console.WriteLine(op.ListaEmpleados());
                                    Console.WriteLine("\n\nPresione una tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "4":
                                    Console.WriteLine(op.ListaRazas());
                                    Console.WriteLine("\n\nPresione una tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "5":
                                    Console.WriteLine(op.ListaAnimales());
                                    Console.WriteLine("\n\nPresione una tecla para continuar");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "6":   Console.Clear();
                                            seguir = false;
                                            break;
                                default: Console.WriteLine("Por favor ingrese una opción correcta. \n\n");
                                    break;
                            }
                        } while (seguir);

                        break;
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

        }
    }
}
