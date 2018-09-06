using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codejam
{
    public class SantaDaDhaba
    {
        public int MaxDays(string[] prices, int budget)
        {
            int currentCashSpent = 0;
            int countOfDaysWentToDhaba = 0;
            int countOfDaysWentToDhaba1 = 0;
            int size = prices[0].Length;


            int[] positionOfMinCostDish = new int[7];

            for (int i = 0; i < 7; i++)
            {
                int[] costsOfDish = new int[size];
                for (int j = 0; j < size; j++)
                {
                    costsOfDish[j] = GetValue(prices[i][j]);
                }
                int cashToBeSpent = costsOfDish.Min();
                int minCostItemPosition = Array.IndexOf(costsOfDish, cashToBeSpent);
                positionOfMinCostDish[i] = minCostItemPosition;

                if (currentCashSpent + cashToBeSpent <= budget)
                {
                    currentCashSpent += cashToBeSpent;
                    countOfDaysWentToDhaba1++;

                }
                else
                {
                    return countOfDaysWentToDhaba1;

                }
            }

            int countOfWeekDays1 = 0;
            for (int x = 7; x < prices.Length; x++)
            {
                if (countOfWeekDays1 < 7)
                {
                    int position = positionOfMinCostDish[countOfWeekDays1];

                    int cashToBeSpent = GetValue(prices[x][position]);
                    if (cashToBeSpent + currentCashSpent <= budget)
                    {
                        currentCashSpent += cashToBeSpent;
                        countOfDaysWentToDhaba1++;

                    }
                    else
                    {
                        break;

                    }
                    countOfWeekDays1++;
                }
                else
                {
                    countOfWeekDays1 = 0;
                    x--;
                }
            }



            int[] minDishPositionOfDayPerWeek = new int[7];
            if (currentCashSpent < budget)
            {
                currentCashSpent = 0; countOfDaysWentToDhaba = 0;// for future use when counting again// and no relation here
                for (int i = 1; i <= 7; i++)
                {
                    int j = i;
                    int minCostItemPosition = 0;
                    while (j <= prices.Length)
                    {
                        int[] costsOfDish = new int[size];
                        for (int x = 0; x < size; x++)
                        {
                            costsOfDish[x] += GetValue(prices[j - 1][x]);
                        }
                        int minVal = costsOfDish.Min();
                        minCostItemPosition = Array.IndexOf(costsOfDish, minVal);

                        j += 7;
                    }
                    minDishPositionOfDayPerWeek[i - 1] = minCostItemPosition;
                }
            }

            int countOfWeekDays = 0;
            for (int x = 0; x < prices.Length; x++)
            {
                if (countOfWeekDays < 7)
                {
                    int position = minDishPositionOfDayPerWeek[countOfWeekDays];

                    int cashToBeSpent = GetValue(prices[x][position]);
                    if (cashToBeSpent + currentCashSpent <= budget)
                    {
                        currentCashSpent += cashToBeSpent;
                        countOfDaysWentToDhaba++;

                    }
                    else
                    {
                        break;

                    }
                    countOfWeekDays++;
                }
                else
                {
                    countOfWeekDays = 0;
                    x--;
                }
            }

            return Math.Max(countOfDaysWentToDhaba, countOfDaysWentToDhaba1);
        }
        int GetValue(char x)
        {
            int answer = 0;
            if (char.IsDigit(x))
            {
                return (x - 48);
            }
            else if (char.IsUpper(x))
            {
                return (x - 55);
            }
            else if (char.IsLower(x))
            {
                return (x - 61);
            }
            return answer;
        }

        //some other functions
        //int GetDishWithMinCost(string prices, int length)
        //{

        //    int answer = 0;
        //    int[] values = new int[length];
        //    for (int index = 0; index <= length; index++)
        //    {
        //        values[index] = GetValue(prices[index]);
        //    }
        //    answer = values.Min();

        //    int itemType = Array.IndexOf(values, answer);

        //    return itemType;
        //}
        //
        //int GetCostOfDishWithMinCost(string prices, int length)
        //{

        //    int answer = 0;
        //    int[] values = new int[length];
        //    for (int index = 0; index <= length; index++)
        //    {
        //        values[index] = GetValue(prices[index]);
        //    }
        //    answer = values.Min();
        //    return answer;
        //}

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            SantaDaDhaba dhaba = new SantaDaDhaba();

            do
            {
                var inputParts = input.Split('|');
                string[] prices = inputParts[0].Split(',');
                Console.WriteLine(dhaba.MaxDays(prices, Int32.Parse(inputParts[1])));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}