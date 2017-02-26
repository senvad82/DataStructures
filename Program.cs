using System;

namespace SingleLinkedListProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            SingleLinkedList list2 = new SingleLinkedList();
            list.CreateList(new int[]{5,2,3,1,8,10});
            list2.CreateList(new int[]{9,6,7,11,12});
            while(true){
                Console.WriteLine("1.Display list ");
                Console.WriteLine("2.Count the number of nodes ");
                Console.WriteLine("3.Search for an element ");
                Console.WriteLine("4.Insert in Start");
                Console.WriteLine("5.Insert in end");
                Console.WriteLine("6.Insert At");
                Console.WriteLine("7.Delete item");
                Console.WriteLine("8.Reverse List");
                Console.WriteLine("9.Bubble Sort");
                Console.WriteLine("9.Bubble Sort By Exchanging links");
                Console.WriteLine("99.end ");
                //Console.WriteLine("6.Display list ");
                Console.Write("Enter your choice:");
                var choice = Convert.ToInt32(Console.ReadLine());
                if (choice ==99){
                    break;
                }
                Console.WriteLine("----------Results start--------------");
                var element = 0;
                switch (choice){
                    case 1:
                        Console.WriteLine("----------List1--------------");
                        list.DisplayList();
                        Console.WriteLine("----------List2--------------");
                        list2.DisplayList();
                        break;
                    case 2:
                        list.Count();
                        break;
                    case 3:
                        Console.Write("Enter your choice:");
                        element = Convert.ToInt32(Console.ReadLine());
                        list.Find(element);
                        break;
                    case 4:
                        Console.Write("Enter your choice:");
                        element = Convert.ToInt32(Console.ReadLine());
                        list.insertAtStart(element);
                        break;
                    case 5:
                        Console.Write("Enter your choice:");
                        element = Convert.ToInt32(Console.ReadLine());
                        list.insertAtEnd(element);
                        break;
                    case 6:
                        Console.Write("Enter your choice:");
                        element = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your loc:");
                        var loc = Convert.ToInt32(Console.ReadLine());
                        list.insertAt(element, loc);
                        break;
                    case 7:
                        Console.Write("Enter your choice:");
                        element = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(element);
                        break;
                    case 8:
                        list.ReverseList();
                        break;
                     case 9:
                        list.BubbleSort();
                        break;
                    case 10:
                        list.BubbleSortByExLinks();
                        break;
                    case 11:
                        var result = list.MergeLinkedList(list2);
                        result.DisplayList();
                        break;
                    
                }
                Console.WriteLine("----------Results end--------------");
            }
        }
    }
}
