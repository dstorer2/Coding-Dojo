namespace SinglyLinkedLists
{
    public class SLL
    {
        public SllNode? Head;
        public SLL()
        {
            Head = null;
        }
        public void Add(int value)
        {
            SllNode newNode = new SllNode(value);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                SllNode runner = Head;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }
        public string Remove(int value)
        {
            if(Head == null)
            {
                return "Nothing to remove";
            }
            else if(Head.Next == null)
            {
                Head = null;
                return "Head removed.";
            }
            else
            {
                SllNode runner = Head;
                while(runner.Next.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = null;
                return "Last node removed.";
            }
        }
        public void PrintValues()
        {
            if (Head == null)
            {
                Console.WriteLine("SLL is empty");
            }
            else if (Head.Next == null)
            {
                Console.WriteLine($"{Head.Value}");
            }
            else 
            {
                SllNode runner = Head;
                while(runner != null)
                {
                    Console.WriteLine($"{runner.Value}");
                }
            }
        }
    }
}