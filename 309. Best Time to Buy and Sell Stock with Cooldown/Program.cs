using System;

namespace _309._Best_Time_to_Buy_and_Sell_Stock_with_Cooldown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit(new int[5] { 1, 2, 3, 0, 2 }));
            Console.WriteLine(MaxProfit(new int[3] { 1, 3, 4 }));
        }

        public static int MaxProfit(int[] prices)
        {
            int rest = 0; //do nothing
            int hold = rest - prices[0]; //buy today
            int sold = hold + prices[0]; // sell today

            for (int i = 1; i < prices.Length; i++)
            {
                int B4Sold = sold; //yesterday sold
                sold = hold + prices[i]; // sell today
                hold = Math.Max(hold, rest - prices[i]); //holding or buy today
                rest = Math.Max(rest, B4Sold); //resting or sell yesterday 
            }
            return Math.Max(sold,rest);
        }
    }
}
