namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 12, 21, 23, 24, -1, -2, -3, 4, 5, };
            ConvertNegativesToPositives(ref myArray);

        }

        static void ConvertNegativesToPositives(ref int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < 0)
                    myArray[i] *= -1;
            }
        }
    }
}