namespace UniversityLibrarySystem.DataStructures
{
    public class CustomQueue<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int count;

        public CustomQueue()
        {
            front = null;
            rear = null;
            count = 0;
        }

        // 🔹 Kuyruğa ekleme
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }

            count++;
        }

        
        public T Dequeue()
        {
            if (IsEmpty())
                return default;

            T data = front.Data;
            front = front.Next;

            if (front == null)
                rear = null;

            count--;
            return data;
        }

        
        public T Peek()
        {
            if (IsEmpty())
                return default;

            return front.Data;
        }

        
        public bool IsEmpty()
        {
            return count == 0;
        }

        
        public int Count()
        {
            return count;
        }
    }
}
