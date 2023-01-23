using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace finalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Node<int> node1 = new Node<int>(10);
            Node<int> node3 = new Node<int>(30);
            Node<int> node2 = new Node<int>(20, node3);
            node1.SetNext(node2);
            Node<int> node4 = new Node<int>(10);
            node3.SetNext(node4);
            Node<int> linkedList = node1;
            Console.WriteLine(linkedList);




            Console.WriteLine("=================================");
            Console.WriteLine($"The list  Length is : {NumberOfNodes(linkedList)} ");

            //Console.WriteLine("=================================");
            //PrintLinkedList(linkedList);

            Console.WriteLine("=================================");
            Console.WriteLine("Enter a Number To Add To The First");
            //int first = int.Parse(Console.ReadLine());
            //linkedList = AddFirst(linkedList, first);
            //PrintLinkedList(linkedList);

            Console.WriteLine("=================================");
            Console.WriteLine("Enter a Number To Add To The End ");
            //int last = int.Parse(Console.ReadLine());
            //AddLast(linkedList, last);
            //PrintLinkedList(linkedList);

            Console.WriteLine("=================================");
            Console.WriteLine("Enter A Number To Add After the value ");
            //int after = int.Parse(Console.ReadLine());
            //AddAfter(linkedList, after);
            //PrintLinkedList(linkedList);

            Console.WriteLine("=================================");
            Console.WriteLine("Deleting  The First index value of the List");
            //linkedList = DeleteFirst(linkedList);
            //PrintLinkedList(linkedList);

            Console.WriteLine("=================================");
            Console.WriteLine("Deleting The Last Index value of The List");
            //DeleteLast(linkedList);
            //PrintLinkedList(linkedList);

            Console.WriteLine("=================================");
            Console.WriteLine("Deleting Index value in the middle of the list");
            //DeleteAfter(linkedList);
            //PrintLinkedList(linkedList);


            Console.WriteLine("=================================");
            Console.WriteLine("The First index value of the list");
            //Console.WriteLine(FirstIndexOfList(linkedList));
            //PrintLinkedList(linkedList);



            Console.WriteLine("=================================");
            Console.WriteLine("The Last Index value Of the List");
            //Console.WriteLine(LastIndex(linkedList));
            //PrintLinkedList(linkedList);

            Console.WriteLine("=================================");
            Console.WriteLine("The Value Using the index that sended");
            Console.WriteLine("Enter the index below:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Value is {FindValueUsingIndex(index, linkedList)}");
            PrintLinkedList(linkedList);

            Console.WriteLine("=================================");
            Console.WriteLine("checkin if the linked list contained the  value ");
            //Console.WriteLine("enter the value : ");
            //int value = int.Parse(Console.ReadLine());
            //if (IfContains(linkedList, value) == true)
            //{
            //    Console.WriteLine("the value Exists in the linked list ");
            //}
            //else Console.WriteLine("the value did not  Exists in the linked list");
            //PrintLinkedList(linkedList);


            Console.WriteLine("=================================");
            Console.WriteLine("Check If Circular Linked List");
            //Node<int> circularList = new Node<int>(1);
            //circularList.SetNext(new Node<int>(2, new Node<int>(3, circularList)));
            //Console.WriteLine(isCircular(circularList));

            Console.WriteLine("=================================");
            Console.WriteLine("linked list witheOut Duplicating ");
            Console.WriteLine(ReturnNewListNoDup(linkedList));

            Console.WriteLine("=================================");
            Console.WriteLine("Copying the list to new addres ");
            Console.WriteLine(copyTheListToDifferentLocation(linkedList));



            Console.WriteLine("=================================");
            Console.WriteLine("print linked list from end to begining");
            PrintListFromEnd(linkedList);
            Console.WriteLine();


            Console.WriteLine("=================================");
            Console.WriteLine("Sorting the linked list From the smalest value to the bigest value ");


        }


        //1.	החזרת אורך הרשימה.
        public static int NumberOfNodes<T>(Node<T> linkedList)
        {
            int counter = 0;

            while (linkedList != null)
            {
                counter++;
                linkedList = linkedList.GetNext();
            }

            return counter;
        }

        //2.	הדפסת הרשימה.
        public static void PrintLinkedList(Node<int> linkedList)
        {
            Console.WriteLine(linkedList);
        }

        //3.	הוספת ערך בתחילת הרשימה.
        public static Node<T> AddFirst<T>(Node<T> linkedList, T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.SetNext(linkedList);
            linkedList = newNode;
            return linkedList;
        }

        //4.	הוספת ערך בסוף הרשימה.
        public static void AddLast<T>(Node<T> head, T value)
        {
            Node<T> newNode = new Node<T>(value);

            while (head.HasNext())
            {
                head = head.GetNext();
            }

            head.SetNext(newNode);
        }

        //5.	הוספת ערך באמצע הרשימה AddAfter.
        public static void AddAfter<T>(Node<T> prev, T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.SetNext(prev.GetNext());
            prev.SetNext(newNode);
        }
        //6.	מחיקת ערך בתחילת הרשימה.
        public static Node<T> DeleteFirst<T>(Node<T> list)
        {
            Node<T> temp = list;
            list = list.GetNext();
            temp.SetNext(null);
            return list;
            //list is sent by value so we need to return it or to get it by reference
        }

        //7.	מחיקת ערך בסוף הרשימה.
        public static void DeleteLast<T>(Node<T> head)
        {
            Node<T> prev = null;
            Node<T> temp = head;
            while (temp.HasNext())
            {
                prev = temp;
                temp = temp.GetNext();
            }
            prev.SetNext(null);
        }
        //8.	מחיקת ערך באמצע הרשימה DeleteAfter.
        public static void DeleteAfter<T>(Node<T> prev)
        {
            if (prev != null && prev.HasNext())
            {
                Node<T> temp = prev.GetNext();
                prev.SetNext(temp.GetNext());
                temp.SetNext(null);
            }
        }
        //9.	החזרת הערך בתחילת הרשימה.
        public static T FirstIndexOfList<T>(Node<T> linkedList)
        {
            return linkedList.GetValue();
        }

        //10.	החזרת הערך בסוף הרשימה.
        public static Node<T> LastIndex<T>(Node<T> linkedList)
        {
            Node<T> current = linkedList;
            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }
            return current;
        }

        //11.	החזרת הערך לפי אינדקס שנשלח.

        public static T FindValueUsingIndex<T>(int index, Node<T> linkedList)
        {
            int length = NumberOfNodes(linkedList);
            if (index > length - 1 || index < 0)
                return default(T);

            Node<T> First = new Node<T>(linkedList.GetValue());
            for (int i = length - 1; i > index; i--)
                First = First.GetNext();
            return First.GetValue();
        }


        //12.	בדיקה האם הערך שנשלח קיים ברשימה או לא.

        public static bool IfContains<T>(Node<T> linkedList, T value)
        {

            if (linkedList == null)
                return false;

            while (linkedList != null)
            {
                if (linkedList.GetValue().Equals(value))
                {
                    return true;
                }

                linkedList = linkedList.GetNext();
            }

            return false;
        }

        //13.	בדיקה האם הרשימה שנשלחה היא רשימה מעגלית.
        //  רשימה מעגלית היא רשימה שבה האיבר האחרון מצביע לאיבר הראשון.

        public static bool isCircular<T>(Node<T> head)
        {

            if (head == null)
                return true;

            Node<T> node = head.GetNext();
            while (node != null && node != head)
                node = node.GetNext();
            return (node == head);
        }


        //14.	ניפוי הערכים הכפולים ברשימה (או ע"י מחיקת הכפילויות מתוך הרשימה שקיבלנו או ע"י בניית רשימה חדשה ללא כפילויות).
        public static Node<T> ReturnNewListNoDup<T>(Node<T> list)
        {
            if (list == null)
                return null;

            Node<T> newListNoDup = new Node<T>(list.GetValue());

            Node<T> temp = newListNoDup;

            list = list.GetNext();

            while (list != null)
            {
                if (!IfContains(newListNoDup, list.GetValue()))
                {
                    Node<T> newNode = new Node<T>(list.GetValue());
                    temp.SetNext(newNode);
                    temp = temp.GetNext();
                }
                list = list.GetNext();
            }

            return newListNoDup;
        }






        //15.	החזרת רשימה חדשה שהיא שכפול של הרשימה ששלחת (מחזירה אותה רשימה אבל בכתובת אחרת).

        public static Node<T> copyTheListToDifferentLocation<T>(Node<T> linkedList)
        {

            return new Node<T>(linkedList);
        }


        //16.	הפיכת הרשימה מהסוף להתחלה ללא יצירת רשימה חדשה. אם הרשימה הייתה 123null היא תהפוך להיות 321null

        public static void PrintListFromEnd(Node<int> list)
        {
            if (list == null)
            {
                return;
            }

            PrintListFromEnd(list.GetNext());
            Console.Write(list.GetValue() + " ");
        }

        // 17.	מיון הרשימה מהקטן לגדול. שים לב שאיברי הרשימה הם מסוג  Tועליך לחשוב איך להשוות בין שני אובייקטים.
        //רמז: תחקור איך המתודה Sort של המחלקה List של #C יודעת לעשות מיון לרשימה מכל סוג.

        //public static Node<T>  SortLinkedList<T>(Node<T>linkedList)
        //{
        //    Node<T> prevNode = new Node<T>( linkedList.GetValue());
        //    Node<T> currNode = new Node<T>(linkedList.GetNext().GetValue());
        //    while (currNode != null)
        //    {
        //        int res = prevNode.(currNode);
        //        if (res == 1)
        //        {
        //            prevNode.Next = currNode.Next;
        //            currNode.Next = head;
        //            this.head = currNode;
        //            currNode = prevNode;
        //        }
        //        else
        //        {
        //            prevNode = currNode;
        //        }
        //        currNode = currNode.Next;
        //    }
        //    return currNode;
        //}



    }
}
