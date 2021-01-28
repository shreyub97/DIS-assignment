using System;
using System.Collections.Generic;
using System.Linq;
namespace ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1 : Enter the number of rows for the traingle:");
            int n = Convert.ToInt32(Console.ReadLine());
            //int n = 5;
            printTriangle(n);
            Console.WriteLine("\n");
            //Question 2:
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            //int n2 = 14;
            printPellSeries(n2);
            Console.WriteLine("\n");
            //Question 3:
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            //int n3 = 5;
            bool flag = squareSums(n3);
            if (flag)
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
                Console.WriteLine();
            }
            //Question 4:
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            //int k = 2;
            int n4 = diffPairs(arr, k);
            Console.WriteLine("There exists {0} pairs with the given difference", n4);
            Console.WriteLine();
            //Question 5:
            List<string> emails = new List<string>();
            emails.Add("dis.email + bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is " + ans5);
            Console.WriteLine();
            //Quesiton 6:
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                       { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);
        }
        /// <summary>
        ///Print a pattern with n rows given n as input
        ///n - number of rows for the pattern, integer (int)
        ///This method prints a triangle pattern.
        ///For example n = 5 will display the output as:
        ///    *
        ///   ***
        ///  *****
        ///  *******
        /// *********
        ///returns     : N/A
        ///return type : void
        /// </summary>
        /// <param name="n"></param>
        private static void printTriangle(int n)
        {
            try
            {    // for loop to iterate through the number of rows
                for (int i = 1, k = 0; i <= n; ++i, k = 0)
                {
                    // Need to print spaces between the astericks in all the rows
                    for (int space = 1; space <= n - i; ++space)
                    {
                        Console.Write("  ");
                    }
                    // odd number of astericks are to be printed like 1,3,5,7,9 etc for the number of rows given by the user as input

                    while (k != 2 * i - 1)
                    {
                        Console.Write("* "); // prints "*" symbol
                        ++k;
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        ///<para>
        ///In mathematics, the Pell numbers are an infinite sequence of integers.
        ///The sequence of Pell numbers starts with 0 and 1, and then each Pell number is the sum of twice of the previous Pell number and
        ///the Pell number before that.:thus, 70 is the companion to 29, and 70 = 2 × 29 + 12 = 58 + 12. The first few terms of the sequence are :
        ///0, 1, 2, 5, 12, 29, 70, 169, 408, 985, 2378, 5741, 13860,...
        ///Write a method that prints first n numbers of the Pell series
        /// Returns : N/A
        /// Return type: void
        ///</para>
        /// </summary>
        /// <param name="n2"></param>
        private static void printPellSeries(int n2)
        {
            try
            {  // initialize an integer variable to 0, a second var to 1 and the next one to 0
                int first = 0;
                int second = 1;
                int next = 0;
                int i = 0;
                Console.Write(first + " "); // space between the numbers is essential to increase the readability
                Console.Write(second + " ");


                while (i < (n2 - 2)) // while loop loops throgh the list of items i for pell series logic
                { // pell series logic: next variable = twice the second + first 
                    next = (2 * second) + first;
                    first = second;
                    second = next;
                    Console.Write(second + " ");
                    i++; // increment i to obtain the pell series
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        ///Given a non-negative integer c, decide whether there're two integers a and b such that a^2 + b^2 = c.
        ///For example:
        ///Input: C = 5 will return the output: true (1*1 + 2*2 = 5)
        ///Input: A = 3 will return the output : false
        ///Input: A = 4 will return the output: true
        ///Input: A = 1 will return the output : true
        ///Note: You cannot use inbuilt Math Class functions.
        /// </summary>
        /// <param name="n3"></param>
        /// <returns>True or False</returns>
        private static bool squareSums(int n3)
        {
            try
            {   // square sum problem: looping through the items in a for a being less than equal to int n
                for (long a = 0; a * a <= n3; a++)
                { 
                    // looping through the items for b being less than equal to int n
                    for (long b = 0; b * b <= n3; b++)
                    { 
                        // logic: a*a + b*b assignment operator integer n
                        // which means 4 = 2^2 + 0^0 or 10 = 3^2 + 1^2
                        if (a * a + b * b == n3)
                            return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Given an array of integers and an integer n, you need to find the number of unique
        /// n-diff pairs in the array.Here a n-diff pair is defined as an integer pair (i, j),
        ///where i and j are both numbers in the array and their absolute difference is n.
        ///Example 1:
        ///Input: [3, 1, 4, 1, 5], k = 2
        ///Output: 2
        ///Explanation: There are two 2-diff pairs in the array, (1, 3) and(3, 5).
        ///Although we have two 1s in the input, we should only return the number of unique  
        ///pairs.
        ///Example 2:
        ///Input:[1, 2, 3, 4, 5], k = 1
        ///Output: 4
        ///Explanation: There are four 1-diff pairs in the array, (1, 2), (2, 3), (3, 4) and
        ///(4, 5).
        ///Example 3:
        ///Input: [1, 3, 1, 5, 4], k = 0
        ///Output: 1
        ///Explanation: There is one 0-diff pair in the array, (1, 1).
        ///Note : The pairs(i, j) and(j, i) count as same.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns>Number of pairs in the array with the given number as difference</returns>
        private static int diffPairs(int[] nums, int k)
        {
            try
            {   // initalize a count variable of tyle integer to 0
                int count = 0;
                nums = nums.Distinct().ToArray();
                // nums variable holds the number of Distincts and converts to Array type
                 // initlaize the foor loop to iterate through the list of items in the array through array.length
                for (int i = 0; i < nums.Length; i++)
                { 
                    // this for loop goes from i+1th element to all the elements in the array
                    for (int j = i + 1; j < nums.Length; j++)
                    { 
                        // Math.Abs function: after picking the elements one by one: 
                        // nums[i] - nums[j] == k || nums[j] - nums[i] == k
                        // determines the absolute difference between the values in the array
                        if (Math.Abs(nums[i] - nums[j]) == k)
                        {
                            count++; // count value is incremented 
                        }
                    }
                }
                return count;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }
        }
        /// <summary>
        /// An Email has two parts, local name and domain name.
        /// Eg: rocky @usf.edu - local name : rocky, domain name : usf.edu
        /// Besides lowercase letters, these emails may contain '.'s or '+'s.
        /// If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.
        /// For example, "..z@usf.com" and "..z@leetcode.com" forward to the same email address. (Note that this rule does not apply for domain names.)
        /// If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows certain emails to be filtered, for example ro.cky+bulls @usf.com will be forwarded to r..y@email.com. (Again, this rule does not apply for domain names.)
        /// It is possible to use both of these rules at the same time.
        /// Given a list of emails, we send one email to each address in the list.Return, how many different addresses actually receive mails?
        /// Eg:
        /// Input: [..l@usf.com","dis.e.mail+bob.cathy@u..d@us.f.com"]
        /// Output: 2
        /// Explanation: "..l@usf.com" and "..l@us.f.com" actually receive mails
        /// </summary>
        /// <param name="emails"></param>
        /// <returns>The number of unique emails in the given list</returns>
        private static int UniqueEmails(List<string> emails)
        {
            try
            {
                //declare an array of same size as that of emails
                //as number of unique emails can be atmost the total emails
                String[] unique = new String[emails.Count()];
                //declare index to keep track of number of unique mails in unique array
                int uniqueIndex = 0;
                //iterate over each email
                for (int i = 0; i < emails.Count(); i++)
                {
                    //get the email
                    String email = (String)emails.ElementAt(i);
                    //get the local part
                    String local = email.Substring(0, email.IndexOf('@'));
                    //get the domain part
                    String domain = email.Substring(email.IndexOf('@') + 1);
                    //replace all '.' in local by empty strings
                    local = local.Replace(".", "");
                    local = local.Replace(" ", "");
                    //if '+' exist in local, then consider only substring
                    //till it's position
                    if (local.IndexOf('+') != -1)
                        local = local.Substring(0, local.IndexOf('+'));
                    //now local and domain are according the desired formats
                    //email is now as:
                    email = local + "@" + domain;
                    //To see if this email is unique, we traverse the unique array
                    //and see if it already exists
                    //if it does, we donot add it to unique array.else we add it


                    //declare flag that will show be true if email already
                    //exists in unique array
                    bool flag = false;
                    //iterate over the unique array
                    for (int k = 0; k < uniqueIndex; k++)
                    {
                        //if email already exists
                        //make flag true and break
                        if (unique[k].Equals(email))
                        {
                            flag = true;
                            break;
                        }
                    }
                    //if flag is false, email is unique
                    //thus, add to unique array
                    //and increment uniqueIndex by 1
                    if (flag == false)
                        unique[uniqueIndex++] = email;
                }
                //return the number of items in unique array
                return uniqueIndex;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        /// <summary>
        /// You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.
        /// It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
        /// Example 1:
        /// Input: paths = [["London", "New York"], ["New York","Tampa"], ["Delhi","London"]]
        /// Output: "Tampa"
        /// Explanation: Starting at "Delhi" city you will reach "Tampa" city which is the destination city.Your trip consist of: "Delhi" -> "London" -> "New York" -> "Tampa".
        /// Input: paths = [["B","C"],["D","B"],["C","A"]]
        /// Output: "A"
        /// Explanation: All possible trips are:
        /// "D" -> "B" -> "C" -> "A".
        /// "B" -> "C" -> "A".
        /// "C" -> "A".
        /// "A".
        /// Clearly the destination city is "A".
        /// </summary>
        /// <param name="paths"></param>
        /// <returns>The destination city string</returns>
        private static string DestCity(string[,] paths)
        {
            try
            {
                // initialize a variable dict and this holds the data structure dictionary of string values
                var dict = new Dictionary<string, string>();

                // loop through all the items in the two-dimensional string array paths from the DestCity method parameter
                for (int i = 0; i < paths.GetLength(0); i++)
                {
                    dict.Add(paths[i, 0], paths[i, 1]);
                } // keeping adding all the cities in the paths until the condition: paths[i,0],paths[i,1] holds good 


                string finalDest = null; // initlaize a string finalDest to null value


                string destination = paths[0, 1]; // starting from one city, one must be able to reach op the destination city
                 // there exists a direct path from the initial city to the final city

                while (destination != null) // there is only one destination city and loop condition while
                    // destination not being equal to null
                {
                    if (dict.ContainsKey(destination)) // ContainsKey: if the dictionalry dict contains the key to the destination city
                    {
                        destination = dict[destination]; // graph now forms a line without any loop 
                    } // destination is obtained from the dictionary
                    else
                    {
                        finalDest = destination; // finalDest is now equal to destination
                        destination = null; // swalp destination value to null again 
                    }
                }


                return finalDest; // return the final destination city
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
