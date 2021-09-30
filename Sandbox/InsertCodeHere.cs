using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            //int[] myArray = new int[7];
            //myArray[0] = 10;
            //myArray[1] = 3;
            //myArray[2] = myArray[0] + 5;
            //myArray[3] = 6;
            //myArray[4] = 8;
            //myArray[5] = 7;
            //myArray[6] = 17;
            //myArray[7] = 0;

            //int x = 0;
            //while (x < myArray.Length)
            //{
            //    Console.WriteLine( myArray[x] );
            //    x++;
            //}

            //foreach (int v in myArray)
            //{
            //    Console.WriteLine(v);
            //}

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

            exercise_b();
            //exercise_c();
            exersice_D();

            Console.WriteLine("Hello world!");
            // The LAST line of code should be ABOVE this line
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
    }
}