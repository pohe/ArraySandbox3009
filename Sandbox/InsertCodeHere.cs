using System;
using System.Diagnostics;
using System.Security.AccessControl;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Book aBook = new Book("C# programming", "1212132", "John Sharp");


            Book[] bookArray = new Book[5];
            bookArray[0] = aBook;
            bookArray[1] = new Book("Scrum book", "121331", "Peter Scrum");
            bookArray[2] = new Book("Python book", "45646", "Anne Python");
            bookArray[3] = new Book("Pascal book", "4567", "John Pascal");
            bookArray[4] = new Book("The Universe book", "8989", "Signe Universe");

            bookArray[1].Titel = "1001 nats eventyr";

            for (int d = 0; d < bookArray.Length; d++)
            {
                bookArray[d].PrintInfo();
            }

            foreach (Book book in bookArray)
            {
                Console.WriteLine(book );
            }


            string searchAuthor = "Pascal";
            int counter = 0;
            bool authorFound = false;
            while (counter < bookArray.Length && !authorFound)
            {
                if (bookArray[counter].Author.Contains(searchAuthor) )
                {
                    authorFound = true;
                }
                else
                {
                    counter++;
                }
            }

            //udskrive resultat af søgningen
            if (authorFound)
            {
                Console.WriteLine($"Der er fundet forfatteren {bookArray[counter].Author }  på plads {counter} i bookArray");
            }
            else
            {
                Console.WriteLine("Bogen findes ikke");
            }


            int[] myArray = new int[7];
            myArray[0] = 10;
            myArray[1] = 3;
            myArray[2] = myArray[0] + 5;
            myArray[3] = 6;
            myArray[4] = 8;
            myArray[5] = 7;
            myArray[6] = 17;
            //myArray[7] = 0;

            int searchInt = 18;
            // Søge efter tallet

            //foreach (int s in myArray)
            //{
            //    if (s == searchInt)
            //    {
            //        Console.WriteLine(s); 
            //    }
            //}

            int i = 0;
            bool found = false;
            //while (i < myArray.Length && !found )
            //{
            //    if (myArray[i] == searchInt)
            //    {
            //        found = true;
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}
            int index = -1;
            for (int j =0; j<myArray.Length && !found; j++)
            {
                if (myArray[j] == searchInt)
                {
                    index = j;
                    found = true;
                }
            }
            // Udskrive om det findes
            if (found)
            {
                Console.WriteLine($"På indeks {index} findes {myArray[index]}");
            }
            else
            {
                Console.WriteLine("Elementet findes ikke");
            }


            int x = 0;
            while (x < myArray.Length)
            {
                Console.WriteLine(myArray[x]);
                x++;
            }

            for(int y=0; y < myArray.Length; y++  )
            {
                Console.WriteLine(myArray[y]);
            }

            foreach (int v in myArray)
            {
                Console.WriteLine(v);
            }



            string[] names = new string[5];
            names[0] = "Emil";
            names[1] = "Patrick";
            names[2] = "Mikkel";
            names[3] = "Hannibal";
            names[4] = "Serhiy";

            string[] names2 = new[] {"Emil", "Patrick", "Mikkel"};



            //int[] my2Array = new[] {3, 5, 12, 6, 8, 5, 7};
            //my2Array[3]++;

            //for ( int x =  0 ;  x < my2Array.Length  ;  x++ )
            //{
            //    Console.WriteLine(my2Array[x] );
            //}

            //for (int x = my2Array.Length - 1; x >= 0; x--)
            //{
            //    Console.WriteLine(my2Array[x]);
            //}

            //exercise_b();
            //exercise_c();
            //exersice_D();
            //exersice_E();
            //FancyTriangle(20, 20);
            // The LAST line of code should be ABOVE this line
            //int detSigerBangBang = 12; // watch out with setting this to a high number :^)))
            //for (int i = 1; i < detSigerBangBang; i++)
            //{
            //    FancyTriangle(Fibonacci(i), Fibonacci(i - 1));
            //}
        }
        private int Fibonacci(int Length)
        {
            int arraySize = Length + 2;
            int[] numberList = new int[arraySize];



            numberList[0] = 0;
            numberList[1] = 1;



            for (int index = 2; index < arraySize; index++)
            {
                numberList[index] = numberList[index - 1] + numberList[index - 2];
            }



            return numberList[arraySize - 1];



        }


        private void exercise_b()
        {
            const int arraySize = 20;

            int[] numberList = new int[arraySize];  // An array that can hold 5 integers
            for (int index = 0; index < arraySize; index++)
            {
                int value = index + 3;
                numberList[index] = value;
            }
            for (int index = 0; index < arraySize; index++)
            {
                Console.WriteLine("Value stored in numberList[" + index + "]" + " is " + numberList[index]);
            }
        }

        private void exercise_c()
        {
            int[] numberList = new int[5];  // An array that can hold 5 integers
            numberList[5] = 42;
            Console.WriteLine("Done");

        }

        private void exersice_D()
        {
            const int arraySize = 20;
            int[] numberList = new int[arraySize];

            numberList[0] = 0;
            numberList[1] = 1;

            for (int index = 2; index < arraySize; index++)
            {
                numberList[index] = numberList[index - 1] + numberList[index - 2];
            }

            for (int index = 0; index < arraySize; index++)
            {
                Console.WriteLine("Value stored in numberList[" + index + "]" + " is " + numberList[index]);
            }

        }

        private void exersice_E()
        {
            int[] intArray = new int[20];

            //intArray[0] = 0 * 0;
            //intArray[1] = 1 * 1;

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * i;
            }

            //print tallene ud
            foreach (int v in intArray)
            {
                Console.WriteLine(v);
            }
        }

        private void exersice_F()
        {
            int[,] smallTable = new int[11, 11];   // a two-dimensional array!!
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    smallTable[i, j] = i * j;
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + smallTable[i, j]);
                }
            }

        }

        private void FancyTriangle(int Width, int Height)
        {
            Width = Width <= 0 ? 1 : Width;
            Height = Height <= 0 ? 1 : Height;
            int iteration = 0;

            while (iteration < Height + 1)
            {
                for (int spaces = iteration; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }
                for (int w = (Width - iteration); w > 0; w--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
                iteration++;
            }
        }
    }
}