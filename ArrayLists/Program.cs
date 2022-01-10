using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        public static void AddElements(ArrayList list)
        {
            Console.WriteLine("How many elements? ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Add element {0}: ", i + 1);
                int element = Convert.ToInt32(Console.ReadLine());
                list.Add(element);
            }
            Console.WriteLine("Elements added.");
        }
        public static void DisplayList(ArrayList list)
        {
            foreach (Object item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void DeleteByIndex(ArrayList list)
        {
            Console.WriteLine("Enter index to delete: ");
            int index = Convert.ToInt32(Console.ReadLine());
            try
            {
                list.RemoveAt(index);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid index, try again.");
            }
        }
        public static void DeleteRange(ArrayList list)
        {
            Console.WriteLine("Enter starting index: ");
            int startIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            try
            {
                list.RemoveRange(startIndex, count);
            }
            catch (Exception)
            {
                Console.WriteLine("Index out of range or too many elements!");
            }
        }
        public static void AddElementPosition(ArrayList list)
        {
            Console.WriteLine("Enter the position index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the element");
            int element = Convert.ToInt32(Console.ReadLine());
            try
            {
                list.Insert(index, element);
            }
            catch (Exception)
            {
                Console.WriteLine("Index out of range or too many elements!");
            }
        }
        public static void InsertArray(ArrayList list)
        {
            Console.WriteLine("Enter starting position index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many elements: ");
            int elCount = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[elCount];
            for (int i = 0; i < elCount; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            try
            {
                list.InsertRange(index, arr);
            }
            catch (Exception)
            {
                Console.WriteLine("Index out of range or too many elements!");
            }
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("MENU");
            Console.WriteLine("=====================");
            int choice = 0;
            do
            {
                Console.WriteLine("Choose your action: \n\n[1] Add new elements (int)\n[2] Display ArrayList\n[3] Sort list\n[4] Delete by index\n[5] Reverse\n[6] Delete a range of elements\n[7] Insert element in position\n[8] Insert an array of elements in index pos\n[9] Clear list\n[10] Exit");
                Console.WriteLine("");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                switch (userInput)
                {
                    case 1:
                        AddElements(list);
                        break;
                    case 2:
                        DisplayList(list);
                        break;
                    case 3:
                        list.Sort(); //asc
                        break;
                    case 4:
                        DeleteByIndex(list);
                        break;
                    case 5:
                        list.Reverse();
                        Console.WriteLine("List reversed.");
                        break;
                    case 6:
                        DeleteRange(list);
                        break;
                    case 7:
                        AddElementPosition(list);
                        break;
                    case 8:
                        InsertArray(list);
                        break;
                    case 9:
                        list.Clear();
                        break;
                    case 10:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Theres no such choice");
                        Console.ReadLine();
                        break;
                }
            } while (choice != 10);
        }
    }
}
