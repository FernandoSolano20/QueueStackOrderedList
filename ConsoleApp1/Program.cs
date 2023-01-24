﻿using System;
using ConsoleApp1.Structures;

namespace ConsoleApp1
{
    internal class Program
    {
        static Queue queue = new Queue();
        static Stack stack = new Stack();
        static OrderedList orderedList = new OrderedList();
        static void Main(string[] args)
        {
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
                        orderedList.Add(numberList);
                        break;

                    case 2:
                        var numberStack = ReadNumber();
                        stack.Add(numberStack);
                        break;

                    case 3:
                        var numberQueue = ReadNumber();
                        queue.Add(numberQueue);
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
                var valueToMove = 0;
                switch (opcion2)
                {
                    case 1:
                        valueToMove = orderedList.Remove();
                        stack.Add(valueToMove);
                        PrintList();
                        break;

                    case 2:
                        valueToMove = orderedList.Remove();
                        queue.Add(valueToMove);
                        PrintList();
                        break;

                    case 3:
                        valueToMove = stack.Remove();
                        queue.Add(valueToMove);
                        PrintList();
                        break;

                    case 4:
                        valueToMove = stack.Remove();
                        orderedList.Add(valueToMove);
                        PrintList();
                        break;

                    case 5:
                        valueToMove = queue.Remove();
                        orderedList.Add(valueToMove);
                        PrintList();
                        break;

                    case 6:
                        valueToMove = queue.Remove();
                        stack.Add(valueToMove);
                        PrintList();
                        break;

                    case 7:
                        PrintList();
                        Console.WriteLine("Adios");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (opcion2 != 7);

        }

        static int ReadNumber()
        {
            Console.WriteLine("Digite el numero");
            var number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static void PrintList()
        {
            Console.WriteLine(orderedList.Print());
            Console.WriteLine(queue.Print());
            Console.WriteLine(stack.Print());
        } 
    }
}