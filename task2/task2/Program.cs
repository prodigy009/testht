namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<int[]> allPoints = GetPointFromFile(args[1]);

            List<int> allPointsCircle = GetPointCircle(args[0]);

            foreach (var c in allPoints)
            {

                double baseNumber = allPointsCircle[2];
                double exponent = 2;
                double result = Math.Pow(baseNumber, exponent);

                var sds = c[0] - allPointsCircle[0];
                double dsfdsfds = Math.Pow(sds, exponent);


                var sdfsd = c[1] - allPointsCircle[1];
                double sdfdsfs = Math.Pow(sdfsd, exponent);



                bool dfdfd = dsfdsfds + sdfdsfs <= result;

                if (dsfdsfds + sdfdsfs == result)
                {
                    Console.WriteLine("0");
                }
                if (dsfdsfds + sdfdsfs < result)
                {
                    Console.WriteLine("1");
                }
                if (dsfdsfds + sdfdsfs > result)
                {
                    Console.WriteLine("2");
                }




                
            }


            Console.ReadKey();

        }

        static List<int[]> GetPointFromFile(string path)
        {
            List<int[]> allPoints = new List<int[]>();

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] pointXandY = line.Split(' ');
                    int[] pointXandYint = new int[2] { Convert.ToInt32(pointXandY[0]), Convert.ToInt32(pointXandY[1]) };
                    allPoints.Add(pointXandYint);
                    //Console.WriteLine(line);

                }
                return allPoints;
            }
        }

        static List<int> GetPointCircle(string path)
        {
            List<int> allPoints = new List<int>();

            string secondLine = File.ReadLines(path).ElementAtOrDefault(0);
            string[] XAndYPoints = secondLine.Split(' ');
            int[] XAndYPointsInt = new int[2];
            XAndYPointsInt[0] = Convert.ToInt32(XAndYPoints[0]);
            XAndYPointsInt[1] = Convert.ToInt32(XAndYPoints[1]);
            int rad = Convert.ToInt32(File.ReadLines(path).ElementAtOrDefault(1));

            allPoints.Add(XAndYPointsInt[0]);
            allPoints.Add(XAndYPointsInt[1]);
            allPoints.Add(rad);

            return allPoints;
        }





    }
}