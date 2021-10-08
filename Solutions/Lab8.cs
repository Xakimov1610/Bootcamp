using System;
using System.Linq;

namespace bootcamp.Solutions
{
    class Lab8
    {
        public void Problem1()
        {
            int[] arr = new int[5];
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            float midle = sum / 5;

            for (int i = 0; i < 5; i++)
            {
                if(arr[i] > midle)
                {
                    Console.Write(arr[i]+ " ");
                }
            }
            System.Console.WriteLine();
        }

        public void Problem2()
        {
            int[] arr = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < 5; i++)
            {
                if(arr[i] > arr[i+1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = arr[i];
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        // public void Problem3()
        // {
            
        // }
    }
}
