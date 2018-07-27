using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniCircularLinkedList
{
    public class CircularLinkedList<T>
    {
        int Count = 0;
        CircularLinkedListNode<T> Head;
        CircularLinkedListNode<T> Tail;
        public CircularLinkedList()
        {

        }

        public CircularLinkedListNode<T> this[int index]
        {
            get
            {
                CircularLinkedListNode<T> currentNode = Head;
                int count = 0;
                while(count < index)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode;
            }
            
        }
        
        //IsEmpty
        public bool IsEmpty()
        {
            return Head == null;
        }
        public IEnumerator<CircularLinkedListNode<T>> GetEnumerator()
        {
            int count = 0;
            CircularLinkedListNode<T> currentNode = Head;  
            while(count != Count)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
                count++;
            }
        }
        //AddFirst
        public void AddToFront(T itemToAdd)
        {
            if(IsEmpty())
            {
                Head = new CircularLinkedListNode<T>(itemToAdd);
                Tail = Head;
            }
            else
            {
                CircularLinkedListNode<T> nodeToAdd = new CircularLinkedListNode<T>(itemToAdd);

                nodeToAdd.Next = Head;
                Head.Previous = nodeToAdd;
                Head = nodeToAdd;
                Head.Previous = Tail;
                Tail.Next = Head;
            }
            Count++;
        }
        //AddEnd
        public void AddToEnd(T itemToAdd)
        {
            if(IsEmpty())
            {
                Head = new CircularLinkedListNode<T>(itemToAdd);
                Tail = Head;
               
            }
            else
            {
                Tail.Next = new CircularLinkedListNode<T>(itemToAdd, Head, Tail);
                Tail = Tail.Next;

            }
            Count++;
        }
        //AddBefore
        public void AddAfterIndex(int index, T itemToAdd)
        {
            if(IsEmpty())
            {
                Head = new CircularLinkedListNode<T>(itemToAdd);
                Tail = Head; 
            }
            else if()
        }
        //AddAfter

        //RemoveFirst
        //RemoveLast
        //RemoveAt
    }
}
