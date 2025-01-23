using System.Diagnostics;

namespace Merge_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Začínám třídit...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortString("test_words.txt");
            stopwatch.Stop();
            Console.WriteLine($"Třídil jsem {stopwatch.ElapsedMilliseconds} milisekund.");

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

            values = MergeSort(values);

            using (StreamWriter sw = new StreamWriter("Outputs\\" + file))
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    sw.WriteLine(values[i]);
                }
            }
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

            values = MergeSort(values);

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

            values = MergeSort(values);

            using (StreamWriter sw = new StreamWriter("Outputs\\" + file))
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    sw.WriteLine(values[i]);
                }
            }
        }
        public static List<uint> MergeSort(List<uint> values)
        {
            if (values.Count <= 1)
                return values;

            int middle = values.Count / 2;
            List<uint> left = MergeSort(values.Slice(0, middle).ToList());
            List<uint> right = MergeSort(values.Slice(middle, values.Count - middle).ToList());
            int iLeft = 0;
            int iRight = 0;
            List<uint> tempValues = new();
            do
            {
                if(right.Count == iRight)
                {
                    tempValues.Add(left[iLeft]);
                    iLeft++;
                    continue;
                }
                if(left.Count == iLeft)
                {
                    tempValues.Add(right[iRight]);
                    iRight++;
                    continue;
                }

                if (left[iLeft] <= right[iRight])
                {
                    tempValues.Add(left[iLeft]);
                    iLeft++;
                }
                else
                {
                    tempValues.Add(right[iRight]);
                    iRight++;
                }
            } while ((left.Count >= iLeft + 1) || (right.Count >= iRight + 1));
            return tempValues;
        }
        public static List<int> MergeSort(List<int> values)
        {
            if (values.Count <= 1)
                return values;

            int middle = values.Count / 2;
            List<int> left = MergeSort(values.Slice(0, middle).ToList());
            List<int> right = MergeSort(values.Slice(middle, values.Count - middle).ToList());
            int iLeft = 0;
            int iRight = 0;
            List<int> tempValues = new();
            do
            {
                if (right.Count == iRight)
                {
                    tempValues.Add(left[iLeft]);
                    iLeft++;
                    continue;
                }
                if (left.Count == iLeft)
                {
                    tempValues.Add(right[iRight]);
                    iRight++;
                    continue;
                }

                if (left[iLeft] <= right[iRight])
                {
                    tempValues.Add(left[iLeft]);
                    iLeft++;
                }
                else
                {
                    tempValues.Add(right[iRight]);
                    iRight++;
                }
            } while ((left.Count >= iLeft + 1) || (right.Count >= iRight + 1));
            return tempValues;
        }
        public static List<string> MergeSort(List<string> values)
        {
            if (values.Count <= 1)
                return values;

            int middle = values.Count / 2;
            List<string> left = MergeSort(values.Slice(0, middle).ToList());
            List<string> right = MergeSort(values.Slice(middle, values.Count - middle).ToList());
            int iLeft = 0;
            int iRight = 0;
            List<string> tempValues = new();
            do
            {
                if (right.Count == iRight)
                {
                    tempValues.Add(left[iLeft]);
                    iLeft++;
                    continue;
                }
                if (left.Count == iLeft)
                {
                    tempValues.Add(right[iRight]);
                    iRight++;
                    continue;
                }

                if (string.Compare(left[iLeft], right[iRight]) <= 0)
                {
                    tempValues.Add(left[iLeft]);
                    iLeft++;
                }
                else
                {
                    tempValues.Add(right[iRight]);
                    iRight++;
                }
            } while ((left.Count >= iLeft + 1) || (right.Count >= iRight + 1));
            return tempValues;
        }
    }
}
