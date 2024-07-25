namespace CSharpBasic06
{
    internal class Program
    {
        
        static void Main()
        {
            #region One
            int[] arr = { 4, 8, 86, 58, 74, 54, 36, 3, 8510, 14 };
            BubbleSort<int>.BubbleSortALgo(arr);
            #endregion

            #region Two
            NewRange<int> range = new NewRange<int>(10, 52);
            Console.WriteLine( NewRange<int>.IsInRange(90));
            #endregion
        }
    }
}
