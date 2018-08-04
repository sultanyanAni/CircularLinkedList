using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniCircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList<int> list = new CircularLinkedList<int>();
            int index = 0;
            bool keepLooping = true;
            while (keepLooping)
            {
                string response = "";
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1) Add to list");
                Console.WriteLine("2) Remove from list");
                Console.WriteLine("3) View the list");
                Console.WriteLine("4) Exit");

                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        Console.WriteLine("What item would you like to add?");
                        int itemToAdd = int.Parse(Console.ReadLine());
                        Console.WriteLine("Where would you like to add the item?");
                        Console.WriteLine("1) The Front");
                        Console.WriteLine("2) The End");
                        Console.WriteLine("3) Before an index");
                        Console.WriteLine("4) After an index");
                        response = Console.ReadLine();
                        switch (response)
                        {
                            case "1":
                                list.AddToFront(itemToAdd);
                                break;
                            case "2":
                                list.AddToEnd(itemToAdd);
                                break;
                            case "3":
                                Console.WriteLine("Which index would you like to add before?");
                                index = int.Parse(Console.ReadLine()) - 1;
                                list.AddBeforeIndex(index, itemToAdd);
                                break;
                            case "4":
                                Console.WriteLine("Which index would you like to add after?");
                                index = int.Parse(Console.ReadLine()) - 1;
                                list.AddAfterIndex(index, itemToAdd);
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Where would you like to remove an item from?");
                        Console.WriteLine("1) From the front");
                        Console.WriteLine("2) From the end");
                        Console.WriteLine("3) At an index");
                        response = Console.ReadLine();
                        switch (response)
                        {
                            case "1":
                                list.RemoveFirst();
                                break;
                            case "2":
                               list.RemoveLast();
                                break;
                            case "3":
                                Console.WriteLine("Which index would you like to remove from?");
                                index = int.Parse(Console.ReadLine()) - 1;
                                list.RemoveAt(index);
                                break;
                        }
                        break;
                    case "3":
                        int count = 1;
                        foreach (CircularLinkedListNode<int> node in list)
                        {
                            Console.WriteLine($"{count}) {node.Value}");
                            count++;
                        }
                        break;
                    case "4":
                        keepLooping = false;
                        break;
                }
            }
        }
    }
}
