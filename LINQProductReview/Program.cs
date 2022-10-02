namespace LINQProductReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prodcut Review Management");
            Console.WriteLine("Enter a Option");
            Console.WriteLine("1.Add Values to list");
            int option = Convert.ToInt32(Console.ReadLine());
        
            List<ProductReview> productReviews = new List<ProductReview>();
            switch (option)
            {
                case 1:
                    ProductReviewLINQ.AddProductReview(productReviews);
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;

            }   }
    }
}