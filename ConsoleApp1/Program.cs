using System;
using tl;

namespace ui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller();
            //var opcion1 = 0;
            //var opcion2 = 0;
            //do
            //{
            //    Console.WriteLine("Esogea donde desea agregar el numero");
            //    Console.WriteLine("1- Lista ordenada");
            //    Console.WriteLine("2- Pila");
            //    Console.WriteLine("3- Cola");
            //    Console.WriteLine("4- Salir");
            //    opcion1 = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion1)
            //    {
            //        case 1:
            //            var numberList = ReadNumber();
            //            orderedList.Add(numberList);
            //            break;

            //        case 2:
            //            var numberStack = ReadNumber();
            //            stack.Add(numberStack);
            //            break;

            //        case 3:
            //            var numberQueue = ReadNumber();
            //            queue.Add(numberQueue);
            //            break;

            //        case 4:
            //            break;

            //        default:
            //            Console.WriteLine("Numero no valido");
            //            break;
            //    }


            //} while (opcion1 != 4);

            //do
            //{
            //    Console.WriteLine("Escoja una opcion");
            //    Console.WriteLine("1- Mover de lista ordenada a pila");
            //    Console.WriteLine("2- Mover de lista ordenada a cola");
            //    Console.WriteLine("3- Mover de pila a cola");
            //    Console.WriteLine("4- Mover de pila a lista ordenada");
            //    Console.WriteLine("5- Mover de cola a lista ordenada");
            //    Console.WriteLine("6- Mover de cola a pila");
            //    Console.WriteLine("7- Salir");
            //    opcion2 = Convert.ToInt32(Console.ReadLine());
            //    int? valueToMove = 0;
            //    switch (opcion2)
            //    {
            //        case 1:
            //            valueToMove = orderedList.Remove();
            //            if (valueToMove != null)
            //            {
            //                stack.Add(valueToMove ?? 0);
            //                PrintList();
            //            }
            //            else
            //            {
            //                Console.WriteLine("No hay elementos en la lista ordenada");
            //            }
                        
            //            break;

            //        case 2:
            //            valueToMove = orderedList.Remove();
            //            if (valueToMove != null)
            //            {
            //                queue.Add(valueToMove ?? 0);
            //                PrintList();
            //            }
            //            else
            //            {
            //                Console.WriteLine("No hay elementos en la lista ordenada");
            //            }
            //            break;

            //        case 3:
            //            valueToMove = stack.Remove();
            //            if (valueToMove != null)
            //            {
            //                queue.Add(valueToMove ?? 0);
            //                PrintList();
            //            }
            //            else
            //            {
            //                Console.WriteLine("No hay elementos en la pila");
            //            }
                        
            //            break;

            //        case 4:
            //            valueToMove = stack.Remove();
            //            if (valueToMove != null)
            //            {
            //                orderedList.Add(valueToMove ?? 0);
            //                PrintList();
            //            }
            //            else
            //            {
            //                Console.WriteLine("No hay elementos en la pila");
            //            }
                        
            //            break;

            //        case 5:
            //            valueToMove = queue.Remove();
            //            if (valueToMove != null)
            //            {
            //                orderedList.Add(valueToMove ?? 0);
            //                PrintList();
            //            }
            //            else
            //            {
            //                Console.WriteLine("No hay elementos en la cola");
            //            }
            //            break;

            //        case 6:
            //            valueToMove = queue.Remove();
            //            if (valueToMove != null)
            //            {
            //                stack.Add(valueToMove ?? 0);
            //                PrintList();
            //            }
            //            else
            //            {
            //                Console.WriteLine("No hay elementos en la cola");
            //            }
                        
            //            break;

            //        case 7:
            //            PrintList();
            //            Console.WriteLine("Adios");
            //            break;

            //        default:
            //            Console.WriteLine("Opcion no valida");
            //            break;
            //    }

            //} while (opcion2 != 7);

        }

        static int ReadNumber()
        {
            Console.WriteLine("Digite el numero");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static void PrintList()
        {
            //Console.WriteLine(orderedList.Print());
            //Console.WriteLine(queue.Print());
            //Console.WriteLine(stack.Print());
        } 
    }
}
