using System;

namespace Lista
{   //Clase principal que ejecuta el programa en consola
    class MainClass
    {
        static void Main(string[] args)
        {
            //Nuevo objeto del tipo List usado como enlace a clase List para usar sus métodos
            List list = new List();
            //Variable de tipo entero para guardar la cantidad de nodos a crear
            int choice;
            //Ciclo repetitivo para tener un comtínuo despliegue de menú
            do
            {
                //Bloque try catch para manejo de excepciones tipo formato
                try
                {
                    //Método para limpiar consola y evitar acumulación de texto
                    Console.Clear();
                    //Muestra menú en consola
                    Console.WriteLine("---------Lista doblemente enlazada--------- \n"
                                     + "Seleccione una de las siguientes opciones: \n"
                                     + "1. Insertar nodo. \n"
                                     + "2. Imprimir lista de inicio a fin. \n"
                                     + "3. Imprimir lista de fin a inicio. \n"
                                     + "4. Salir.");
                    //Guarda la selección del usuario
                    choice = int.Parse(Console.ReadLine());
                    //Estructura switch para manejo de casos según el menú
                    switch (choice)
                    {
                        //Opción 1 del menú. Insertar un nodo
                        case 1:
                            Console.Clear();
                            //Imprime en consola la petición del número entero correspondiente al nodo
                            Console.WriteLine("Ingrese el número entero del nodo: ");
                            //Ejecuta el método insertar nodo
                            list.InsertNode();
                            //Confirma que se ha insertado el nodo imprimiendo en consola
                            Console.WriteLine("Nodo insertado con éxito!\n"
                                             +"Presione cualquier tecla para continuar... ");
                            Console.ReadKey();
                            break;
                        //Opción 2 del menú. Imprimir lista de inicio a fin
                        case 2:
                            //Valida si la lista está vacía
                            if (!list.IsEmpty())
                            {
                                Console.Clear();
                                //Informa que se imprimirá la lista de inicio a fin
                                Console.WriteLine("Mostrando lista de inicio a fin... ");
                                //Ejecuta el método imprimir lista de principio a fin
                                list.PrintFL();
                                //Para retener en consola la impresión anterior lee una tecla
                                Console.WriteLine("Presione cualquier tecla para continuar... ");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                //Si la lista está vacía lo despliega en consola
                                Console.WriteLine("La lista está vacía! ");
                                Console.WriteLine("Presione cualquier tecla para continuar... ");
                                Console.ReadKey();
                            }
                            break;
                        //Opción 3 del menú. Imprimir lista de fin a inicio
                        case 3:
                            //Valida si la lista está vacía
                            if (!list.IsEmpty())
                            {
                                Console.Clear();
                                //Informa que se imprimirá la lista de fin a inicio
                                Console.WriteLine("Mostrando lista de fin a inicio... ");
                                //Ejecuta el método imprimir lista de fin a inicio
                                list.PrintLF();
                                //Para retener en consola la impresión anterior lee una tecla
                                Console.WriteLine("Presione cualquier tecla para continuar... ");
                                Console.ReadKey();
                            }
                            else
                            {
                                //Si la lista está vacía lo despliega en consola
                                Console.Clear();
                                Console.WriteLine("La lista está vacía! ");
                                Console.WriteLine("Presione cualquier tecla para continuar... ");
                                Console.ReadKey();
                            }
                            break;
                        //Opción 4 del menú. Salir de la aplicación
                        case 4:
                            Console.WriteLine("Aplicación finalizada! ");
                            choice = 4;
                            break;
                        //Opción por defecto del menú. Notifica opción inválida
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción no válida! eliga una opción del menú.");
                            Console.WriteLine("Presione cualquier tecla para continuar... ");
                            Console.ReadKey();
                            break;

                    }                   
                }
                catch (FormatException)
                {
                    Console.Clear();
                    //En caso de que el usuario no introduzca un valor numérico imprime que no es válido
                    Console.WriteLine("Ha introducido un valor no válido, introduza un valor numérico entero: \n"
                                     +"Presione cualquier tecla para continuar... ");
                    Console.ReadKey();
                    choice = 0;
                }
            } while (choice != 4);
        }
    }
}
