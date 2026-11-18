using System;
using System.Collections.Generic;
using System.Text;

namespace ListaDuplamenteEncadeada
{
    internal class Node<T>
    {
        // Value; <-- Ainda não sei que tipo vai ser armazenado no Nó. Por enquanto vou fingir que o tipo é inteiro.
        public T Value;
        public Node<T> Previous;
        public Node<T> Next;

        public Node(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            if (Previous == null && Next != null)
            {
                return $"Valor: {Value}\nPrevious element: null\nNext element: {Next.Value}";
            }
            else if (Previous != null && Next == null)
            {
                return $"Valor: {Value}\nPrevious element: {Previous.Value}\nNext element: null";
            }
            else if (Previous == null && Next == null)
            {
                return $"Valor: {Value}\nPrevious element: null\nNext element: null";
            }
            else
            {
                return $"Valor: {Value}\nPrevious element: {Previous.Value}\nNext element: {Next.Value}";
            }
        }
    }
}
