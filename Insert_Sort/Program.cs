using System.Diagnostics;

namespace Insert_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Začínám třídit...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortUint("rando_1M_cela_cisla.txt");
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

            for (int i = 1; i < values.Count; i++)
            {
                int temp = values[i];
                for (int x = i - 1; x >= 0; x--)
                {
                    if (values[x] > temp)
                    {
                        int temp2 = values[x + 1];
                        values[x + 1] = values[x];
                        values[x] = temp2;
                    }
                    else
                        break;
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

            for (int i = 1; i < values.Count; i++)
            {
                uint temp = values[i];
                for (int x = i - 1; x >= 0; x--)
                {
                    if (values[x] > temp)
                    {
                        uint temp2 = values[x + 1];
                        values[x + 1] = values[x];
                        values[x] = temp2;
                    }
                    else
                        break;
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

            for (int i = 1; i < values.Count; i++)
            {
                string temp = values[i];
                for (int x = i - 1; x >= 0; x--)
                {
                    if (string.Compare(values[x], temp) == 1)
                    {
                        string temp2 = values[x + 1];
                        values[x + 1] = values[x];
                        values[x] = temp2;
                    }
                    else
                        break;
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
