using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace education.Classes
{
    public class WorkingWithArrays<T>
    {
        public int[] Array { get { return array; } set { array = value; } }

        private int[] array = new int[] { };
        public int QuantityOfElements { get; set; }
        public int RangeOfElements { get; set; }
        public void Input()
        {
            Console.WriteLine("Enter range of array elements");
            QuantityOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter range of array elements");
            RangeOfElements = int.Parse(Console.ReadLine());

            array = new int[QuantityOfElements];
        }
        public void GenerateArray()
        {
            Random arrayNums = new Random();

            foreach (int i in array)
            {
                array[i] = arrayNums.Next(0, RangeOfElements - 1);
            }
        }
        public void Output()
        {
            foreach (int i in array)
            {
                Console.WriteLine("Your value {0} at index {{1}}", array[i], i);
            }
        }
        public void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swapped = true;

                    }
                }
                if (!swapped) { break; }
            }


        }
    }
}
