using System.Diagnostics;

namespace Heap_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Začínám třídit...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortString("random_words_10M.txt");
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

            int n = values.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(values, n, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                int temp = values[0];
                values[0] = values[i];
                values[i] = temp;

                Heapify(values, i, 0);
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

            int n = values.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(values, n, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                uint temp = values[0];
                values[0] = values[i];
                values[i] = temp;

                Heapify(values, i, 0);
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

            int n = values.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(values, n, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                string temp = values[0];
                values[0] = values[i];
                values[i] = temp;

                Heapify(values, i, 0);
            }

            using (StreamWriter sw = new StreamWriter("Outputs\\" + file))
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    sw.WriteLine(values[i]);
                }
            }
        }

        static void Heapify(List<int> input, int length, int i)
        {
            int largest = i;

            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < length && input[left] > input[largest])
            {
                largest = left;
            }

            if (right < length && input[right] > input[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = input[i];
                input[i] = input[largest];
                input[largest] = temp;

                Heapify(input, length, largest);
            }
        }
        static void Heapify(List<uint> input, int length, int i)
        {
            int largest = i;

            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < length && input[left] > input[largest])
            {
                largest = left;
            }

            if (right < length && input[right] > input[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                uint temp = input[i];
                input[i] = input[largest];
                input[largest] = temp;

                Heapify(input, length, largest);
            }
        }
        static void Heapify(List<string> input, int length, int i)
        {
            int largest = i;

            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < length && string.Compare(input[left], input[largest]) == 1)
            {
                largest = left;
            }

            if (right < length && string.Compare(input[right], input[largest]) == 1)
            {
                largest = right;
            }

            if (largest != i)
            {
                string temp = input[i];
                input[i] = input[largest];
                input[largest] = temp;

                Heapify(input, length, largest);
            }
        }
    }
}
