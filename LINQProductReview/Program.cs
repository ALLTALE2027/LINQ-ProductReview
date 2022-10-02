namespace LINQProductReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prodcut Review Management");
            Console.WriteLine("Enter a Option");
            Console.WriteLine("1.Add Values to list");
            Console.WriteLine("2.Retrieve Top 3 Records");
            Console.WriteLine("3.Retrieve Records Based On Rating and Product Id's");
            Console.WriteLine("4.Retrive the count records by productId");
            Console.WriteLine("5.Retrieving the product id and review in list");
            Console.WriteLine("6.Skip Top five records");
            Console.WriteLine("7.Create DataTable");
            Console.WriteLine("8.Retrieve the records whose column islike has true using (DataTable)");
            int option = Convert.ToInt32(Console.ReadLine());
        
            List<ProductReview> productReviews = new List<ProductReview>();
            switch (option)
            {
                case 1:
                    ProductReviewLINQ.AddProductReview(productReviews);
                    break;
                case 2:
                    ProductReviewLINQ.RetrieveTopThreeRating(productReviews);
                    break;
                case 3:
                    ProductReviewLINQ.RetrieveRecordsBasedOnRatingAndProductId(productReviews);
                    break;
                case 4:
                    ProductReviewLINQ.CountingRecordsByProductId(productReviews);
                    break;
                case 5:
                    ProductReviewLINQ.RetrieveOnlyProductIdAndReviews(productReviews);
                    break;
                case 6:
                    ProductReviewLINQ.SkipTopFiveRecords(productReviews);
                    break;
                case 7:ProductReviewLINQ.CreateDataTable(productReviews);
                    break;
                case 8:
                    ProductReviewLINQ.ReturnsOnlyIfIsLikeFieldAsTrue();
                    break;

                default:
                    Console.WriteLine("Enter correct choice");
                    break;

            
            }   
        }
    }
}