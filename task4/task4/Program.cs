namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] b = null;
            List<int[]> allPoints = new List<int[]>();

            using (StreamReader reader = new StreamReader(args[0]))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    b = line.Split(' ');
                }
               
            }

            int[] a = Array.ConvertAll(b, int.Parse);

            //int[] a = { 1, 2, 3 };
            int m = a.OrderBy(x => x).ElementAt(a.Length / 2);
            Console.WriteLine(a.Sum(v => Math.Abs(v - m)));
            Console.ReadKey();
        }
    }
}