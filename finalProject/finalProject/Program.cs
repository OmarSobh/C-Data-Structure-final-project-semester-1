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
            Console.WriteLine();




            Worker W2 = new Worker("Ahmad", "Abufani", 6000);
            Worker W3 = new Worker("alex", "Due", 7000);
            Worker W1 = new Worker("Omar", "Sobh", 5000);
            Node<Worker> Workers = new Node<Worker>();
            Workers = AddFirst(Workers, W1);
            Workers = AddFirst(Workers, W2);
            Workers = AddFirst(Workers, W3);
            Workers = AddFirst(Workers, W1);


            Course C1 = new Course(1, "C#", 90);
            Course C2 = new Course(2, "Java", 87);
            Course C3 = new Course(3, "React", 99);


            Student S1 = new Student("Omar", "Sobh");
            Student S2 = new Student("Ahmad", "AbuFani");
            Student S3 = new Student("alex", "Due");
            Node<Student> Students = new Node<Student>();

            

            S1.AddCourse(C1);
            S1.AddCourse(C2);
            S1.AddCourse(C2);
            S3.AddCourse(C3);

            Students = AddFirst(Students, S1);
            Students = AddFirst(Students, S2);
            Students = AddFirst(Students, S3);

            Console.WriteLine(S1.GetStudentCourses());



            //Console.WriteLine("int  linked list  ");


            ////Q1
            //Console.WriteLine("===============================================");
            //Console.WriteLine($"The list  Length is : {NumberOfNodes(linkedList)} ");

            ////Q2
            //PrintLinkedList(linkedList);


            ////Q3
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Enter a Number To Add To The First");
            ////int first = int.Parse(Console.ReadLine());
            ////linkedList = AddFirst(linkedList, first);
            ////PrintLinkedList(linkedList);

            ////Q4
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Enter a Number To Add To The End ");
            ////int last = int.Parse(Console.ReadLine());
            ////AddLast(linkedList, last);
            ////PrintLinkedList(linkedList);


            ////Q5
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Enter A Number To Add After the value ");
            ////int after = int.Parse(Console.ReadLine());
            ////AddAfter(linkedList, after);
            ////PrintLinkedList(linkedList);

            ////Q6
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Deleting  The First index value of the List");
            //linkedList = DeleteFirst(linkedList);
            //PrintLinkedList(linkedList);

            ////Q7
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Deleting The Last Index value of The List");
            //DeleteLast(linkedList);
            //PrintLinkedList(linkedList);

            ////Q8
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Deleting Index value in the middle of the list");
            ////DeleteAfter(linkedList);
            ////PrintLinkedList(linkedList);

            //// Q9
            // Console.WriteLine("===============================================");
            // Console.WriteLine("The First index value of the list");
            // Console.WriteLine(FirstIndexOfList(linkedList));
            // PrintLinkedList(linkedList);


            //// Q10
            // Console.WriteLine("===============================================");
            // Console.WriteLine("The Last Index value Of the List");
            // Console.WriteLine(LastIndex(linkedList));
            // PrintLinkedList(linkedList);

            ////Q11
            //Console.WriteLine("===============================================");
            //Console.WriteLine("The Value Using the index that sended");
            //Console.WriteLine("Enter the index below:");
            //int index = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The Value is {FindValueUsingIndex(index, linkedList)}");
            //PrintLinkedList(linkedList);

            ////Q12
            //Console.WriteLine("===============================================");
            //Console.WriteLine("checkin if the linked list contained the  value ");
            ////Console.WriteLine("enter the value : ");
            ////int value = int.Parse(Console.ReadLine());
            ////if (IfContains(linkedList, value) == true)
            ////{
            ////    Console.WriteLine("the value Exists in the linked list ");
            ////}
            ////else Console.WriteLine("the value did not  Exists in the linked list");
            ////PrintLinkedList(linkedList);

            ////Q13
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Check If Circular Linked List");
            ////Node<int> circularList = new Node<int>(1);
            ////circularList.SetNext(new Node<int>(2, new Node<int>(3, circularList)));
            ////Console.WriteLine(isCircular(circularList));


            ////Q14
            //Console.WriteLine("===============================================");
            //Console.WriteLine("linked list witheOut Duplicating ");
            //Console.WriteLine(ReturnNewListNoDup(linkedList));

            ////Q15
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Copying the list to new addres ");
            //Console.WriteLine(copyTheListToDifferentLocation(linkedList));


            ////Q16
            //Console.WriteLine("===============================================");
            //Console.WriteLine("print linked list from end to begining");
            //PrintListFromEnd(linkedList);
            //Console.WriteLine();

            ////Q17
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Sorting the linked list From the smalest value to the bigest value ");


            ////Q18
            //Console.WriteLine("===============================================");
            //copyTheListToDifferentLocation(linkedList);
            //Console.WriteLine("cheeking if the linked lists is Equal in length and values ");
            //Console.WriteLine($"the first linked list is :");
            //PrintLinkedList(linkedList);
            //Console.WriteLine("the secound linked list is :");
            //Console.WriteLine(copyTheListToDifferentLocation(linkedList));

            ////true
            //Console.WriteLine(IsEqual(linkedList, copyTheListToDifferentLocation(linkedList)));

            ////false
            //Console.WriteLine(IsEqual(linkedList, copyTheListToDifferentLocation(AddFirst(linkedList, 5))));


            ////Q19
            //Console.WriteLine("===============================================");
            //Console.WriteLine("merging tow lists");
            //Console.WriteLine("first list:");
            //PrintLinkedList(linkedList);
            //Console.WriteLine("secound list:");
            //PrintLinkedList(linkedList);
            ////Console.WriteLine(TwoListsMerge(linkedList, linkedList));








            ////Console.WriteLine("worker linked list function test :");



            //Console.WriteLine(Workers.ToString());

            ////Q1
            //Console.WriteLine("===============================================");
            //Console.WriteLine($"The list  Length is : {NumberOfNodes(Workers)} ");


            ////Q2
            //Console.WriteLine("===============================================");
            //PrintLinkedList(Workers);


            //////Q3
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Adding worker to the first of the list :");
            //Console.WriteLine("Enter First Name:");
            //string fName = Console.ReadLine();
            //Console.WriteLine("enter last Name:");
            //string lName = Console.ReadLine();
            //Console.WriteLine("Enter Salary:");
            //double salarry = double.Parse(Console.ReadLine());
            //Worker NewWorkerToAdd = new Worker(fName, lName, salarry);
            //Workers = AddFirst(Workers, NewWorkerToAdd);
            //PrintLinkedList(Workers);

            //////Q4
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Adding worker to the Last of the list :");
            //Console.WriteLine("Enter First Name:");
            //fName = Console.ReadLine();
            //Console.WriteLine("enter last Name:");
            //lName = Console.ReadLine();
            //Console.WriteLine("Enter Salary:");
            //salarry = double.Parse(Console.ReadLine());
            //Worker NewWorkerToAddToTheLast = new Worker(fName, lName, salarry);
            //AddLast(Workers,NewWorkerToAddToTheLast);
            //PrintLinkedList(Workers);


            ///////Q5
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Adding worker after another worker value ");
            //AddAfter(Workers, W1);
            //PrintLinkedList(Workers);

            ////Q6
            //Console.WriteLine("===============================================");

            //Console.WriteLine("Deleting  The First worker  of the List");
            //Workers = DeleteFirst(Workers);
            //PrintLinkedList(Workers);

            ////Q7
            //  Console.WriteLine("===============================================");
            //Console.WriteLine("Deleting The Last worker of The List");
            //DeleteLast(Workers);
            //PrintLinkedList(Workers);

            ////Q9
            //Console.WriteLine("===============================================");
            //Console.WriteLine("The First index value of the list");
            //Console.WriteLine(FirstIndexOfList(Workers));


            //////Q10
            //Console.WriteLine("===============================================");
            //Console.WriteLine("The Last Index value Of the List");
            //Console.WriteLine(LastIndex(Workers));


            /////Q11
            //Console.WriteLine("===============================================");
            //Console.WriteLine("The worker Using the index that sended");
            //Console.WriteLine("Enter the index below:");
            //int index = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The Value is {FindValueUsingIndex(index, Workers)}");


            ////Q12
            //Console.WriteLine("===============================================");
            //Console.WriteLine("checkin if the workers list contained the  the worker w3: ");

            //if ((IfContains(Workers, W2) == true))
            //{
            //    Console.WriteLine("the worker Exists in the linked list ");
            //}
            //else Console.WriteLine("the worker did not  Exists in the linked list");


            ////Q13
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Check If Circular Linked List");
            //Node<Worker> worker = new Node<Worker>();
            //worker.SetNext(new Node<Worker>(W2, new Node<Worker>(W1, worker)));
            //Console.WriteLine(isCircular(worker));


            ////Q14
            //Console.WriteLine("===============================================");
            //Console.WriteLine("linked workers list  withe Out Duplicating ");
            //Console.WriteLine(ReturnNewListNoDup(Workers));

            /////Q15
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Copying the worker list to new addres ");
            //Console.WriteLine(copyTheListToDifferentLocation(Workers));


            ////Q16
            //Console.WriteLine("===============================================");
            //Console.WriteLine("print workers linked list from end to begining");
            //PrintListFromEnd(Workers);
            //Console.WriteLine();


            ////Q17
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Sorting the linked list From the smalest value to the bigest value ");


            ////Q18
            //Console.WriteLine("===============================================");
            //Console.WriteLine("cheeking if the workers linked lists is Equal in length and values ");
            //Console.WriteLine($"the first linked list is :");
            //PrintLinkedList(Workers);
            //Console.WriteLine("the secound linked list is :");
            //Console.WriteLine(copyTheListToDifferentLocation(Workers));

            ////true
            //Console.WriteLine(IsEqual(Workers, copyTheListToDifferentLocation(Workers)));



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
        public static void PrintLinkedList<T>(Node<T> linkedList)
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
        public static T LastIndex<T>(Node<T> linkedList)
        {
            Node<T> current = linkedList;
            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            return current.GetValue();
        }

        //11.	החזרת הערך לפי אינדקס שנשלח.

        public static T FindValueUsingIndex<T>(int index, Node<T> linkedList)
        {
            Node<T> current = new Node<T>();
            Node<T> nodelist = linkedList;
            if (index > NumberOfNodes(linkedList))
            {
                Console.WriteLine("index not in the list");
                return current.GetValue();
            }
            for (int i = 0; i < NumberOfNodes(linkedList); i++)
            {
                if (i == index)
                {

                    return nodelist.GetValue();
                }
                nodelist = nodelist.GetNext();
            }
            return current.GetValue();
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

        public static void PrintListFromEnd<T>(Node<T> list)
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

        //public static Node<T> SortLinkedList<T>(Node<T> linkedList)
        //{
        //    return;
        //}


        //18.	כתוב פונקציה חיצונית שתקבל שתי רשימות מקושרות ותחזיר אם שתי הרשימות הן אותו דבר מבחינת תוכן (אותו אורך ואותם ערכים).
        static bool IsEqual<T>(Node<T> firstList, Node<T> secoundList)
        {

            if (NumberOfNodes(firstList) != NumberOfNodes(secoundList))
            {
                return false;
            }
            Node<T> First = new Node<T>(firstList.GetValue());
            Node<T> Second = new Node<T>(secoundList.GetValue());

            while (First != null && Second != null)
            {
                if (!First.GetValue().Equals(Second.GetValue()))
                {
                    return false;
                }

                First = First.GetNext();
                Second = Second.GetNext();
            }
            return true;
        }

        //19.	כתוב פונקציה חיצונית שתקבל שתי רשימות מקושרות ותחזיר רשימה חדשה עם כל הערכים שנמצאים בשתי הרשימות
        //(מיזוג מלא של שתי הרשימות לרשימה אחת ללא תלות באם הערך מופיע יותר מפעם אחת).

        //static Node<T> TwoListsMerge<T>(Node<T> list1, Node<T> list2)
        //{
        //    Node<T> newList = new Node<T>();
        //    Node<T> First = new Node<T>(list1);
        //    Node<T> Second = new Node<T>(list2);
        //    for (int i = 0; i < NumberOfNodes(list1); i++)
        //    {
        //        for (int j = 0; j < NumberOfNodes(list2); j++)
        //        {
        //            if (list1.GetValue().Equals(list2.GetValue()))
        //            {
        //                newList=AddFirst( newList, list1.GetValue());
        //            }
        //            list2 = list2.GetNext();
        //        }
        //        list1 = list1.GetNext();
        //    }
        //    return newList;
        //}

        //20.	כתוב פונקציה חיצונית שתקבל שתי רשימות מקושרות ותחזיר רשימה חדשה עם כל הערכים שנמצאים בשתי הרשימות כאשר כל ערך מופיע פעם אחת בלבד
        //(איחוד בין שתי רשימות לרשימה אחת ללא כפילויות).





    }
}
