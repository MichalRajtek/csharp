using System.Data;

namespace Cvicenie_StringMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = Scitanie(a, b, 1, 2, 3);
            int sum4 = Scitanie(a, b, 1, 2, 3);
            int su8 = Scitanie(a, b, 1, 2, 3);
            int su9 = Scitanie(a, b, 1, 2, 3);
            Console.WriteLine(sum);
        }

        public static int Scitanie(int a, int b, int c, int d, int e)
        {
            int ff = a + b + c + d + e;
            return ff;
        }
    }
}
