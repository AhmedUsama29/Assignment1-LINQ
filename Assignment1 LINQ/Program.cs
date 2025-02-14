using static Assignment1_LINQ.ListGenerator;

namespace Assignment1_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            #region Q1 : Find all products that are out of stock.

            //var res = ProductList.Where(p => p.UnitsInStock == 0);

            #endregion

            #region Q2 : Find all products that are in stock and cost more than 3.00 per unit.

            //var res = from n in ProductList
            //          where n.UnitsInStock > 0 && n.UnitPrice > 3.00m
            //          select n;

            #endregion

            #region Q3 : Returns digits whose name is shorter than their value

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var res = Arr.Where((n, i) => n.Length < i);

            #endregion

            #endregion

            #region Transformation Operators

            #region Q1 : Return a sequence of just the names of a list of products.

            //var res = ProductList.Select(p => p.ProductName);

            #endregion

            #region Q2 : Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var res = from n in words
            //          select new { UpperCase = n.ToUpper(), LowerCase = n.ToLower() };

            #endregion

            #region Q3 : 



            #endregion

            #endregion

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
}
