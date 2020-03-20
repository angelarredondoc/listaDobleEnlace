namespace Lista
{   //Clae nodo que contiene la estructura de los nodos, campo de dato y dos apuntadores, uno a siguiente y otro a anterior
    class Node
    {
        //Variables que fungen como apntadores a siguiente y anterior
        private Node next, back;
        //Campo de dato dentro del nodo
        public int Data { get; set; }
        //Método get y set del apuntador siguiente
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
        //Método get y set del apuntador anterior
        public Node Back
        {
            get { return back; }
            set { back = value; }
        }

    }
}
