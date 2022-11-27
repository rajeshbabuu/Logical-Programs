using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponNumber
{
    internal class CouponN
    {
        public void generateNDistinctCouponNum(int n)
        {
            Console.WriteLine("\n");
            //array to store the distinct coupon number
            int[] CouponNumber = new int[n];
            int index = 0;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                //generate a random number
                int randomNumber = random.Next();

                //for the first element
                if (index == 0)
                {
                    //add the first random number in the array
                    CouponNumber[index] = randomNumber;
                    index++;

                }
                //for the other element
                else
                {
                    //using the for loop check whether the random number is distinct or not
                    for (int j = 0; j < index; j++)
                    {
                        while (randomNumber == CouponNumber[j])
                        {
                            randomNumber = random.Next();
                        }
                    }
                    //add the random number to the array
                    CouponNumber[index] = randomNumber;
                    index++;
                }
            }
            //display the distinct random number
            Console.WriteLine(n + " Distinct Coupon Numbers are:");
            for (int i = 0; i < CouponNumber.Length; i++)
            {
                Console.WriteLine(CouponNumber[i]);
            }
        }
    }
}
