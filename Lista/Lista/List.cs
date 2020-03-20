using System;

namespace Lista
{   //Clase lista que contiene toda la lógica de la aplicación
    class List
    {
        //Se crea el nodo inicio y fin (o primero y último)
        private Node first, last = new Node();
       //Constructor que iguala los nodos a nulo
        public List()
        {
            first = null;
            last = null;
        }
        //Método insertar nodo, lee un número entero y lo guarda en el campo dato dentro del nodo
        public void insertNode()
        {
            //Variable para el nuevo nodo a insertar en la lista
            Node newNode = new Node();
            //Lee el número entero y lo guarda dentro del campo dato en el nuevo nodo
            newNode.Data = int.Parse(Console.ReadLine());
            //Verifica si el primer nodo está vacío
            if (first == null)
            {
                //Con el primer nodo vací se establece que el nuevo nodo es el primer nodo en la lista
                first = newNode;
                //Ya que es el primer nodo, también será el único por lo que el nodo siguiente y anterior se apuntan a nulo
                first.Next = null;
                first.Back = null;
                //Al ser el único nodo se establece que es el primero y último
                last = first;
            }
            else
            {
                //Si el primero nodo no está vacío se inserta el nuevo nodo al final de la lista
                last.Next = newNode;
                //Como el nuevo nodo es el último se apunta a nulo su nodo siguiente
                newNode.Next = null;
                //El nodo anterior del nuevo nodo pasa a ser el último
                newNode.Back = last;
                //Finalmente, se establece el nuevo nodo como el últmo de la lista
                last = newNode;
            }
        }
        //Método imprimir lista de inicio a fin
        public void printFL()
        {
            //Crea un nuevo objeto de tipo Nodo llamado auxiliar
            Node assistant = new Node();
            //Apunta nodo auxiliar al primer nodo para comenzar por el inicio de la lista
            assistant = first;
            //Mientras el nodo auxiliar no encuentre un nodo de la lista apuntando a nulo ejecutará el contenido
            while (assistant != null)
            {
                //Imprime en consola el campo dato del nodo auxiliar que está recorriendo la lista
                Console.WriteLine(assistant.Data);
                //Pasa al nodo siguiente de la lista
                assistant = assistant.Next;
            }
        }
        //Método imprimir lista de fin a inicio
        public void printLF()
        {
            //Crea un nuevo objeto de tipo Nodo llamado auxiliar
            Node assistant = new Node();
            //Apunta nodo auxiliar al último nodo para comenzar por el final de la lista
            assistant = last;
            //Mientras el nodo auxiliar no encuentre un nodo de la lista apuntando a nulo ejecutará el contenido
            while (assistant != null)
            {
                //Imprime en consola el campo dato del nodo auxiliar que está recorriendo la lista
                Console.WriteLine(assistant.Data);
                //Pasa al nodo anterior de la lista
                assistant = assistant.Back;
            }
        }


    }
}
