namespace ConsoleApp1.Structures
{
    public abstract class List
    {
        protected Node Head = null;

        protected int Size = 0;

        public abstract void Add(int value);

        public int? Remove()
        {
            if (Head == null)
            {
                return null;
            }
            var value = Head.Value;
            Head = Head.NextElement;
            return value;
        }

        public string Print()
        {
            var aux = Head;
            var text = string.Empty;
            while (aux != null)
            {
                text += aux.Value + ",";
                aux = aux.NextElement;
            }
            return text;
        }
    }
}
