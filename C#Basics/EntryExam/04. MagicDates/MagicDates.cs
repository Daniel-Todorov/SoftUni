using System;
using System.Threading;

class MagicDates
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        DateTime startYear = DateTime.Parse("01-01." + Console.ReadLine());
        DateTime endYear = DateTime.Parse("12.31." + Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        bool noSuchYear = true;
        char[] set = new char[8];
        int[] test = new int[8];
        for (DateTime i = startYear; i <= endYear; i = i.AddDays(1))
        {
            set = i.ToString("ddMMyyyy").ToCharArray();
            for (int j = 0; j < 8; j++)
            {
                test[j] = int.Parse(set[j].ToString());
            }

            if (CalculateSumOfProducts(test, magicWeight))
            {
                noSuchYear = false;
                Console.WriteLine(i.ToString("dd-MM-yyyy"));
            }
        }

        if (noSuchYear)
        {
            Console.WriteLine("No");
        }
    }

    public static bool CalculateSumOfProducts(int[] numberAsString, int weight)
    {
        int sum = 0;

        for (int i = 0; i < numberAsString.Length; i++)
        {
            for (int j = i + 1; j < numberAsString.Length; j++)
            {
                sum += numberAsString[i] * numberAsString[j];
                if (sum > weight)
                {
                    return false;
                }
            }
        }
        if (sum < weight)
        {
            return false;
        }
        return true;
    }
}
