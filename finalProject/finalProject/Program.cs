using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace finalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Node 
            Node<int> node1 = new Node<int>(10);
            Node<int> node3 = new Node<int>(30);
            Node<int> node2 = new Node<int>(20, node3);
            node1.SetNext(node2);
            Node<int> node4 = new Node<int>(10);
            node3.SetNext(node4);
            Node<int> linkedList = new Node<int> (node1);
            Console.WriteLine();
            Console.WriteLine(linkedList);


            //Worker Node
            Worker W2 = new Worker("Ahmad", "Abufani", 6000);
            Worker W3 = new Worker("alex", "Due", 7000);
            Worker W1 = new Worker("Omar", "Sobh", 5000);
            Node<Worker> Workers = new Node<Worker>();
            Workers = AddFirst(Workers, W1);
            Workers = AddFirst(Workers, W2);
            Workers = AddFirst(Workers, W3);
            Workers = AddFirst(Workers, W1);




            //Courses objects 
            Course C1 = new Course(1, "C#", 90);
            Course C2 = new Course(2, "Java", 87);
            Course C3 = new Course(3, "React", 99);
            Course C4 = new Course(4, "OOP", 78);
            Course C5 = new Course(5, "ReactNative", 90);
            Course C6 = new Course(6, "Nodejs", 88);




            // Courses linked list

            Node<Course> listOfCourses = new Node<Course>();
            listOfCourses = AddFirst(listOfCourses, C1);
            listOfCourses = AddFirst(listOfCourses, C2);
            listOfCourses = AddFirst(listOfCourses, C3);

            Node<Course> listOfCourses2 = new Node<Course>();
            listOfCourses2 = AddFirst(listOfCourses2, C4);
            listOfCourses2 = AddFirst(listOfCourses2, C5);
            listOfCourses2 = AddFirst(listOfCourses2, C6);

            //Students objects
            Student S1 = new Student("Omar", "Sobh", listOfCourses);
            Student S2 = new Student("Ahmad", "AbuFani", listOfCourses2);
            Student S3 = new Student("Adam", "jan", listOfCourses);
            Student S4 = new Student("Kareem", "Jumaa", listOfCourses2);
            Student S5 = new Student("Mahmod", "Hadi", listOfCourses);
            Student S6 = new Student("Tayeb", "hajYehia", listOfCourses2);




            //Students Linked list 
            Node<Student> Students1 = new Node<Student>();
            Students1 = AddFirst(Students1, S3);
            Students1 = AddFirst(Students1, S2);
            Students1 = AddFirst(Students1, S1);

            Node<Student> Students2 = new Node<Student>();
            Students2 = AddFirst(Students2, S4);
            Students2 = AddFirst(Students2, S5);
            Students2 = AddFirst(Students2, S6);

            //Console.WriteLine(Students1);
            //Console.WriteLine(Students2);




            //Classes  Array 

            Node<Student[]> Classes = new Node<Student[]>();

            Student[] class1 = new Student[] { S1, S2, S3 };
            Student[] class2 = new Student[] { S4, S5, S6 };
            Student[] class3 = new Student[] { S1, S3, S4 };


            Classes = AddFirst(Classes, class3);
            Classes = AddFirst(Classes, class2);
            Classes = AddFirst(Classes, class1);











            //int  linked list 


            ////Q1
            //Console.WriteLine("===============================================");
            //Console.WriteLine($"The list  Length is : {NumberOfNodes(linkedList)} ");

            ////Q2
            //PrintLinkedList(linkedList);


            ////Q3
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Enter a Number To Add To The First");
            //int first = int.Parse(Console.ReadLine());
            //linkedList = AddFirst(linkedList, first);
            //PrintLinkedList(linkedList);

            ////Q4
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Enter a Number To Add To The End ");
            //int last = int.Parse(Console.ReadLine());
            //AddLast(linkedList, last);
            //PrintLinkedList(linkedList);


            ////Q5
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Enter A Number To Add After the value ");
            //int after = int.Parse(Console.ReadLine());
            //AddAfter(linkedList, after);
            //PrintLinkedList(linkedList);

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
            //DeleteAfter(linkedList);
            //PrintLinkedList(linkedList);

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

            // // Q13
            ////Console.WriteLine("===============================================");
            ////Console.WriteLine("Check If Circular Linked List");
            ////Node<int> circularList = new Node<int>(1);
            ////circularList.SetNext(new Node<int>(2, new Node<int>(3, circularList))); //ההפניה היא circularList 
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

            //Q17
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Sorting the linked list From the smalest value to the bigest value ");
            //SortLinkedList(linkedList);
            //PrintListFromEnd(linkedList);

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
            Console.WriteLine("===============================================");
            Console.WriteLine("merging tow lists");
            Console.WriteLine("first list:");
            PrintLinkedList(linkedList);
            Console.WriteLine("secound list:");
            PrintLinkedList(linkedList);
            Console.WriteLine(ListsMergeQ19(linkedList, linkedList));






            //Q22

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


            //Students loinked list 

            ////Q23 
            //Console.WriteLine("===============================================");
            //Console.WriteLine("Printing Studunts Average : ");
            //StudentsCoursesAverage(Students1);



            /////Q24 
            //Console.WriteLine("The Best Student Average is : ");
            //Node<Student> Best = TheBestStudents(Classes);
            //Console.WriteLine(Best);

            /////Q25
            //Console.WriteLine("the Worst Students is : ");
            //Node<Student> Worst = WorsetStudents(Classes);
            //Console.WriteLine(Worst);

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
        public static void AddLast<T>(Node<T> linkedList, T value)
        {
            Node<T> newNode = new Node<T>(value);

            while (linkedList.HasNext())
            {
                linkedList = linkedList.GetNext();
            }

            linkedList.SetNext(newNode);
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
            return list.GetNext();
            
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
                prev.SetNext(temp.GetNext()); ///skiping  the secound node
                temp.SetNext(null);    //deleting node line(seting to null) 
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

        
        public static void SortLinkedList<T>(Node<T> linkedlistHead) where T : IComparable<T>
        {
            Node<T> current = linkedlistHead;
            while (current != null)
            {
                Node<T> min = current;
                Node<T> next = current.GetNext();
                while (next != null)
                {
                    if (next.GetValue().CompareTo(min.GetValue()) < 0)
                    {
                        min = next;
                    }
                    next = next.GetNext();
                }
                T nextValue = current.GetValue();
                current.SetValue(min.GetValue());
                min.SetValue(nextValue);
                current = current.GetNext();
                
            }

        }

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

        static Node<T> ListsMergeQ19<T>(Node<T> List1, Node<T> List2)
        {

            if (List1==null)
            {
                return List2;
            }
            if (List2==null)
            {
                return List1;
            }

            Node<T> Merged = new Node<T>(List1);
            Node<T> secoundList = new Node<T>(List2);

            for (int i = 0; i < NumberOfNodes(secoundList); i++)
            {
                AddLast(Merged, secoundList.GetValue());
                secoundList = secoundList.GetNext();
            }


            return Merged;
        }



        //static Node<T> TwoListsMerge<T>(Node<T> list1, Node<T> list2)
        //{
        //    Node<T> newList = new Node<T>();
            
        //    for (int i = 0; i < NumberOfNodes(list1); i++)
        //    {
        //        for (int j = 0; j < NumberOfNodes(list2); j++)
        //        {
        //            if (list1.GetValue().Equals(list2.GetValue()))
        //            {
        //                newList = AddFirst(newList, list1.GetValue());
        //            }
        //            list2 = list2.GetNext();
        //        }
        //        list1 = list1.GetNext();
        //    }
        //    return newList;
        //}

        //20.	כתוב פונקציה חיצונית שתקבל שתי רשימות מקושרות ותחזיר רשימה חדשה עם כל הערכים שנמצאים בשתי הרשימות כאשר כל ערך מופיע פעם אחת בלבד
        //(איחוד בין שתי רשימות לרשימה אחת ללא כפילויות).



        //23.	כתוב פונקציה חיצונית שתקבל רשימה מקושרת של סטודנטים Node<Student> ותדפיס את ממוצע הציונים של כל סטודנט ברשימה
        //(תחשב את הממוצע לפי סכום הציונים חלקי מספר הקורסים). בנה רשימה מתאימה וקרא לה מתוך Main.

        static void StudentsCoursesAverage(Node<Student> students)
        {
            Node<Student> currentStudent = new Node<Student>(students);
            for (int i = 0; i < NumberOfNodes(students); i++)
            {
                if (currentStudent.GetValue() == null)
                {
                    return;
                }
                Console.WriteLine($"Student Name : {currentStudent.GetValue().GetStudentFirstName()} His Average is : {currentStudent.GetValue().GetAvg()}");
                currentStudent = currentStudent.GetNext();
            }
        }

        ///24.	כתוב פונקציה חיצונית שתקבל רשימה של מערכים מסוג  Node<Student[]> (רשימה שכל חוליה בתוכה מכילה מערך של סטודנטים).
        ///  הרשימה מתארת מספר כיתות.לכל כיתה מערך של סטודנטים.
        ///עליך להחזיר רשימה של הסטודנטים המצטיינים (ממוצע ציונים הכי גבוה). הנח שיש מצטיין אחד בכל כיתה.בנה רשימה מתאימה וקרא לה מתוך Main.


        static Node<Student> TheBestStudents(Node<Student[]> classes)
        {
            Node<Student[]> ArrayOfStudents = new Node<Student[]>(classes.GetValue());
            Node<Student> theBestStudents = new Node<Student>();

            while (ArrayOfStudents != null)
            {
                int index = 0;
                for (int i = 1; i < ArrayOfStudents.GetValue().Length; i++)
                {
                    if (ArrayOfStudents.GetValue()[i].GetAvg() > ArrayOfStudents.GetValue()[i - 1].GetAvg())
                        index = i;
                    else
                        index = i - 1;
                }
                theBestStudents = AddFirst(theBestStudents, ArrayOfStudents.GetValue()[index]);
                ArrayOfStudents = ArrayOfStudents.GetNext();
            }

            return theBestStudents;


        }

        ////25.
        //// כתוב פונקציה חיצונית שתקבל מערך של רשימות מסוג
        //Node<Student>[] (מערך שכל תא בתוכו הוא רשימה של סטודנטים).
        // המערך מתאר מספר כיתות.לכל כיתה רשימה של סטודנטים.
        //עליך להחזיר מערך של הסטודנטים עם הכי הרבה נכשלים בקורסים (הנח שיש לכל היותר אחד כזה בכל כיתה). בנה רשימה מתאימה וקרא לה מתוך Main.

        static Node<Student> WorsetStudents(Node<Student[]> classes)//25
        {
            Node<Student[]> arrayOfStudents = new Node<Student[]>(classes.GetValue());
            Node<Student> worstStudents = new Node<Student>();
            while (arrayOfStudents != null)
            {
                int index = 0;
                for (int i = 1; i < arrayOfStudents.GetValue().Length; i++)
                {
                    if (arrayOfStudents.GetValue()[i].GetAvg() < arrayOfStudents.GetValue()[i - 1].GetAvg())
                        index = i;
                    else
                        index = i - 1;
                }
                worstStudents = AddFirst(worstStudents, arrayOfStudents.GetValue()[index]);

                arrayOfStudents = arrayOfStudents.GetNext();
            }
            return worstStudents;
        }




    }






}
