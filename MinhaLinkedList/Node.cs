namespace MinhaLinkedList
{
    // O <T> na classe indica que ela aceita um tipo genérico
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
