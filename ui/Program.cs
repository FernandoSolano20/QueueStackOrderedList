using tl;

var controller = new Controller();
var opcion1 = 0;
var opcion2 = 0;
do
{
    Console.WriteLine("Esogea donde desea agregar el numero");
    Console.WriteLine("1- Lista ordenada");
    Console.WriteLine("2- Pila");
    Console.WriteLine("3- Cola");
    Console.WriteLine("4- Salir");
    opcion1 = Convert.ToInt32(Console.ReadLine());

    switch (opcion1)
    {
        case 1:
            var numberList = ReadNumber();
            controller.AddInOrderedList(numberList);
            Console.WriteLine(controller.ShowAllElements());
            break;

        case 2:
            var numberStack = ReadNumber();
            controller.AddInStack(numberStack);
            Console.WriteLine(controller.ShowAllElements());
            break;

        case 3:
            var numberQueue = ReadNumber();
            controller.AddInQueue(numberQueue);
            Console.WriteLine(controller.ShowAllElements());
            break;

        case 4:
            break;

        default:
            Console.WriteLine("Numero no valido");
            break;
    }


} while (opcion1 != 4);

do
{
    Console.WriteLine("Escoja una opcion");
    Console.WriteLine("1- Mover de lista ordenada a pila");
    Console.WriteLine("2- Mover de lista ordenada a cola");
    Console.WriteLine("3- Mover de pila a cola");
    Console.WriteLine("4- Mover de pila a lista ordenada");
    Console.WriteLine("5- Mover de cola a lista ordenada");
    Console.WriteLine("6- Mover de cola a pila");
    Console.WriteLine("7- Salir");
    opcion2 = Convert.ToInt32(Console.ReadLine());
    int? valueToMove = 0;
    switch (opcion2)
    {
        case 1:
            Console.WriteLine(controller.AddInStackFromOrderedList());
            break;

        case 2:
            Console.WriteLine(controller.AddInQueueFromOrderedList());
            break;

        case 3:
            Console.WriteLine(controller.AddInQueueFromStack());
            break;

        case 4:
            Console.WriteLine(controller.AddInOrderedListFromStack());
            break;

        case 5:
            Console.WriteLine(controller.AddInOrderedListFromQueue());
            break;

        case 6:
            Console.WriteLine(controller.AddInStackFromQueue());
            break;

        case 7:
            Console.WriteLine(controller.ShowAllElements());
            Console.WriteLine("Adios");
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

} while (opcion2 != 7);


static int ReadNumber()
{
    Console.WriteLine("Digite el numero");
    var number = Convert.ToInt32(Console.ReadLine());
    return number;
}