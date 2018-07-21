using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniCircularLinkedList
{
    public class CircularLinkedListNode<T>
    {
        public CircularLinkedListNode<T> Next { get; set; }
        public CircularLinkedListNode<T> Previous { get; set; }
        public T Value;
        public CircularLinkedListNode(T ItemToAdd, CircularLinkedListNode<T> next = null, CircularLinkedListNode<T> previous = null)
        {
            Value = ItemToAdd;
            Next = next;
            Previous = previous;
        }
    }
}
