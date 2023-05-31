using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_LinqProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() {ProductId =1, UserId=1, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =2, UserId=1, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =3, UserId=2, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =4, UserId=2, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =5, UserId=3, Rating=2, Review= "Bad", isLike=true},
                new ProductReview() {ProductId =6, UserId=4, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =1, UserId=3, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =10, UserId=10, Rating=1, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =11, UserId=10, Rating=1, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =12, UserId=10, Rating=2, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =13, UserId=10, Rating=3, Review= "Nice", isLike=true},
                new ProductReview() {ProductId =14, UserId=10, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =15, UserId=10, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =16, UserId=10, Rating=3, Review= "Nice", isLike=true}
            };
            Console.WriteLine("1: Foreach Loop");
            Console.WriteLine("Enter the choice ");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        foreach (var list in productReviews)
                        {
                            Console.WriteLine("Product Id: " + list.ProductId + " UserId: " + list.UserId + " Rating: " + list.Rating + " Review: " + list.Review + " Like: " + list.isLike);

                        }
                        break;
                    }
                default: Console.WriteLine("Please insert valid option ");
                    break;
            }           

        }
    }
}
