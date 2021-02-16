using System;
namespace AvanzadaTarea1
{
    public class Operaciones
    {
        public Operaciones()
        {
        }

        //acá van los objetos necesario
        Dueno[] dueno = new Dueno[10];
        Finca[] finca = new Finca[10];
        Empleado[] empleado = new Empleado[10];
        Animal[] animal = new Animal[10];
        Raza[] raza = new Raza[10];

        //contadores
        int contadorDueno = 0;
        int contadorFinca = 0;
        int contadorEmpleado = 0;
        int contadorAnimal = 0;
        int contadorRaza = 0;

        //métodos del menú
        public string RegistrarFinca()
        {
            bool seguir = true;



            do
            {
                if (contadorFinca >= 10)
                    return "Lo sentimos. Ya no se pueden registrar fincas. Cupos llenos (10)";

                Console.WriteLine("***REGISTRAR FINCA***\n\n");

                bool continuar = true;

                int numeroFinca = 0;
                double tamanioFinca = 0.0;

                do
                {
                    //verifico que sea entero
                    try
                    {
                        Console.Write("Ingrese el número de finca: ");


                        numeroFinca = Convert.ToInt32(Console.ReadLine());

                        //verifica que no exista una finca con el mismo numero
                        if (ExisteFinca(numeroFinca))
                        {
                            Console.Clear();
                            Console.WriteLine("Ya existe una finca con ese número. Intente de nuevo.\n\n");
                        }
                        else
                        {
                            continuar = false;
                            Console.Clear();
                        }

                    }
                    catch(Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe digitar un dato numérico. Intente de nuevo.\n\n");
                    }
                } while (continuar);


                Console.Write("Ingrese el nombre de la finca: ");
                string nombre = Console.ReadLine();
                Console.Clear();

                do
                {
                
                    //verifico que sea entero
                    try
                    {
                        Console.Write("Ingrese el tamaño de la finca: ");
                        tamanioFinca = Convert.ToDouble(Console.ReadLine());
                        continuar = false;
                        Console.Clear();
                    }
                    catch(Exception e)
                    {
                        Console.Clear();
                        continuar = true;
                        Console.WriteLine("Debe digitar un dato numérico. Intente de nuevo.\n\n");
                    }
                } while (continuar);

                Console.Write("Ingrese la dirección de la finca: ");
                string direccion = Console.ReadLine();
                Console.Clear();

                Console.Write("Ingrese el teléfono de la finca: ");
                string telefono = Console.ReadLine();
                Console.Clear();

                //se guardan los datos en finca
                Finca nuevaFinca = new Finca(numeroFinca, nombre, tamanioFinca, direccion, telefono);
                finca[contadorFinca] = nuevaFinca;
                contadorFinca++;

                bool salirDelCiclo = true;
                do
                {
                    Console.Clear();
                    Console.Write("¿Desea agregar otra finca? S/N: ");
                    string respuesta = Console.ReadLine().ToUpper();

                    if (respuesta == "S")
                    {
                        salirDelCiclo = true;
                        Console.Clear();
                    }
                    else if (respuesta == "N")
                    {
                        salirDelCiclo = true;
                        seguir = false;
                        Console.Clear();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nPor favor ingrese una opción válida: S/N");

                    }
                } while (!salirDelCiclo);

            } while (seguir);

            return "Finca registrada con éxito\n\n";
        }


        public string RegistrarDueno()
        {
            bool seguir = true;
            int idDueno = 0;
            int idFinca = 0;
            Finca fincaDueno = null;

            //verifica que existan fincas
            if (contadorFinca == 0)
                return "NO existen fincas registradas. Registre una finca primero\n\n";

            Console.WriteLine("***REGISTRAR DUEÑO***\n\n");

            do
            {
                bool continuar = true;

                if (contadorDueno >= 10)
                    return "Lo sentimos. Ya no se pueden registrar dueños. Cupos llenos (10)";

                do
                {
                
                    try
                    {
                        Console.Write("Ingrese la identificación o id: ");
                        idDueno = Convert.ToInt32(Console.ReadLine());

                        //verifico que no exista un id igual
                        if (ExisteDueno(idDueno))
                        {
                            Console.Clear();
                            Console.WriteLine("Ya existe un dueño con ese ID. Intente de nuevo.\n\n");
                        }
                        else
                        {
                            continuar = false;
                            Console.Clear();
                        }
                    }
                    catch(Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe digitar un dato numérico. Intente de nuevo.\n\n");
                    }

                } while (continuar);

                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
                Console.Clear();

                Console.Write("Ingrese su primer apellido: ");
                string primerApellido = Console.ReadLine();
                Console.Clear();

                Console.Write("Ingrese su segundo apellido: ");
                string segundoApellido = Console.ReadLine();
                Console.Clear();

                Console.Write("Ingrese su correo: ");
                string correo = Console.ReadLine();
                Console.Clear();

                Console.Write("Ingrese su número celular: ");
                string celular = Console.ReadLine();
                Console.Clear();

                bool fincaIncorrecta = true;

                do
                {
                    //verifico que sea entero
                    try
                    {
                        Console.Write("Ingrese el número de finca: ");

                        idFinca = Convert.ToInt32(Console.ReadLine());

                        //verifica que exista la finca
                        if (ExisteFinca(idFinca))
                        {

                            if (ExisteDuenoFinca(idFinca))
                            {
                                Console.Clear();
                                Console.WriteLine("La finca ingresada ya cuenta con un dueño. Intente otro número\n\n");
                            }

                            else
                            {
                                //busca la finca y la agrega a un nuevo onjeto
                                fincaDueno = BuscaFinca(idFinca);

                                fincaIncorrecta = false;
                                continuar = false;
                                Console.Clear();
                            }
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("EL número de finca ingresado no coincide con las fincas registradas. Intente de nuevo\n\n");
                        }

                    }
                    catch(Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe digitar un dato numérico. Intente de nuevo.\n\n");
                    }
                } while (fincaIncorrecta);

                // datos del arreglo
                Dueno duenoNuevo = new Dueno(idDueno, nombre, primerApellido, segundoApellido,
                 correo, celular, fincaDueno);

                dueno[contadorDueno] = duenoNuevo;
                contadorDueno++;

                bool salirDelCiclo = true;
                do
                {
                    Console.Clear();
                    Console.Write("¿Desea agregar otro dueño? S/N: ");
                    string respuesta = Console.ReadLine().ToUpper();

                    if (respuesta == "S")
                    {
                        salirDelCiclo = true;
                        Console.Clear();
                    }
                    else if (respuesta == "N")
                    {
                        salirDelCiclo = false;
                        seguir = false;
                        Console.Clear();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nPor favor ingrese una opción válida: S/N");

                    }
                } while (!salirDelCiclo);
            } while (seguir);


            return "Dueño registrado con éxito\n\n";
        }

