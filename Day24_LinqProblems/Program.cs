﻿using System;
using System.Collections.Generic;
using System.Data;
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
                new ProductReview() {ProductId =1, UserId=1, Rating=5, Review= "Bad", isLike=true},
                new ProductReview() {ProductId =2, UserId=1, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =2, UserId=2, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =4, UserId=2, Rating=4, Review= "Nice", isLike=true},
                new ProductReview() {ProductId =5, UserId=3, Rating=2, Review= "Bad", isLike=true},
                new ProductReview() {ProductId =1, UserId=4, Rating=4, Review= "Good", isLike=true},
                new ProductReview() {ProductId =1, UserId=3, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =10, UserId=20, Rating=1, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =10, UserId=10, Rating=1, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =12, UserId=9, Rating=2, Review= "Bad", isLike=false},
                new ProductReview() {ProductId =9, UserId=12, Rating=3, Review= "Nice", isLike=true},
                new ProductReview() {ProductId =10, UserId=10, Rating=6, Review= "Good", isLike=true},
                new ProductReview() {ProductId =15, UserId=14, Rating=5, Review= "Good", isLike=true},
                new ProductReview() {ProductId =16, UserId=25, Rating=3, Review= "Nice", isLike=true}
            };
            Managment managment = new Managment();
            Console.WriteLine("1: Foreach Loop \n2: Top Records \n3: Retrive Records Based On Rating \n4: Count Records In List " +
                "\n5: Retrive Selected Column \n6: Skip Top Recods \n7: Adding List Data To DataTable");
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
                case 2:
                    {
                        managment.TopRecordList(productReviews);
                        break;
                    }
                case 3:
                    {
                        managment.SelectedRecord(productReviews);
                        break;
                    } 
                case 4:
                    {
                        managment.RetriveCountOfRecordList(productReviews);
                        break;
                    } 
                case 5:
                    {
                        managment.SelectedColumnRecordList(productReviews);
                        break;
                    } 
                case 6:
                    {
                        managment.SkipTopRecordList(productReviews);
                        break;
                    }
                case 7:
                    {
                       DataTable table= managment.AddToDataTable(productReviews);
                        break;
                    }
                default: Console.WriteLine("Please insert valid option ");
                    break;
            }           

        }
    }
}
