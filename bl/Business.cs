using bl.Structures;

namespace bl
{
    public class Business
    {
        private Queue _queue;
        private Stack _stack;
        private OrderedList _orderedList;

        public Business()
        {
            _queue = new Queue();
            _stack = new Stack();
            _orderedList = new OrderedList();
        }

        public void AddInOrderedList(int value)
        {
            _orderedList.Add(value);
        }

        public void AddInQueue(int value)
        {
            _queue.Add(value);
        }

        public void AddInStack(int value)
        {
            _stack.Add(value);
        }

        public int? RemoveOrderedList()
        {
            return _orderedList.Remove();
        }

        public int? RemoveQueue()
        {
            return _queue.Remove();
        }

        public int? RemoveStack()
        {
            return _stack.Remove();
        }

        public string ShowOrderedList()
        {
            return $"Lista ordenanda: {_orderedList.Print()}";
        }

        public string ShowStack()
        {
            return $"Pila: {_stack.Print()}";
        }

        public string ShowQueue()
        {
            return $"Cola: {_queue.Print()}";
        }

        public string AddInStackFromOrderedList()
        {
            var valueToMove = RemoveOrderedList();
            if (valueToMove == null)
            {
                return "No hay elementos en la lista ordenada";
            }
            AddInStack(valueToMove.Value);

            return ShowAllElements();
        }

        public string AddInQueueFromOrderedList()
        {
            var valueToMove = RemoveOrderedList();
            if (valueToMove == null)
            {
                return "No hay elementos en la lista ordenada";
            }
            AddInQueue(valueToMove.Value);

            return ShowAllElements();
        }

        public string AddInQueueFromStack()
        {
            var valueToMove = RemoveStack();
            if (valueToMove == null)
            {
                return "No hay elementos en la pila";
            }
            AddInQueue(valueToMove.Value);

            return ShowAllElements();
        }

        public string AddInOrderedListFromStack()
        {
            var valueToMove = RemoveStack();
            if (valueToMove == null)
            {
                return "No hay elementos en la pila";
            }
            AddInOrderedList(valueToMove.Value);

            return ShowAllElements();
        }

        public string AddInOrderedListFromQueue()
        {
            var valueToMove = RemoveQueue();
            if (valueToMove == null)
            {
                return "No hay elementos en la cola";
            }
            AddInOrderedList(valueToMove.Value);

            return ShowAllElements();
        }

        public string AddInStackFromQueue()
        {
            var valueToMove = RemoveQueue();
            if (valueToMove == null)
            {
                return "No hay elementos en la cola";
            }
            AddInStack(valueToMove.Value);

            return ShowAllElements();
        }

        public string ShowAllElements()
        {
            return $"{ShowOrderedList()} \n {ShowStack()} \n {ShowQueue()}";
        }
    }
}