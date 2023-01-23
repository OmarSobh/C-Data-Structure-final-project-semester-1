using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Node<T>
    {

        private T value;
        private Node<T> next;

        public T Value { get { return value; } set { this.value = value; } }
        public Node<T> Next { get { return next; } set { this.next = value; } }

        public Node()
        {

        }
        public Node(Node<T> other)
        {
            this.value = other.value;
            this.next = other.next;
        }

        public Node(Node<T> other, Node<T> next)
        {
            this.value = other.value;
            this.next = other.next;
        }

        public Node(T value, Node<T> next = null)
        {
            this.value = value;
            this.next = next;
        }

        public bool HasNext()
        {
            return this.next != null;
        }

        public override string ToString()
        {
            if (this.next == null)
            {
                return this.value + " --> null";
            }

            return this.value + " --> " + this.next;
        }


    }
}
