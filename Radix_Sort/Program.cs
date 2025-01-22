using System.Diagnostics;

namespace Radix_Sort
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

            values = RadixSort(values);

            using (StreamWriter sw = new StreamWriter("Outputs\\" + file))
            {
                for (int i = 0; i < values.Count - 1; i++)
                {
                    sw.WriteLine(values[i]);
                }
            }
        }

        public static List<uint> RadixSort(List<uint> values, int digit = -1)
        {
            if (digit == -1)
            {
                digit = values.Max().ToString().Length - 1;
            }
            List<uint>[] digitArray = new List<uint>[10];
            for (int i = 0; i < 10; i++) { digitArray[i] = new List<uint>(); }
            byte maxDigit = (byte)(values.Max().ToString().Length - 1);

            foreach (uint value in values)
            {
                digitArray[GetDigit(value, digit, maxDigit)].Add(value);
            }
            values.Clear();
            foreach (List<uint> list in digitArray)
            {
                foreach (uint value in list)
                {
                    values.Add(value);
                }
            }

            if (digit > 0)
                RadixSort(values, digit - 1);
            return values;
        }

        public static uint GetDigit(uint source, int digitIndex, byte maxDigit)
        {
            return uint.Parse(source.ToString($"D{maxDigit + 1}")[digitIndex].ToString());
        }
    }
}