        public string RegistrarEmpleado()
        {
            bool seguir = true;
            double salario = 0;
            int idEmpleado = 0;

            Console.WriteLine("***REGISTRAR EMPLEADO***\n\n");

            do
            {
                if (contadorEmpleado >= 10)
                    return "Lo sentimos, ya no se pueden registrar más empleados\n\n";

                bool continuar = true;

                do
                {
                    try
                    {
                        Console.Write("Ingrese el id de empleado: ");
                        idEmpleado = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (ExisteEmpleado(idEmpleado))
                        {
                            Console.Clear();
                            Console.WriteLine("Ya existe un empleado con ese ID. Intente de nuevo.\n\n");
                        }
                        else
                        {
                            continuar = false;
                        }
                    }
                    catch(FormatException e)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe digitar un dato numérico. Intente de nuevo.\n\n");
                    }
                } while (continuar);


                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
                Console.Clear();

                Console.Write("Ingrese su primer apellido: ");
                string primerApellido = Console.ReadLine();
                Console.Clear();

                Console.Write("Ingrese su segundo apellido: ");
                string segundoApellido = Console.ReadLine();
                Console.Clear();

                do
                {
                    continuar = true;

                    try
                    {
                        Console.Write("Ingrese el monto del sueldo: ");
                        salario = Convert.ToDouble(Console.ReadLine());

                        continuar = false;
                    }
                    catch (FormatException e)
                    {
                        Console.Clear();
                        Console.WriteLine("Debe digitar un dato numérico. Intente de nuevo.\n\n");
                    }

                } while (continuar);

                Empleado empleadoNuevo = new Empleado(idEmpleado, nombre, primerApellido, segundoApellido, salario);

                //se pasa al objeto empleado
                empleado[contadorEmpleado] = empleadoNuevo;
                contadorEmpleado++;

                bool salirDelCiclo = true;
                do
                {
                    Console.Clear();
                    Console.Write("¿Desea agregar otro empleado? S/N: ");
                    string respuesta = Console.ReadLine().ToUpper();

                    if (respuesta == "S")
                    {
                        salirDelCiclo = true;
                        Console.Clear();
                    }
                    else if (respuesta == "N")
                    {
                        salirDelCiclo = false;
                        seguir = false;
                        Console.Clear();

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nPor favor ingrese una opción válida: S/N");
                    }

                } while (!salirDelCiclo);

            } while (seguir);

            return "Empleado agregado con éxito\n\n";
        }



        public bool ExisteFinca(int id)
        {
            //se verifica que exista al menos una finca
            if (contadorFinca == 0)
                return false;

            try
            {
                foreach (Finca f in finca)
                {
                    if (f.NoFinca == id)
                        return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }


            return false;
        }

        public bool ExisteDueno(int id)
        {
            //se verifica que exista al menos un dueño
            if (contadorDueno == 0)
                return false;

            try
            {
                foreach (Dueno d in dueno)
                {
                    if (d.Id == id)
                        return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }


            return false;
        }

        public bool ExisteDuenoFinca(int idFinca)
        {
            try
            {
                foreach (Dueno d in dueno)
                {
                    if (d.FincaAsociada.NoFinca == idFinca)
                        return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }


            return false;
        }


        public Finca BuscaFinca(int id)
        {
            foreach(Finca f in finca)
            {
                if(f.NoFinca == id)
                {
                    return f;
                }
            }

            return null;
        }


        public bool ExisteEmpleado(int id)
        {
            try
            {
                foreach (Empleado e in empleado)
                {
                    if (e.Id == id)
                        return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }


            return false;
        }
    }
}
