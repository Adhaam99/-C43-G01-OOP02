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

            Person person = new Person(3);

            person.AddNewPerson(0, "Adham", 123);
            person.AddNewPerson(1, "Yehia", 456);
            person.AddNewPerson(2, "Fathy", 789);

            for (int i = 0; i < person.Size; i++)
            {
                Console.WriteLine(person[i]);
            }



            #endregion
        }
    }
}
