namespace customArrsLib
{
    public class SingleArr
    {
        private double[] array = { };
        public SingleArr(double[] arr)
        {
            this.array = arr;
        }
        public SingleArr()
        {
        }
        public double[] getArr()
        {
            return this.array;
        }
        public int getLength()
        {
            return array.Length;
        }
        public double getAnEllement(int index)
        {
            return array[index];
        }
        public void printArr()
        {
            Console.WriteLine(string.Join(" ", this.array));
        }
        public void enterArr()
        {
            int arrSize = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Array[{i + 1}] = ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            this.array = arr;
        }
        public int getAmountOfNegative()
        {
            return this.array.Where(elem => elem < 0).Count();
        }
        public int getAmountOfNegative(int afterInd)
        {
            int counter = 0;
            for(int i = afterInd; i < this.array.Length; i++)
            {
                if (this.array[i] < 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        public int getAmountOfNegative(double allAboveNumb)
        {
            return this.array.Where(elem => elem < 0 && elem > allAboveNumb).Count();
        }
        static public int[] convertToArr(int newArrSize)
        {
            int[] arr = new int[newArrSize];
            for(int i = 0; i < newArrSize; i++)
            {
                arr[i] = 1;
            }
            return arr;
        }
        static public double[] multiplication(double[] arr1, double[] arr2)
        {
            int length1 = arr1.Length;
            int length2 = arr2.Length;
            double[] remainArr = {};
            int lengthOfMin = length1;
            int lengthOfMax = length1;
            if (length1 > length2)
            {
                lengthOfMin = length2;
                remainArr = new Double[length1 - length2];
                Array.Copy(arr1, length2, remainArr, 0, length1 - length2);
            } else if(length2 > length1)
            {
                lengthOfMax = length2;
                remainArr = new Double[length2 - length1];
                Array.Copy(arr2, length1, remainArr, 0, length2 - length1);
            }
            double[] multipliedArr = new double[lengthOfMin];
            for (int i = 0; i < lengthOfMin; i++)
            {
                multipliedArr[i] = arr1[i] * arr2[i];
            }
            double[] resultArr = multipliedArr.Concat(remainArr).ToArray();
            return resultArr;
        }
    }
}