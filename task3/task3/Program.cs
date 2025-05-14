using System.Text.Json;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);
            //Console.WriteLine(args[2]);

           //var args1 = "C:\\Users\\prodigy\\source\\repos\\task3\\values.json";
           //var args2 = "C:\\Users\\prodigy\\source\\repos\\task3\\tests.json";
           // var args3 = "C:\\Users\\prodigy\\source\\repos\\task3\\itog.json";
            //values.json
            FileStream fsValues = new FileStream(args[1], FileMode.OpenOrCreate);
            RootValues values = JsonSerializer.Deserialize<RootValues>(fsValues);


            //tests.json
            List<string> allPoints = new List<string>();
            using (StreamReader reader = new StreamReader(args[0]))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    allPoints.Add(line);
                    Console.WriteLine(line);
                }
            }

            
          
            
            foreach (var a in values.values)
            {
                var sfdsf = allPoints.FindIndex(x => x.Contains("id\": " + a.id.ToString() + ","));

                var sfdssdfsdf = allPoints[sfdsf + 3].Contains("}, {");

                if (sfdssdfsdf == true)
                {
                    allPoints[sfdsf + 2] = "\"value\": \"" + a.value + "\"";
                }

                var sfdssdfsdfdsds = allPoints[sfdsf + 3].Contains("}]");
                if (sfdssdfsdfdsds == true)
                {
                    allPoints[sfdsf + 2] = "\"value\": \"" + a.value + "\"";
                }


                if ((sfdssdfsdf == false) & (sfdssdfsdfdsds == false))
                {
                    allPoints[sfdsf + 2] = "\"value\": \"" + a.value + "\",";
                }

                
            }


            using (StreamWriter writer = new StreamWriter(args[2], false))
            {
                foreach (var a in allPoints)
                {
                    writer.WriteLine(a);
                }
                    
            }

           

        }

  

   }

        public class RootValues
        {
            public List<ValueStatus> values { get; set; }
        }

        public class ValueStatus
        {
            public int id { get; set; }
            public string value { get; set; }
        }


    }
 