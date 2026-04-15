using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinQApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1) Get all products from the "Seafood" category.Print each product's name and price.

            //var result = ProductList.Where(p => p.Category == "Seafood");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName + " - " + item.UnitPrice);
            //} 
            #endregion

            #region Question02
            //2) Get a list of only the product names from ProductList.Print each name.

            //var result = ProductList.Select(p => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question03
            //3) Sort all products by UnitPrice(ascending).Print each product's name and price.

            //var result = ProductList.OrderBy(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName + " - " + item.UnitPrice);
            //} 
            #endregion


            #region Question04
            //4) Get all products where UnitPrice is between 10 and 30.

            //var result = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName + " - " + item.UnitPrice);
            //} 
            #endregion

            #region Question05
            //5) Get all products that are in stock(UnitsInStock > 0) and belong to the "Condiments" category.

            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName + " - " + item.UnitsInStock);
            //} 
            #endregion

            #region Question06
            //6) Create a new anonymous type with Name, Price, and StockStatus. Print the result.

            //    var result = ProductList.Select(p => new
            //    {
            //        Name = p.ProductName,
            //        Price = p.UnitPrice,
            //        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name + " - " + item.Price + " - " + item.StockStatus);
            //} 
            #endregion

            #region Question07
            //7) Print each product's name along with its position (1-based) in the list.

            //var result = ProductList.Select((p, index) => new
            //{
            // Index = index + 1,
            // Name = p.ProductName
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Index + ". " + item.Name);
            //}

            #endregion

            #region Question08
            //8) Sort ProductList by Category ascending, then within each category sort by UnitPrice descending.

            //var result = ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Category + " - " + item.ProductName + " - " + item.UnitPrice);
            //} 
            #endregion

            #region Question09 
            //9) Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

            //var result = ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName + " - " + item.UnitsInStock);
            //} 
            #endregion

            #region Question10
            //10) Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.

            //var result = from c in CustomerList
            // from o in c.Orders
            // where o.OrderDate.Year >= 1997
            // select new
            // {
            //     c.CustomerID,
            //     o.OrderDate
            // };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CustomerID + " - " + item.OrderDate);
            //} 
            #endregion

            #region Question11
            //11) Show position number alongside ProductName.

            //var result = ProductList.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    ProductName = p.ProductName
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Position + ". " + item.ProductName);
            //} 
            #endregion

            #region Question12
            //12) Sort first by word length and then by a case -insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(w => w.Length)
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Question13
            //13) Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = digits
            //    .Where(d => d[1] == 'i')
            //    .Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
