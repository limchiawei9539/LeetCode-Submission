using System;

namespace _123._Best_Time_to_Buy_and_Sell_Stock_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit(new int[8] { 3, 3, 5, 0, 0, 3, 1, 4 }));
        }

        public static int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1)
            {
                return 0;
            }
            var min = new int[prices.Length];
            var max = new int[prices.Length];
            var left = prices[0];
            var right = prices[prices.Length - 1];
            for (int i = 1; i < prices.Length; i++)
            {
                min[i] = Math.Max(min[i - 1], prices[i] - left);
                left = Math.Min(prices[i], left);
            }

            var total = min[prices.Length - 1];
            for (int i = prices.Length - 2; i >= 0; i--)
            {
                max[i] = Math.Max(max[i + 1], right - prices[i]);
                total = Math.Max(total, min[i] + max[i]);
                right = Math.Max(prices[i], right);
            }
            return total;
        }
    }
}
