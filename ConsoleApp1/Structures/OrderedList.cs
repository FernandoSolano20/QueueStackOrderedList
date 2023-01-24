using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Structures
{
    public class OrderedList : List
    {
        public override void Add(int value)
        {
            Size++;
            var temp = new Node
            {
                Value = value,
                NextElement = null,
            };
            var aux = Head;
            if (Head == null)
            {
                Head = temp;
            }
            else
            {
                Node previousNode = null;
                while (aux.Value < temp.Value && aux.NextElement != null)
                {
                    previousNode = aux;
                    aux = aux.NextElement;
                }

                if (previousNode == null)
                {
                    Head = temp;
                    temp.NextElement = aux;
                }
                else
                {
                    if (aux.Value < temp.Value)
                    {
                        aux.NextElement = temp;
                    }
                    else
                    {
                        previousNode.NextElement = temp;
                        temp.NextElement = aux;
                    }
                }
            }
        }
    }
}
