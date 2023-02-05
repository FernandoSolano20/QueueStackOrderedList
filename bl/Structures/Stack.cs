namespace bl.Structures
{
    public class Stack : List
    {
        public override void Add(int value)
        {
            Size++;
            var temp = new Node
            {
                Value = value,
                NextElement = null,
            };
            if (Head == null)
            {
                Head = temp;
            }
            else
            {
                temp.NextElement = Head;
                Head = temp;
            }
        }
    }
}
