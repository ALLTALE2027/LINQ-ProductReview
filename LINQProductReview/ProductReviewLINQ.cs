using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LINQProductReview
{
    internal class ProductReviewLINQ
    {
        public static void AddProductReview(List<ProductReview> products)
        {
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Good", rating = 4, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 4, review = "Good", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 8, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 7, userId = 10, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 5, review = "Very Good", rating = 4, isLike = true });
            products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 9, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 11, review = "Good", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 12, userId = 3, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 14, userId = 15, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 18, userId = 9, review = "Bad", rating = 0, isLike = false });
            products.Add(new ProductReview() { productId = 13, userId = 1, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 19, userId = 8, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 2, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });
            Console.WriteLine("Product reviews added\n");          
           
        }
        public static void IterateThroughList(List<ProductReview> products)
        {
            foreach (ProductReview product in products)
            {
                Console.WriteLine("ProductId:{0}\t UserId:{1}\t Review:{2}\tRating:{3}\tIsLike:{4}\t", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }

        public static void RetrieveTopThreeRating(List<ProductReview> products)
        {
            AddProductReview(products);
            Console.WriteLine("\n-------------Retrieving Top Three Records Based On Rating--------------");
            var res = (from product in products orderby product.rating descending select product).Take(3).ToList();
            IterateThroughList(res);
           
        }

        public static void RetrieveRecordsBasedOnRatingAndProductId(List<ProductReview> products)
        {
            AddProductReview(products);
            Console.WriteLine("\n-----------Retrieve Records Based On Rating and Product Id's-----------");
            var res = (from product in products where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9) select product).ToList();
            IterateThroughList(res);
        }

        public static void CountingRecordsByProductId(List<ProductReview> products)
        {
            string res = null;
            AddProductReview(products);
            var data = products.GroupBy(x => x.productId).Select(a => new { ProductId = a.Key, count = a.Count()});
            foreach (var e in data)
            {
                Console.WriteLine("ProductId: " + e.ProductId +  "  Count: " +  e.count);
            }
        }
        public static void RetrieveOnlyProductIdAndReviews(List<ProductReview> products)
        {
            string result = null;
            AddProductReview(products);
            var res = products.Select(product => new { ProductId = product.productId, Review = product.review }).ToList();
            foreach (var e in res)
            {
                Console.WriteLine("ProductId " + e.ProductId + " " + "Review " + " " + e.Review);
            }
        }

        public static void SkipTopFiveRecords(List<ProductReview> products)
        {
            AddProductReview(products);
            Console.WriteLine("\n----------Skip Top Five records in list-----------");
            var res = (from product in products orderby product.rating descending select product).Skip(5).ToList();
            IterateThroughList(res);
        }

        // Data Table

        public static DataTable CreateDataTable(List<ProductReview> products)
        {
            AddProductReview(products);
            DataTable dt = new DataTable();
            dt.Columns.Add("productId");
            dt.Columns.Add("userId");
            dt.Columns.Add("rating");
            dt.Columns.Add("review");
            dt.Columns.Add("isLike", typeof(bool));

            foreach (var data in products)
            {
                dt.Rows.Add(data.productId, data.userId, data.rating, data.review, data.isLike);
            }
            //IterateTable(dt);

            return dt;
        }
       
        public static void IterateTable(DataTable table)
        {
            Console.WriteLine("ProductId UserId Review Rating IsLike:\n");
            foreach (DataRow p in table.Rows)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", p["productId"], p["userId"], p["rating"], p["review"], p["isLike"]);
            }
        }

        public static void ReturnsOnlyIfIsLikeFieldAsTrue()
        {
            List<ProductReview> products = new List<ProductReview>();
            DataTable table = CreateDataTable(products);
            var res = from t in table.AsEnumerable() where t.Field<bool>("isLike") == true select t;
            Console.WriteLine("ProductId UserId Review Rating IsLike:\n");
            foreach (var p in res)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", p["productId"], p["userId"], p["rating"], p["review"], p["isLike"]);
            }
        }
        public static void AverageOfRating()
        {
            List<ProductReview> products = new List<ProductReview>();
            DataTable table = CreateDataTable(products);
            double result = (double) table.Select().Where(p => p["rating"] != DBNull.Value).Select(c => Convert.ToDecimal(c["rating"])).Average();
            Console.WriteLine("Average of ratings is: " + result);
           
        }

        public static void ReturnsReviewMessageContainingGood()
        {
            List<ProductReview> products = new List<ProductReview>();
            DataTable table = CreateDataTable(products);
            var res = from t in table.AsEnumerable() where t.Field<string>("review") == "Good" select t;
            Console.WriteLine("ProductId UserId Review Rating IsLike:\n");
            foreach (var p in res)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", p["productId"], p["userId"], p["rating"], p["review"], p["isLike"]);
            }
        }

    }
}
