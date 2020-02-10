using System;

namespace Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 5;
            //PrintPattern(5);

            //int n2 = 6;            
            //PrintSeries(n2);

            //string s = "09:15:35PM";
            //string t = UsfTime(s);
            //Console.WriteLine(t);


            //int n3 = 110;
            //int k = 11;
            // UsfNumbers(n3, k);

            //string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            //PalindromePairs(words);



            //Stones(5);



        }

        public static void PrintPattern(int n)
        {
            try
            {
                int x = n; // Here we are taking a variable x for further implimentations.
                if (x >= 1)
                {
                    for (x = n; x > 0; x--)
                    {
                        Console.Write(x + ""); // This code will print x as many times as we want as long as it.. 
                                               // It satisfies the x>0 condition. After that it will go to the next line
                    }

                    Console.WriteLine(); // This line of code will go to the next line for printing our o/p. 
                    PrintPattern(n - 1); // The function here will call everytime with a decrement of 1 until it cant satisfy the loop condition anymore.
                }
            }


            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }

        public static void PrintSeries(int n2)
        {
            try
            {
                // In this question, I have taken a arithmatic approach of sum of n numbers.
                // I have taken a= initial value, d= difference and Sn= sum of n numbers.
                int a = 1;
                int d = 1;
                int Sn = 0;
                if (n2 == 1) // If our number is 1 it will print 1.
                {
                    Console.WriteLine(a);
                }
                if (n2 > 0)
                {
                    for (int x = 0; x <= n2; x++)
                    {
                        Sn = Sn + a; // This equation will add the sum of numbers in the series with every increment.
                        Console.Write(Sn + ", ");
                        a = a + d; // Every iteration will see in an increase in a by 1.
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                // Here I have used various if else statements to check if the number satisfy th requirements mentioned.
                int i, j = 1;

                for (i = 1; i <= n3; i++)
                {
                    if (i % 3 == 0 & i % 5 == 0)
                    {
                        Console.Write("US ");
                    }
                    else if (i % 5 == 0 & i % 7 == 0)
                    {
                        Console.Write("SF ");

                    }
                    else if (i % 3 == 0 & i % 7 == 0)
                    {
                        Console.Write("UF ");

                    }

                    else if (i % 3 == 0)
                    {
                        Console.Write("U ");

                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("S ");
                    }
                    else if (i % 7 == 0)
                    {
                        Console.Write("F ");
                    }

                    else if (i % 3 != 0 & i % 5 != 0 & i % 7 != 0)
                    {
                        Console.Write(i + " ");

                    }


                    j++; // Here j variable is iterated every time.
                    if (j > k) // If j variable is more than 11, this condition will push our o/p to the next line
                    {
                        Console.WriteLine();
                        j = 1; // As j has a stored value of 11, this will initialize it back to 1.
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }

        }
        public static void Stones(int n4)
        {
            try
            {
                //case[0]= 0, no player picks up a stone
                //case[1]= 1, player 1 wins.
                //case[2]= 1, player 1 wins.
                //case[3]=1, player 1 wins.
                //case[4]=0, player 2 wins.
                //case[5]=1, player 1 wins.
                //case[6]=1, player 1 wins.
                //case[7]=1, player 1 wins.
                //case[8]=0, player 2 wins.
                // We see a trend here. For every multiple of 4, player one loses no matter what.


                if (n4 % 4 == 0)
                    Console.Write("you lose. p2 wins");// We, therefore, use an if statement to determine who wins.
                                                       // We divide the number of stones by 4.

                else
                {
                    Console.Write("p1 wins");
                    Console.WriteLine("");


                    int size = 100; // Over here we have just taken a sample size of an array with max elements 100.
                    int[] bag = new int[size];


                    combinations(bag, n4, 0);

                }

                static void combinations(int[] bag, int n, int i) // This method here will help us in getting all the different possibilities...
                                                                  // or combinations we can have with 1,2,3 as both players play.
                {
                    int limit = 3; // This defines the max number of attempts we want by picking 1,2 or 3 stones.
                    if (n == 0)
                    {
                        printArray(bag, i);
                    }
                    else if (n > 0)
                    {
                        for (int k = 1; k <= limit; k++)
                        {
                            bag[i] = k;
                            combinations(bag, n - k, i + 1);
                        }
                    }
                }

                //  function to print array bag[] 
                static void printArray(int[] bag, int m)
                {
                    for (int i = 0; i < m; i++)
                        Console.Write(bag[i] + " ");
                    Console.WriteLine();
                    // Here we print all the possibilities of choosing 1s 2s and 3s for the given number of stones. 

                }
            }


            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }
        public static void PalindromePairs(string[] words)
        {
            try
            {
                // We will be taking 2 variables and will compare various elements of the array.                  
                for (int i = 0; i < words.Length - 1; i++)
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        String new_string = string.Empty; // We take a new empty string. 

                        //  We store the concatenated values of elements in words array.
                        new_string = new_string + words[i] + words[j];

                        new_string = words[j] + words[i];// We check here if the concatenated string is palindrome

                        if (checkPalindrome(new_string))
                        {
                            Console.WriteLine(new_string);
                            Console.WriteLine(i + " " + j);
                        }
                    }
                }

                static bool checkPalindrome(String str)
                {
                    int len = str.Length;

                    // Comparing the starting character with last and printing the position of each palindromic combination. 

                    for (int i = 0; i < len / 2; i++)
                        if (str[i] != str[len - i - 1])
                            return false;


                    return true;

                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }
        public static string UsfTime(string s)
        {

            //We are going to split the input string here with the seperator being :
            String[] str_list = s.Split(":");
            int TSeconds = 0;
            string USF_str = "";
            //After splitting the time input, we will assign the hours, minutes and seconds accordingly.
            int h = int.Parse(str_list[0]);
            int m = int.Parse(str_list[1]);
            // As the time input has seconds and AM or PM together. We need to split them up.
            // We can do that by using substring and taking only the first 2 or last 2 elements.
            String last = str_list[str_list.Length - 1];
            int seconds = int.Parse(str_list[2].Substring(0, 2));
            // The if statement below checks if the input has pm in it. If it does, then we have to add an addintiones 12hours of seconds to the total.
            if (str_list[2].Substring(2) == "PM" && h != 0)
                TSeconds = (h * 60 * 60 + (12 * 60 * 60)) + (m * 60) + seconds;

            if (h == 12)
                TSeconds = (12 * 60 * 60) + (m * 60) + seconds;


            if (str_list[2].Substring(2) == "AM" && h != 0)
                TSeconds = (h * 60 * 60) + (m * 60) + seconds;
            
            // Here we are converting the total number of seconds to time onf USF planet.
            double u = (double)TSeconds / 2700;
            double s1 = u - (int)u;
            double s2 = s1 * 60;
            double f = s2 - (int)s2;
            double f1 = f * 45;
            USF_str = (int)u + ":" + (int)s2 + ":" + (int)f1;

            return USF_str;


        }
    }
}

       
    




   










