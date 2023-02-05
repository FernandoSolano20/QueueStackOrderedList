using bl;
using bl.Structures;

namespace tl
{
    public class Controller
    {
        private readonly Business _bl;

        public Controller()
        {
            _bl = new Business();
        }

        public void AddInOrderedList(int value)
        {
            _bl.AddInOrderedList(value);
        }

        public void AddInQueue(int value)
        {
            _bl.AddInQueue(value);
        }

        public void AddInStack(int value)
        {
            _bl.AddInStack(value);
        }

        public string AddInStackFromOrderedList()
        {
            return _bl.AddInStackFromOrderedList();
        }

        public string AddInQueueFromOrderedList()
        {
            return _bl.AddInQueueFromOrderedList();
        }

        public string AddInQueueFromStack()
        {
            return _bl.AddInQueueFromStack();
        }

        public string AddInOrderedListFromStack()
        {
            return _bl.AddInOrderedListFromStack();
        }

        public string AddInOrderedListFromQueue()
        {
            return _bl.AddInOrderedListFromQueue();
        }

        public string AddInStackFromQueue()
        {
            return _bl.AddInStackFromQueue();
        }

        public string ShowAllElements()
        {
            return _bl.ShowAllElements();
        }
    }
}