﻿using System;
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

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
        public Node(Node<T> linkedList)
        {
            this.value = linkedList.GetValue();
            this.next = linkedList.GetNext();
        }

        public T GetValue()
        {
            return value;
        }

        public void SetValue(T value)
        {
            this.value = value;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public bool HasNext()
        {
            return this.next != null;
        }

        public override string ToString()
        {
            //if (this.next == null)
            if (!HasNext())
            {
                return this.value + "-->" + "null";
            }

            return this.value + "-->" + this.next;
        }


    }
}
