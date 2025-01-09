using System.ComponentModel;
using System.Threading;
using Assignment.Structs;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person person = new Person(3);

            //person.AddNewPerson(0, "Adham", 123);
            //person.AddNewPerson(1, "Yehia", 456);
            //person.AddNewPerson(2, "Fathy", 789);

            //for (int i = 0; i < person.Size; i++)
            //{
            //    Console.WriteLine(person[i]);
            //}

            #endregion

            #region Q2 -  Create a struct called "Point" to represent a 2D point with properties "X" and "Y".Write a C# program that takes two points as input from the user and calculates the distance between them.

            //bool flag01;
            //bool flag02;

            //int x , y;

            //do
            //{
            //    Console.Write($"Enter P1.X : ");

            //    flag01 = int.TryParse(Console.ReadLine(), out x);

            //    Console.Write($"Enter P1.Y : ");

            //    flag02 = int.TryParse(Console.ReadLine(), out y);

            //}while( !flag01 && !flag02 );



            //Point P1 = new Point( x , y );

            //do
            //{
            //    Console.Write($"Enter P2.X : ");

            //    flag01 = int.TryParse(Console.ReadLine(), out x);

            //    Console.Write($"Enter P2.Y : ");

            //    flag02 = int.TryParse(Console.ReadLine(), out y);

            //} while (!flag01 && !flag02);

            //Point P2 = new Point(x, y);

            //Console.WriteLine($"The distance between the two points is : {Point.distance(P1, P2)}");


            #endregion

            #region Q3 -  Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person2[] persons = new Person2[3];

            //bool flag;

            //string name;

            //int age;

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Enter Details of person {i + 1}");

            //    do
            //    {

            //        Console.Write("Name: ");

            //        name = Console.ReadLine() ;

            //        Console.Write("Age: ");

            //        flag = int.TryParse(Console.ReadLine(), out age);

            //    }while (!flag && name is null);

            //    persons[i] = new Person2(name , age);

            //    Console.WriteLine();
            //}

            //Person2 oldestPerson = persons[0];

            //for (int i = 1; i < 3; i++)
            //{

            //        if (persons[i].Age > oldestPerson.Age)
            //        {
            //            oldestPerson = persons[i];
            //        }

            //}

            //Console.WriteLine($"The oldest person name is {oldestPerson.Name} and his age is {oldestPerson.Age}");

            #endregion

            #region Q4 - Create a struct named Rectangle that represents a rectangle with the following fields:width(type: double)height(type: double)

            Recatngle rec = new Recatngle();

            double width ,height;

            bool flag01 , flag02;

            do
            {

                Console.Write("Enter Width : ");

                flag01 = double.TryParse(Console.ReadLine(), out width);

                Console.Write("Enter Height : ");

                flag02 = double.TryParse(Console.ReadLine(), out height);
            }while (!flag01 && !flag02);

            Console.WriteLine("===============================");

            rec.Width = width;
            rec.Height = height;

            Console.WriteLine($"Area is {rec.Area}");

            Console.WriteLine("===============================");


            Console.WriteLine(rec);

            #endregion
        }
    }
}
