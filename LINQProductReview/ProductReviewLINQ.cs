using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProductReview
{
    internal class ProductReviewLINQ
    {
        public static void AddProductReview(List<ProductReview> products)
        {
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Good", rating = 14, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 12, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 4, review = "Good", rating = 19, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 7, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Very Good", rating = 19, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 15, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 8, review = "Average", rating = 11, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 13, isLike = true });
            products.Add(new ProductReview() { productId = 7, userId = 10, review = "Very Good", rating = 18, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 5, review = "Very Good", rating = 17, isLike = true });
            products.Add(new ProductReview() { productId = 10, userId = 3, review = "Bad", rating = 9, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 2, review = "Bad", rating = 8, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 9, review = "Average", rating = 11, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 11, review = "Good", rating = 15, isLike = true });
            products.Add(new ProductReview() { productId = 12, userId = 3, review = "Bad", rating = 6, isLike = false });
            products.Add(new ProductReview() { productId = 14, userId = 15, review = "Very Good", rating = 19, isLike = true });
            products.Add(new ProductReview() { productId = 18, userId = 9, review = "Bad", rating = 7, isLike = false });
            products.Add(new ProductReview() { productId = 13, userId = 1, review = "Very Good", rating = 20, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 10, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 15, isLike = true });
            products.Add(new ProductReview() { productId = 19, userId = 8, review = "Average", rating = 11, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 6, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 13, isLike = true });
            Console.WriteLine("Product reviews added");
            IterateThroughList(products);
           
        }
        public static void IterateThroughList(List<ProductReview> products)
        {
            foreach (ProductReview product in products)
            {
                Console.WriteLine("ProductId:{0}\t UserId:{1}\t Review:{2}\tRating:{3}\tIsLike:{4}\t", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
    }
}
