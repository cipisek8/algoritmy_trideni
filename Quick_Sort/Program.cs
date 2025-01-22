using System.Diagnostics;

namespace Quick_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Začínám třídit...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortInt("random_integers_10M.txt");
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

            QuickSort(ref values, 0, values.Count - 1);

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

            QuickSort(ref values, 0, values.Count - 1);

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

            QuickSort(ref values, 0, values.Count - 1);

            using (StreamWriter sw = new StreamWriter("Outputs\\" + file))
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    sw.WriteLine(values[i]);
                }
            }
        }


        public static void QuickSort(ref List<int> input, int start, int end)
        {
            if (start >= end)
                return;

            int pivot = start;
            int temp;

            for (int i = start; i <= end; i++)
            {
                if (input[i] < input[end])
                {
                    temp = input[i];
                    input[i] = input[pivot];
                    input[pivot] = temp;
                    pivot++;
                }
            }

            temp = input[pivot];
            input[pivot] = input[end];
            input[end] = temp;

            QuickSort(ref input, start, pivot - 1);
            QuickSort(ref input, pivot + 1, end);
        }
        public static void QuickSort(ref List<uint> input, int start, int end)
        {
            if (start >= end)
                return;

            int pivot = start;
            uint temp;

            for (int i = start; i <= end; i++)
            {
                if (input[i] < input[end])
                {
                    temp = input[i];
                    input[i] = input[pivot];
                    input[pivot] = temp;
                    pivot++;
                }
            }

            temp = input[pivot];
            input[pivot] = input[end];
            input[end] = temp;

            QuickSort(ref input, start, pivot - 1);
            QuickSort(ref input, pivot + 1, end);
        }
        public static void QuickSort(ref List<string> input, int start, int end)
        {
            if (start >= end)
                return;

            int pivot = start;
            string temp;

            for (int i = start; i <= end; i++)
            {
                if (string.Compare(input[i], input[end]) == -1)
                {
                    temp = input[i];
                    input[i] = input[pivot];
                    input[pivot] = temp;
                    pivot++;
                }
            }

            temp = input[pivot];
            input[pivot] = input[end];
            input[end] = temp;

            QuickSort(ref input, start, pivot - 1);
            QuickSort(ref input, pivot + 1, end);
        }
    }
}
