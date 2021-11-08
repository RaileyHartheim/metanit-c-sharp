using System;

namespace generics_array
{
    class Program
    {
        static void Main(string[] args)
        {

            Array<int> array = new Array<int>();

            //filling the int array
            array.AddElement(23);
            array.AddElement(13);
            array.AddElement(9);
            array.AddElement(62);
            array.ShowArray();

            //checking a length of int array
            array.GetLength();

            //getting an element by index
            Console.WriteLine(array.GetElementValue(2));

            //deleting an element
            array.DeleteElementByIndex(2);
            array.ShowArray();

            //all the same for a string array
            Array<string> array_str = new Array<string>();

            
            array_str.AddElement("24");
            array_str.AddElement("aaaaa");
            array_str.AddElement("hello i love you");
            array_str.AddElement("no i don't love you");
            array_str.AddElement("no way");
            array_str.ShowArray();


            array_str.GetLength();

            Console.WriteLine(array_str.GetElementValue(2));

            array_str.DeleteElementByIndex(2);
            array_str.ShowArray();


            Console.ReadKey();
        }


    }

    class Array<U>
    {
        U[] data;

        public Array()
        {
            data = new U[0];
        }

        //add element into array
        public void AddElement(U item)
        {
            U[] temp_arr = new U[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                temp_arr[i] = data[i];
            }
            temp_arr[data.Length] = item;
            data = temp_arr;
        }

        //delete element from array by index
        public void DeleteElementByIndex(int index)
        {
            U[] temp_arr = new U[data.Length - 1];

            for (int i = 0; i < index; i++)
            {
                temp_arr[i] = data[i];
            }

            for (int i = index; i < data.Length - 1; i++)
            {
                temp_arr[i] = data[i + 1];
            }
            data = temp_arr;

        }

        //get element value from array by index
        public U GetElementValue(int index)
        {
            if (index >= data.Length || index < 0)
                throw new IndexOutOfRangeException();
            else
                return data[index];
        }

        //get length of array
        public void GetLength()
        {
            int length = 0;
            foreach (U obj in data)
            {
                length++;
            }
            Console.WriteLine($"The length of the array is {length} elements.");
        }

        public void ShowArray()
        {
            Console.Write("The array consists of: ");
            foreach (U element in data)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

    }
}
