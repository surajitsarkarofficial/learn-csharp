
namespace learn_csharp.Basics
{
	public class CsArrays
	{
		public static void ArrayBasics()
		{

			int[] arr1 = new int[] { 10, 30, 50, 80, 05 };
            Console.WriteLine("Printing array 1 data - ");
            foreach (int data in arr1)
			{
                Console.WriteLine(data);
            }

			int[] arr2 = new int[3];
			for(int i=0;i<arr2.Length;i++)
			{
				arr2[i] = (i + 1 )* 10;
			}
			Console.WriteLine("Printing array 2 data - ");
			for(int i=0;i<arr2.Length;i++)
			{
				Console.WriteLine(arr2[i]);
			}
			string[] arr3 = new string[] { "Ram", "Shyam", "Sita", "Hanuman" };

            Console.WriteLine("Printing array 3 data - ");
            foreach (string data in arr3)
            {
                Console.WriteLine(data);
            }

        }
	}
}

