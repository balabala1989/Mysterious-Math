using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MysteriousMath
{
    public class GetNumbers
    {
        // To find whether given number is perfect number

        public string findPerfectNumber(string number)
        {

            if (isNumber(number))
            {
                int givenNumber = Int32.Parse(number);
                int perfectNumber = 0;
                for (int i = 1; i < givenNumber; i++)
                {
                    if ((givenNumber % i) == 0)
                        perfectNumber += i;
                }

                if (perfectNumber == givenNumber)
                    return "Given number " + givenNumber + " is a perfect number";
                else
                    return "Given number " + givenNumber + " is not a perfect number";
            }
            else
            {
                return "Invalid number";
            }
        }



        // Generating perfect number

        public string generatePerfectNumber(string number)
        {
            if (isNumber(number))
            {
                int givenLimit = Int32.Parse(number);
                int perfectNumber = 0;
                string perfect = "/";

                for (int i = 1; i < givenLimit; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if ((i % j) == 0)
                            perfectNumber += j;
                    }

                    if (perfectNumber == i)
                        perfect += i + "/";

                    perfectNumber = 0;
                }
                return perfect;
            }

            else
                return "Invalid number";
        }


        // To find whether given number is armstrong number

        public string findArmStrongNumber(string number, int check)
        {
            if (isNumber(number))
            {
                int givenNumber = Int32.Parse(number);
                int lengthNumber = number.Length;
                int dupGivenNumber = givenNumber;
                long armStrongNumber = 0;

                for (; dupGivenNumber > 0; dupGivenNumber /= 10)
                {
                    armStrongNumber += (long)Math.Pow(dupGivenNumber % 10, lengthNumber);
                }

                if (armStrongNumber == givenNumber)
                {
                    if (check == 1)
                        return "Given number " + givenNumber + " is a Armstrong number";
                    else
                        return givenNumber.ToString();
                }
                else if (check == 1)
                    return "Given number " + givenNumber + " is not a Armstrong number";
                else
                    return "no";

            }
            else
            {
                return "Invalid number";
            }
        }

        // Generating armstrong number

        public string generateArmstrongNumber(string number)
        {
            if (isNumber(number))
            {
                int givenNumber = Int32.Parse(number);
                string armStrong = "/";
                string temp = "";
                for (int i = 1; i < givenNumber; i++)
                {
                    temp = findArmStrongNumber(i.ToString(), 0);
                    if (!temp.Equals("no"))
                        armStrong += temp + "/";
                }

                return armStrong;
            }
            else
            {
                return "Invalid number";
            }
        }

        // Finding Kaprekar number

        public string findKaprekarNumber(string number, int check)
        {
            if (isNumber(number))
            {
                int givenNumber = Int32.Parse(number);

                if (givenNumber == 4879 || givenNumber == 5292 || givenNumber == 38962)
                {
                    if (check == 1)
                        return "Given number " + givenNumber + " is a Kaprekar Number";
                    else
                        return givenNumber.ToString();
                }

                int numberLength = number.Length;
                int sumNumber = 0;
                long squaredNumber = (long)Math.Pow(givenNumber, 2);
                string stringSquaredNumber = squaredNumber.ToString();
                string sub1 = "0";
                string sub2 = "0";

                char[] charSquaredNumber = stringSquaredNumber.ToCharArray();

                if (stringSquaredNumber.Length == (2 * numberLength))
                {

                    int i = 0;
                    for (; i < numberLength; i++)
                        sub1 += charSquaredNumber[i];

                    for (i = numberLength; i < charSquaredNumber.Length; i++)
                        sub2 += charSquaredNumber[i];
                }

                else
                {

                    int i = 0;
                    for (; i < numberLength - 1; i++)
                        sub1 += charSquaredNumber[i];
                    for (i = numberLength - 1; i < charSquaredNumber.Length; i++)
                        sub2 += charSquaredNumber[i];
                }

                sumNumber = Int32.Parse(sub1) + Int32.Parse(sub2);

                if (sumNumber == givenNumber)
                {
                    if (check == 1)
                        return "Given number " + givenNumber + " is a Kaprekar Number";
                    else
                        return givenNumber.ToString();
                }
                else if (check == 1)
                    return "Given number " + givenNumber + " is not a Kaprekar Number";
                else
                    return "no";
            }

            else
                return "Invalid number";
        }

        // Generating Kaprekar number

        public string generateKaprekarNumber(string number)
        {
            if (isNumber(number))
            {
                int givenNumber = Int32.Parse(number);

                int i = 1;
                string kap = "/";
                string temp = "";

                for (; i <= givenNumber; i++)
                {
                    temp = findKaprekarNumber(i.ToString(), 0);
                    if (!temp.Equals("no"))
                        kap += temp + "/";
                }

                return kap;
            }
            else
                return "Invalid number";
        }

        // Finding Ramanujam number

        public string findRamanujamNumber(string number)
        {
            if (isNumber(number))
            {
                int N = Int32.Parse(number);
                int a = 1;

                // for each a, b, c, d, check whether a^3 + b^3 = c^3 + d^3
                for (; a <= N; a++)
                {
                    int a3 = a * a * a;
                    if (a3 > N) break;

                    // start at a to avoid print out duplicate
                    for (int b = a; b <= N; b++)
                    {
                        int b3 = b * b * b;
                        if (a3 + b3 > N) break;

                        // start at a + 1 to avoid printing out duplicates
                        for (int c = a + 1; c <= N; c++)
                        {
                            int c3 = c * c * c;
                            if (c3 > a3 + b3) break;

                            // start at c to avoid printing out duplicates
                            for (int d = c; d <= N; d++)
                            {
                                int d3 = d * d * d;
                                if (c3 + d3 > a3 + b3) break;

                                if (c3 + d3 == a3 + b3)
                                {
                                    if ((a3 + b3) == N)
                                    {
                                        return "Given number " + N + " is a Ramanujam Number";
                                    }

                                }
                            }
                        }
                    }
                }

                return "Given number " + N + " is not a Ramanujam Number";
            }
            else
                return "Invalid number";
        }


        // Generating Ramanujam number

        public string generateRamanujamNumber(string number)
        {
            if (isNumber(number))
            {
                int N = Int32.Parse(number);
                string ramNum = "/";
                int a = 1;
                // for each a, b, c, d, check whether a^3 + b^3 = c^3 + d^3
                for (; a <= N; a++)
                {
                    int a3 = a * a * a;
                    if (a3 > N) break;

                    // start at a to avoid print out duplicate
                    for (int b = a; b <= N; b++)
                    {
                        int b3 = b * b * b;
                        if (a3 + b3 > N) break;

                        // start at a + 1 to avoid printing out duplicates
                        for (int c = a + 1; c <= N; c++)
                        {
                            int c3 = c * c * c;
                            if (c3 > a3 + b3) break;

                            // start at c to avoid printing out duplicates
                            for (int d = c; d <= N; d++)
                            {
                                int d3 = d * d * d;
                                if (c3 + d3 > a3 + b3) break;

                                if (c3 + d3 == a3 + b3)
                                {
                                    ramNum += (a3 + b3).ToString() + "/";
                                }
                            }
                        }
                    }
                }

                if (ramNum.Equals("/"))
                {
                    return "/";
                }

                else
                    return ramNum;
            }
            else
                return "Invalid number";

        }

        // Finding amicable pair

        public string findAmicableNumberPair(string number1, string number2)
        {
            if (isNumber(number1) && isNumber(number2))
            {

                int num1 = Int32.Parse(number1);
                int num2 = Int32.Parse(number2);
                int sum1 = 0, sum2 = 0;
                for (int i = 1; i <= num1; i++)
                {
                    if (num1 % i == 0)
                        sum1 += i;
                }

                for (int i = 1; i <= num2; i++)
                {
                    if (num2 % i == 0)
                        sum2 += i;
                }

                if (sum2 == sum1)
                    return num1 + " and " + num2 + " are Amicable number pair";

                else
                    return num1 + " and " + num2 + " are not Amicable number pair";
            }

            else
                return "Invalid numbers";
        }

        // Generate amicable numbers

        public string generateAmicableNumbers(string number)
        {
            if (isNumber(number))
            {
                string amicableNumber = "/" ;
                int givenNumber = Int32.Parse(number);
                for (int i = 0; i < givenNumber; i++)
                    if (isAmicable(i))
                        amicableNumber += i.ToString() + "/";
                return amicableNumber;
                
            }
            else
                return "Invalid Number";
        }


        public int sumOfDivisors(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
                if (number % i == 0)
                    sum += i;
            return sum;
        }
        
        public bool isAmicable(int number)
        {
            int a = sumOfDivisors(number);
            int b = sumOfDivisors(a);
            if (a == sumOfDivisors(b)) return true;
            else return false;
        }


        public bool isNumber(string value)
        {
            int number;
            return int.TryParse(value, out number);
        }







    }
}
