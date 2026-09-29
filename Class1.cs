using System;

namespace homework
{
    public class ClsMath
    {
       
        public int Sum(int[] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }

            return result;
        }

        public int Max(int[] numbers)
        {
           
            if (numbers.Length == 0)
            {
                return 0;
            }

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        public int Min(int[] numbers)
        {
          
            if (numbers.Length == 0)
            {
                return 0;
            }

            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }
        public int Count(int[] numbers)
        {
            return numbers.Length;
        }
    }
}
