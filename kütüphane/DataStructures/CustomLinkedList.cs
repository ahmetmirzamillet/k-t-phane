namespace UniversityLibrarySystem.DataStructures
{
    public class CustomLinkedList<T>
    {
        private Node<T> head;

        public CustomLinkedList()
        {
            head = null;
        }

        // 🔹 Listeye ekleme
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        // 🔹 Listede var mı? (contains)
        public bool Contains(T data)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;

                current = current.Next;
            }

            return false;
        }

        // 🔹 Listeyi dolaşma (UI için)
        public Node<T> GetHead()
        {
            return head;
        }
    }
}
