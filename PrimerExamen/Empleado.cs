using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamen
{
    internal class Empleado
    {
        //Arreglo que almacena el número de identificación
        public static string[] id = new string[10];
        //Arreglo que almacena el nombre
        public static string[] nombre = new string[10];
        //Arreglo que almacena la dirección
        public static string[] direccion = new string[10];
        //Arreglo que almacena el númeo de teléfono
        public static string[] telefono = new string[10];
        //Arreglo que almacena el salario
        public static double[] salario = new double[10];

        //Método para inicializar los arreglos
        public static void InicializarArreglos()
        {
            //Ciclo for que recorrerá todo el arreglo
            for(int i = 0; i < id.Length; i++)
            {
                //Se le asigna un valor vacío o 0 a cada uno de los arreglos
                id[i] = string.Empty;
                nombre[i] = string.Empty;
                direccion[i] = string.Empty;
                telefono[i] = string.Empty;
                salario[i] = 0;
            }
            //Se le notifica al usuario que los arreglos ya han sido inicializados
            Console.WriteLine("Los arreglos han sido inicializados");
            //Se espera a que el usuario presione una tecla para seguir
            Console.ReadKey();
            //Se borra todo el contenido que se muestra en la consola
            Console.Clear();
        } 

        //Método para añadir empleados
        public static void AgregarEmpleado()
        {
            //Ciclo for que recorrerá todo el arreglo
            for (int i = 0; i < id.Length; i++)
            {
                //Se le solicita al usuario que ingrese el número de identificación
                Console.Write("Ingrese el número de identificación del empleado: ");
                //Se lee el número de identificación ingresado por el usuario
                id[i] = Console.ReadLine();
                //Se le solicita al usuario que ingrese el nombre
                Console.Write("Ingrese el nombre del empleado: ");
                //Se lee el nombre ingresado por el usuario
                nombre[i] = Console.ReadLine();
                //Se le solicita al usuario que ingrese la dirección
                Console.Write("Ingrese la dirección del empleado: ");
                //Se lee la dirección ingresada por el usuario
                direccion[i] = Console.ReadLine();
                //Se le solicita al usuario que ingrese el número de teléfono
                Console.Write("Ingrese el teléfono del empleado: ");
                //Se lee el número de teléfono ingresado por el usuario
                telefono[i] = Console.ReadLine();
                //Se le solicita al usuario que ingrese el salario
                Console.Write("Ingrese el salario del empleado: ");
                //Se lee el salario ingresado por el usuario
                salario[i] = double.Parse(Console.ReadLine());
            } 
            //Se le notifica al usuario que los empleados ya han sido añadidos
            Console.WriteLine("Se han añadido correctamente los empleados");
            //Se espera a que el usuario presione una tecla para seguir
            Console.ReadKey();
            //Se borra todo el contenido que se muestra en la consola
            Console.Clear();
        } 

        //Método para consultar un empleado
        public static void ConsultarEmpleado()
        {
            //Se declara una variable vacía para almacenar el número de identificación del empleado que se quiere consultar
            string idAConsultar = String.Empty;
            //Se le solicita al usuario que ingrese el número de identificación del empleado a consultar
            Console.Write("Ingrese el número de identificación del empleado que desea consultar: ");
            //Se lee el número de identificación ingresado por el usuario
            idAConsultar = Console.ReadLine();

            //ciclo for que recorrerá todo el arreglo
            for (int i = 0; i < id.Length; i++)
            {
                if (idAConsultar == id[i])
                {
                    //Si es verdadero se le muestra al usuario los datos del empleado solicitado
                    Console.WriteLine($"El nombre del empleado es {nombre[i]}, con un número de identificación {id[i]}" +
                        $", con un salario de {salario[i]}, con una dirección {direccion[i]}" +
                        $" y su número de teléfono es {telefono[i]}");
                }
            }
            //Se espera a que el usuario presione una tecla para seguir
            Console.ReadKey();
            //Se borra todo el contenido que se muestra en la consola
            Console.Clear();
        } 

        //Método para eliminar algún empleado en concreto
        public static void BorrarEmpleado()
        {
            //Se declara una variable vacía para almacenar el número de identificación del empleado que se quiere eliminar
            string idABorrar = String.Empty;
            //Se le solicita al usuario que ingrese el número de identificación del empleado a eliminar
            Console.Write("Ingrese el número de identificación del empleado que desea borrar del sistema: ");
            //Se lee el número de identificación ingresado por el usuario
            idABorrar = Console.ReadLine();
            
            //ciclo for que recorrerá todo el arreglo
            for (int i = 0; i < id.Length; i++)
            {
                //Se crea una condicional para verificar si el número de identificación ingresado es igual al que está guardado
                if(idABorrar == id[i])
                {
                    //Si eso se cumple se reestablecen todos los datos de dicho empleado
                    id[i] = String.Empty;
                    nombre[i] = String.Empty;
                    direccion[i] = String.Empty;
                    telefono[i] = String.Empty;
                    salario[i] = 0;
                }
            }
            //Se le notifica al usuario que el empleado ya ha sido borrado
            Console.WriteLine("El empleado ha sido eliminado correctamente");
            //Se espera a que el usuario presione una tecla para seguir
            Console.ReadKey();
            //Se borra todo el contenido que se muestra en la consola
            Console.Clear();
        } 

        //Método para modificar algún empleado
        public static void ModificarEmpleado()
        {
            //Se declara una variable vacía para almacenar el número de identificación del empleado que se quiere modificar
            string idAModificar = String.Empty;
            //Se le solicita al usuario que ingrese el número de identificación del empleado a modificar
            Console.Write("Ingrese el número de identificación del empleado que desea actualizar los datos del sistema: ");
            //Se lee el número de identificación ingresado por el usuario
            idAModificar = Console.ReadLine();

            //Ciclo que recorrerá todo el arreglo
            for(int i = 0; i < id.Length; i++)
            {
                //Se crea una condicional para verificar si el número de identificación ingresado es igual al que está guardado
                if(idAModificar == id[i])
                {
                    //Si es verdadero se le actualizan todos los datos
                    //Se le solicita al usuario que ingrese el número de identificación
                    Console.Write("Ingrese el número de identificación del empleado: ");
                    //Se lee el número de identificación ingresado por el usuario
                    id[i] = Console.ReadLine();
                    //Se le solicita al usuario que ingrese el nombre
                    Console.Write("Ingrese el nombre del empleado: ");
                    //Se lee el nombre ingresado por el usuario
                    nombre[i] = Console.ReadLine();
                    //Se le solicita al usuario que ingrese la dirección
                    Console.Write("Ingrese la dirección del empleado: ");
                    //Se lee la dirección ingresada por el usuario
                    direccion[i] = Console.ReadLine();
                    //Se le solicita al usuario que ingrese el número de teléfono
                    Console.Write("Ingrese el teléfono del empleado: ");
                    //Se lee el número de teléfono ingresado por el usuario
                    telefono[i] = Console.ReadLine();
                    //Se le solicita al usuario que ingrese el salario
                    Console.Write("Ingrese el salario del empleado: ");
                    //Se lee el salario ingresado por el usuario
                    salario[i] = double.Parse(Console.ReadLine());
                }
            }
            //Se le notifica al usuario que ya se ha modificado al empleado
            Console.WriteLine("Los datos del empleado han sido modificados correctamente");
            //Se espera a que el usuario presione una tecla para seguir
            Console.ReadKey();
            //Se borra todo el contenido que se muestra en la consola
            Console.Clear();
        } 

        //Método para listar todos los empleados
        public static void ReporteEmpleados()
        {
            //Se le notifica al usuario que el reporte empieza
            Console.WriteLine("*** Reporte ***");
            //ciclo for que recorrerá todo el arreglo
            for (int i = 0; i < id.Length; i++)
            {
                //Se le muestra al usuario cada uno de los empleados con todos los datos
                Console.WriteLine($"El empleado {i + 1} es {nombre[i]}, con un número de identificación {id[i]}" +
                    $", con un salario de {salario[i]}, con una dirección {direccion[i]}" +
                    $" y su número de teléfono es {telefono[i]}");
            }
            //Se le notifica al usuario que el reporte ha terminado
            Console.WriteLine("*** Fin del reporte ***");
            //Se espera a que el usuario presione una tecla para seguir
            Console.ReadKey();
            //Se borra todo el contenido que se muestra en la consola
            Console.Clear();
        } 

        //Método para calcular y mostrar el promedio de los salarios
        public static void Promedio()
        {
            //Se crea una variable para almacenar el promedio
            double promedio = 0;
            
            //Ciclo for que recorrerá todo el arreglo
            for(int i = 0; i < salario.Length; i++)
            {
                //A promedio se le suma el valor de esa entrada de salario
                promedio += salario[i];
            } 
            //A promedio se le divide el valor del tamaño del arreglo de salario
            promedio = promedio / salario.Length;
            //Se le muestra al usuario el promedio de todos los salarios
            Console.WriteLine($"El promedio de todos los salarios es {promedio}");
            //Se espera a que el usuario presione una tecla para seguir
            Console.ReadKey();
            //Se borra todo el contenido que se muestra en la consola
            Console.Clear();
        }
    }
}
