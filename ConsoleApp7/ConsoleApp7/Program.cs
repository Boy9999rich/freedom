using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter firstNumber => ");
                var number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter secondNumber => ");
                var number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 / number2);
            }
            catch(Exception eh)
            {
                Console.WriteLine(eh.Message);
            }

            finally
            {
                Console.WriteLine("finish");
            }
           








            //Person person1 = new Person()
            //{
            //    FirstName = "Boy1",
            //    Age = 25,
            //};

            //Person person2 = new Person()
            //{
            //    FirstName = "rich1",
            //    Age = 30,
            //};

            //Console.WriteLine(person1);



            //Point2D list = new Point2D(6,9);
            //Console.WriteLine(list.distanceFromOrigin());

            //MyList<string> list = new MyList<string>(10);
            //list.AddItem("life");
            //list.AddItem("world");
            //Console.WriteLine(list.GetItemAt(0));

            //Console.WriteLine(list.GetCapacity());
            //Console.WriteLine(list.GetCount());

            //List<string> list2 = new List<string>();
            //IList<string> list3 = new List<string>();








           



            //var myList = new MyList<int>(6);
            //myList.AddItem(24);
            //myList.AddItem(14);
            //myList.AddItem(69);
            //myList.AddItem(84);
            //myList.AddItem(94);
            //myList.AddItem(41);

            ////myList.SortAsSelected();
            //myList.SortAsBubble();

            //for (var i = 0; i < myList.GetCount(); i++)
            //{
            //    Console.WriteLine(myList.GetItemAt(i));
            //}
            

            //myList.RemoveItemAt(1);

            //Console.WriteLine(myList.GetCount());
            //Console.WriteLine(myList.GetCapacity());










            //Console.WriteLine(myList.GetItemAt(0));
            //Console.WriteLine(myList.GetItemAt(2));
            //Console.WriteLine(myList.GetItemAt(4));
            //Console.WriteLine(myList.GetItemAt(10));
            //Console.WriteLine(myList.GetItemAt(6));
        }
    }
}
