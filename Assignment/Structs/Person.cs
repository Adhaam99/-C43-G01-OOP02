using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.Structs
{
    internal struct Person
    {
        #region properties

        public string[]? Name { get; set; }

        public int[]? Age { get; set; }

        public int Size { get; set; }


        #endregion

        #region Constructors

        public Person(int size)
        {

            Size = size;
            Name = new string[Size];
            Age = new int[Size];

        }

        #endregion

        #region Methods

        public void AddNewPerson(int position, string name,  int age)
        {
            if (Name is not null && Age is not null)
            {
                if (position < Size && position >= 0)
                {
                    Name[position] = name;
                    Age[position] = age;
                }
            }
        }

        #endregion

        #region Getter

        public string this[int index]
        {
            get
            {

                if (Name is not null && Age is not null)
                {
                    return $"Index : {index + 1 } :: Name : {Name[index]} :: Age : {Age[index]}";
                }
                return "";
            }

        }

        #endregion

    }
}
