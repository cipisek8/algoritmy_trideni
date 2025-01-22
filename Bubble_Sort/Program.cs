using System.Diagnostics;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Začínám třídit...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortInt("rando_1M_cela_cisla.txt");
            stopwatch.Stop();
            Console.WriteLine($"Třídil jsem {stopwatch.ElapsedMilliseconds} milisekund.");
        }

        public static void SortInt(string file)
        {
            List<int> values = new();

            using (StreamReader sr = new StreamReader("Inputs\\" + file))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    values.Add(int.Parse(line));
                }
            }

            for (int i = 0; i < values.Count - 1; i++)
            {
                int min = i;
                int temp;
                for (int x = 0; x < values.Count - i - 1; x++)
                {
                    if (values[x] > values[x + 1])
                    {
                        temp = values[x];
                        values[x] = values[x + 1];
                        values[x + 1] = temp;
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("Outputs\\" + file))
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    sw.WriteLine(values[i]);
                }
            }
        }
        public static void SortUint(string file)
        {
            List<uint> values = new();

            using (StreamReader sr = new StreamReader("Inputs\\" + file))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    values.Add(uint.Parse(line));
                }
            }

            for (int i = 0; i < values.Count - 1; i++)
            {
                int min = i;
                uint temp;
                for (int x = 0; x < values.Count - i - 1; x++)
                {
                    if (values[x] > values[x + 1])
                    {
                        temp = values[x];
                        values[x] = values[x + 1];
                        values[x + 1] = temp;
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("Outputs\\" + file))
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    sw.WriteLine(values[i]);
                }
            }
        }
        public static void SortString(string file)
        {
            List<string> values = new();

            using (StreamReader sr = new StreamReader("Inputs\\" + file))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    values.Add(line);
                }
            }

            for (int i = 0; i < values.Count - 1; i++)
            {
                int min = i;
                string temp;
                for (int x = 0; x < values.Count - i - 1; x++)
                {
                    if (string.Compare(values[x], values[x + 1]) > 0)
                    {
                        temp = values[x];
                        values[x] = values[x + 1];
                        values[x + 1] = temp;
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("Outputs\\" + file))
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    sw.WriteLine(values[i]);
                }
            }
        }
    }
}