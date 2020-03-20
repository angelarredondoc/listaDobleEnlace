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
            int quantity;
            //Imprime en consola la petición de cantidad de nodos
            Console.WriteLine("Ingrese la cantidad de nodos que desea crear: ");
            try
            {
                //Lee la cantidad de nodos convirtiéndola a tipo entero y la guarda en la variable quantity
                quantity = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Valor numérico no válido, se considera número de nodos = 0");
                quantity = 0;
            }
            if (quantity == 0)
            {
                Console.WriteLine("Al no crear nodos la lista está vacía");
            }
            else
            {
                //Ciclo repetitivo que ejecuta el método de insertar nodo según el número de nodos a crear
                for (int i = 1; i <= quantity; i++)
                {
                    //Imprime en consola la petición del número entero correspondiente al nodo
                    Console.WriteLine("Ingrese el número entero del nodo " + i + " de la lista: ");
                    //Ejecuta el método insertar nodo
                    list.insertNode();
                }
                //Imprime en consola la confirmación de lista creada con éxito e informa que se imprimirá la misma de inicio a fin
                Console.WriteLine("Se ha creado la lista con éxito! "
                    + "\nMostrando lista de inicio a fin... ");
                //Ejecuta el método imprimir lista de principio a fin
                list.printFL();
                //Informa que se imprimirá la lista de fin a inicio
                Console.WriteLine("Mostrando lista de fin a inicio... ");
                //Ejecuta el método imprimir lista de fin a inicio
                list.printLF();
            }          
                       
        }
    }
}
