using System.Runtime.InteropServices;

namespace MinhaLinkedList
{
    internal class LinkedList<T>
    {
        // As propriedades Head e Size só podem ser alteradas internamente pelos métodos da própria classe LinkedList
        public Node<T>? Head { get; private set; }
        public int Size { get; private set; } = 0;

        public void AddAtEnd(T value)
        {
            Node<T> node = new Node<T>(value);

            if (Head == null)
            {
                Head = node;
                Size++;
                return;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
            Size++;
        }

        public void PrintLinkedListElements()
        {
            if (Head == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }

            Node<T> current = Head;
            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public int GetListSize()
        {
            return Size;
        }

        public void IsEmpty()
        {
            if (Head == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }
            Console.WriteLine("A lista não está vazia.");
        }

        public void ClearList()
        {
            Console.WriteLine($"Antes: {Size}");
            if (Head == null)
            {
                Console.WriteLine("A lista já está vazia.");
                return;
            }

            while (Head != null)
            {
                Head = null;
                Size = 0;
            }
            Console.WriteLine($"Depois: {Size}");
        }

        public void AddAtStart(T value)
        {
            //if (Head == null)
            //{
            //    Head = new Node<T>(value);
            //    Size++;
            //    return;
            //}
            //Node<T> temp = new Node<T>(Head.Value);

            //Node<T> newNode = new Node<T>(value);

            //Head.Value = newNode.Value;
            //newNode.Value = temp.Value;

            //temp.Next = Head.Next;
            //Head.Next = newNode;
            //newNode.Next = temp.Next;
            //Size++;

            Node<T> novoNo = new Node<T>(value);

            novoNo.Next = Head;
            Head = novoNo;
            Size++;
        }

        public Node<T> GetElementByValue(T value)
        {
            if (Head == null)
            {
                Console.WriteLine("A lista está vazia.");
                return null;
            }

            Node<T> current = Head;
            while (!current.Value.Equals(value))
            {
                if (current.Next != null)
                {
                    current = current.Next;
                } else
                {
                    Console.WriteLine($"O valor {value} não existe na lista.");
                    return null;
                }
            }

            Console.WriteLine($"Valor do nó: {current.Value}");
            
            GCHandle handle = GCHandle.Alloc(current, GCHandleType.Weak);
            IntPtr address = GCHandle.ToIntPtr(handle);
            Console.WriteLine($"Endereço do nó: 0x{address.ToString("X")}");

            handle.Free(); // Sempre libere o handle após usar
            return current;
        }

        public Node<T> GetElementAtPosition(int index)
        {
            if (index < 0 || index >= Size)
            {
                return null;
            }
            if (Head == null)
            {
                return null;
            }

            int i = 0;
            Node<T> current = Head;

            while ( current != null)
            {
                if (i == index)
                {
                    return current;
                }
                i++;
                current = current.Next;
            }
            return null;
        }
        public void AddAtPosition(int index, T value)
        {
            if (index < 0 || index > Size)
            {
                return;
            }

            Node<T> newNode = new Node<T>(value);

            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }

            if (index == 0)
            {
                newNode.Next = Head;
                Head = newNode;
                Size++;
                return;
            }

            Node<T> preCurrent = Head;
            Node<T> current = Head;
            
            for (int i = 0; i < index; i++)
            {
                preCurrent = current;
                current = current.Next;
            }

            preCurrent.Next = newNode;
            newNode.Next = current;
            Size++;
        }
    }
}

