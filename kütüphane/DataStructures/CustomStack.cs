namespace UniversityLibrarySystem.DataStructures
{
    public class CustomStack<T>
    {
        private Node<T> top;
        private int count;

        public CustomStack()
        {
            top = null;
            count = 0;
        }

        // 🔹 Stack'e ekleme (Push)
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        // 🔹 Stack'ten çıkarma (Pop)
        public T Pop()
        {
            if (IsEmpty())
                return default;

            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        // 🔹 En üstteki eleman
        public T Peek()
        {
            if (IsEmpty())
                return default;

            return top.Data;
        }

        // 🔹 Stack boş mu?
        public bool IsEmpty()
        {
            return count == 0;
        }

        // 🔹 Log sayısı
        public int Count()
        {
            return count;
        }
    }
}
