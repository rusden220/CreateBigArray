using System;
using System.Threading.Tasks;

namespace CreateBigArray
{
	class test
	{
		private int _x = 0;

		public int X
		{
			get { return _x; }
			set { _x = value; }
		}
		
	}
	class Program
	{
		static void Main(string[] args)
		{
			new test().X = 0;

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
