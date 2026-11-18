using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ListaDuplamenteEncadeada
{
    internal class DoublyLinkedList<T>
    {
        private Node<T> Head = null;
        private Node<T> Tail = null;
        private int Size = 0;

        public void AddAtTheEnd(T value)
        {
            // A forma que eu implementei:
            //Node<T> newNode = new Node<T>(value);

            //if (Head == null)
            //{
            //    Head = newNode;
            //    Tail = newNode;
            //    Size++;
            //    return;
            //}

            //Node<T> current = Head;

            //for (int i = 0; current.Next != null; i++)
            //{
            //    current = current.Next;
            //}
            //current.Next = newNode;
            //Tail = current.Next;
            //current.Next.Previous = current;
            //Size++;

            // A forma ensinada na aula:

            Node<T> newNode = new Node<T>(value);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                Size++;
                return;
            }
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
            Size++;
        }

        public List<Node<T>> PrintDoublyLinkedList()
        {
            if (Head == null)
            {
                return null;
            }

            List<Node<T>> lista = new List<Node<T>>();

            Node<T> current = Head;
            for (int i = 0; current != null; i++)
            {
                lista.Add(current);
                current = current.Next;
            }
            return lista;
        }

        public Node<T> PrintTheListTail()
        {
            return Tail;
        }

        public Node<T> PrintTheListHead()
        {
            return Head;
        }
        public void ClearList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public int GetSize()
        {
            return Size;
        }

        public void AddAtTheBeginning(Node<T> node)
        {
            if (IsEmpty())
            {
                Head = node;
                Tail = node;
                Size++;
                return;
            }
            node.Next = Head;
            Head.Previous = node;
            Head = node;
            Size++;
        }

        public Node<T> GetElementAtAPosition(int indice)
        {
            if (IsEmpty())
                return null;
            if (indice < 0 || indice >= Size)
                return null;
            if ((Size - 1) - indice < indice)
            {
                Node<T> current = Tail;
                for (int i = Size - 1; i != indice; i--)
                {
                    current = current.Previous;
                }
                return current;
            }
            else
            {
                Node<T> current = Head;
                for (int i = 0; i != indice; i++)
                {
                    current = current.Next;
                }
                return current;
            }
        }

        public void AddElementAtPosition(int indice, Node<T> novoNo)
        {
            if (indice < 0 || indice > Size)
                return;
            if (Head == null || indice == 0)
            {
                AddAtTheBeginning(novoNo);
                return;
            }
            if (indice == Size)
            {
                novoNo.Previous = Tail;
                Tail.Next = novoNo;
                Tail = novoNo;
                Size++;
                return;
            }

            if ((Size - 1) - indice < indice)
            {
                Node<T> current = Tail;
                for (int i = Size - 1; i != indice; i--)
                {
                    current = current.Previous;
                }
                novoNo.Next = current;
                novoNo.Previous = current.Previous;
                current.Previous.Next = novoNo;
                current.Previous = novoNo;
                Size++;
            }
            else
            {
                Node<T> current = Head;
                for (int i = 0; i != indice; i++)
                {
                    current = current.Next;
                }
                novoNo.Next = current;
                novoNo.Previous = current.Previous;
                current.Previous.Next = novoNo;
                current.Previous = novoNo;
                Size++;
            }
        }

        public int ObterPosicaoElemento(T value)
        {
            //if (IsEmpty())
            //    return -1;

            //Node<T> current = Head;
            //for (int i = 0; current != null; i++)
            //{
            //    if (current.Value.Equals(value))
            //    {
            //        return i;
            //    } else
            //    {
            //        current = current.Next;
            //    }
            //}
            //return -1;

            // Implementação de uma Busca Bidirecional:
            if (Head == null)
                return -1;
            
            Node<T> left = Head;
            Node<T> right = Tail;
            int leftIndex = 0;
            int rightIndex = Size - 1;

            while (leftIndex <= rightIndex)
            {
                if (EqualityComparer<T>.Default.Equals(left.Value, value))
                {
                    return leftIndex;
                }
                if (EqualityComparer<T>.Default.Equals(right.Value, value))
                {
                    return rightIndex;
                }

                left = left.Next;
                right = right.Previous;
                leftIndex++;
                rightIndex--;
            }
            return -1; // Nó não encontrado
        }

        public Node<T> RemoveFirstElement()
        {
            if (Head == null)
                return null;

            Node<T> removido = Head;
            Head = Head.Next;
            if (Head == null)
            {
                Tail = null;
            } else
            {
                Head.Previous = null;
            }
            Size--;
            return removido;
        }
    }
}
