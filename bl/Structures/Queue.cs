namespace bl.Structures
{
    public class Queue : List
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
                while (aux.NextElement != null)
                {
                    aux = aux.NextElement;
                }

                aux.NextElement = temp;
            }
        }
    }
}
