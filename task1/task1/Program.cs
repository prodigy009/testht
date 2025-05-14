namespace task1
{
    internal class Program
    {

        static IEnumerable<int> Seq(int n, int m)
        {
            yield return 1;
            for (int i = m - 1; i < n * m; i += m - 1)
            {
                int v = i % n + 1;
                if (v == 1) yield break;
                yield return v;
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]); 
            int m = Convert.ToInt32(args[1]);
            Console.WriteLine(string.Join(", ", Seq(n, m)));
            Console.ReadKey();
        }

    }
}