using System.ComponentModel;

namespace AssignmentFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            #region Question 01

            //double[] prices = { 25.5, 40.0, 33.75 };
            //Console.WriteLine($"index: 1, value: {prices[1]}");

            #endregion

            #region Question 02

            //int[,] shlefCopies = new int[2, 2]
            //{
            //    {3,5 },
            //    {1,4 }
            //};
            //Console.WriteLine(shlefCopies.GetLength(0));
            //Console.WriteLine(shlefCopies[1,0]); // result 1

            #endregion

            #region Question 03

            //PrintWelcomeMessage();

            #endregion

            #region Question 04

            //PrintBookTitle("Clean Code");

            #endregion

            #region Question 05

            //int pages = 400;
            //Console.WriteLine($"Before adding bouns pages: {pages}");
            //AddBounsPages(pages);
            //Console.WriteLine($"After adding bouns pages: {pages}");

            //Why? Because int is a value type, so the method receives a copy of pages.
            //The change inside the method does not affect the original variable in Main.

            #endregion

            #region Question 06

            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"Before applying discount: {prices[0]}");
            //ApplyDiscount(prices);
            //Console.WriteLine($"After applying discount: {prices[0]}");

            #endregion

            #region Question 07

            //int pages = 400;
            //Console.WriteLine($"Before adding bouns pages: {pages}");
            //AddBounsPages(ref pages );
            //Console.WriteLine($"After adding bouns pages: {pages}");

            #endregion

            #region Question 08

            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine($"Prices Length: {prices.Length}");

            #endregion

            #region Question 09

            //bool result = TryGetPrice("Clean Code", out double price);
            //Console.WriteLine(result);
            //Console.WriteLine(price);

            #endregion

        }


        #region Question 03

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        #endregion

        #region Question 04
        public static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book Title: " +  title);
        }

        #endregion

        #region Question 05

        public static void AddBounsPages(int pages)
        {
            pages += 50;
        }

        #endregion

        #region Question 06
        public static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion

        #region Question 07

        public static void AddBounsPages(ref  int pages)
        {
            pages += 50;
        }

        #endregion

        #region Question 08

        public static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }

        #endregion

        #region Question 09

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            price = 0;
            return false;
        }

        #endregion

    }
}