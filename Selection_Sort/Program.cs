using System.Diagnostics;

namespace Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Začínám třídit...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortUint("test_uint.txt");
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
                for (int x = i + 1; x < values.Count; x++)
                {
                    if (values[x] < values[min])
                        min = x;
                }
                int temp = values[min];
                values[min] = values[i];
                values[i] = temp;
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
                for (int x = i + 1; x < values.Count; x++)
                {
                    if (values[x] < values[min])
                        min = x;
                }
                uint temp = values[min];
                values[min] = values[i];
                values[i] = temp;
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
                for (int x = i + 1; x < values.Count; x++)
                {
                    if (string.Compare(values[x], values[min]) < 0)
                        min = x;
                }
                string temp = values[min];
                values[min] = values[i];
                values[i] = temp;
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
