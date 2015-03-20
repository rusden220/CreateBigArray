using System;
using System.Threading.Tasks;

namespace CreateBigArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Create a big array");
#if x64
			int len = int.MaxValue / 2;
#else
			int len = int.MaxValue / 8;
#endif
			float[] array = new float[len];

			Parallel.For(0, len, (i) =>{
				array[i] = i;
			});
			Console.WriteLine("size of array: " + ((long)sizeof(float) * len) );
			//marshal is dropping
			//Console.WriteLine("size of array: " + System.Runtime.InteropServices.Marshal.SizeOf(array));
			Console.ReadLine();
		}
	}
}
