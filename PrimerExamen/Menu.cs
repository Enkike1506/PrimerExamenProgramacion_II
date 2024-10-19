using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class Menu
    {
        public static void MenuPrincipal()
        {
            //Se declara la variable en la que se almacenará la opción a realizar
            int opcion = 0;
            do
            {
                //Se muestra el menú principal
                Console.WriteLine("1. Inicializar arreglos");
                Console.WriteLine("2. Agregar empleados");
                Console.WriteLine("3. Consultar empleados");
                Console.WriteLine("4. Modificar empleados");
                Console.WriteLine("5. Borrar empleados");
                Console.WriteLine("6. Reportes");
                Console.WriteLine("7. Salir");
                //Se le solicita al usuario que ingrese la opción que desea realizar
                Console.Write("Ingrese la opción que desea realizar: ");
                //Se lee la opción ingresada por el usuario
                opcion = int.Parse(Console.ReadLine());

                //Switch que verificará la opción a realizar
                switch (opcion)
                {
                    //En caso de que sea 1
                    case 1:
                        //Se llama al método para inicializar los arreglos
                        Empleado.InicializarArreglos();
                        break;
                    //En caso de que sea 2
                    case 2:
                        //Se llama al método para agregar los empleados
                        Empleado.AgregarEmpleado();
                        break;
                    //En caso de que sea 3
                    case 3:
                        //Se llama al método para consultar a un empleado
                        Empleado.ConsultarEmpleado();
                        break;
                    //En caso de que sea 4
                    case 4:
                        //Se llama al método para modificar a un empleado
                        Empleado.ModificarEmpleado();
                        break;
                    //En caso de que sea 5
                    case 5:
                        //Se llama al método para borrar a un empleado
                        Empleado.BorrarEmpleado();
                        break;
                    //En caso de que sea 6
                    case 6:
                        //Se llama al método para mostrar el menú de los reportes
                        Menu.MenuReportes();
                        break;
                    //En caso de que sea 7
                    case 7:
                        Console.WriteLine("Gracias por usar nuestro sistema");
                        break;
                    //En caso de que no sea ninguna de las anteriores
                    default:
                        Console.WriteLine("La opción ingresada no es válida, por favor vuelva a intentarlo");
                        break;
                }
                //En caso de que sea 7 se sale del menú
            } while (opcion != 7);
        }

        //Método para mostrar menú de los reportes
        public static void MenuReportes()
        {
            //Se declara la variable en la que se almacenará la opción a realizar
            int opcion = 0;
            do
            {
                //Se muestra el menu de los reportes
                Console.WriteLine("1. Listar todos los empleados");
                Console.WriteLine("2. Mostrar el promedio de los salarios");
                Console.WriteLine("3. Salir");
                //Se le solicita al usuario que ingrese la opción que desea realizar
                Console.Write("Ingrese la opción que desea realizar: ");
                //Se lee la opción ingresada por el usuario
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    //En caso de que sea 1
                    case 1:
                        Empleado.ReporteEmpleados();
                        break;
                    //En caso de que sea 2
                    case 2:
                        Empleado.Promedio();
                        break;
                    //En caso de que sea 3
                    case 3:
                        Console.WriteLine("Gracias por usar nuestro sistema");
                        break;
                    //En caso de que no sea ninguna de las anteriores
                    default:
                        Console.WriteLine("La opción ingresada no es válida, por favor vuelva a intentarlo");
                        break;
                }
                //En caso de que sea 3 se sale del menú
            } while (opcion != 3);
        }
    }
}
