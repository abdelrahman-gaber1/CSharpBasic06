using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic06
{
    internal class BubbleSort<T> where T : IComparable<T>
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static void BubbleSortALgo(T[] arr)
        {
            if (arr is not null)
            {

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    bool falg = false;
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) >=0)
                         BubbleSort<T>.Swap(ref arr[j], ref arr[j + 1]);
                    }
                    if (!falg)
                        break;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
