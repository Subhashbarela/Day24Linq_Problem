using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_LinqProblems
{
    public class Managment
    {
        public void TopRecordList(List<ProductReview> review)
        {
            var recordData = (from productReviews in review
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id: " + list.ProductId + " | UserId: " + list.UserId + " | Rating: " + list.Rating + " | Review: " + list.Review + " | Like: " + list.isLike);

            }
        }
        public void SelectedRecord(List<ProductReview> review)
        {
            var recordData = from productReviews in review
                             where( (productReviews.ProductId == 1  || productReviews.ProductId == 4 || productReviews.ProductId == 9) && productReviews.Rating > 3)
                             select productReviews;


            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id: " + list.ProductId + " | UserId: " + list.UserId + " | Rating: " + list.Rating + " | Review: " + list.Review + " | Like: " + list.isLike);

            }
        }
        public void RetriveCountOfRecordList(List<ProductReview> review)
        {
            var recordData = review.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id: " + list.ProductId + " Total: " + list.Count);

            }
        }
        public void SelectedColumnRecordList(List<ProductReview> review)
        {
            var recordData = (from productReviews in review
                              select ("[ "+productReviews.ProductId +"   " + productReviews.Review+" ]"));

            Console.WriteLine(" Id Reviews");
            foreach (var list in recordData)
            {
                Console.WriteLine(list);

            }
        }
        public void SkipTopRecordList(List<ProductReview> review)
        {
            var recordData = (from productReviews in review
                              select productReviews).Skip(5);

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id: " + list.ProductId + " | UserId: " + list.UserId + " | Rating: " + list.Rating + " | Review: " + list.Review + " | Like: " + list.isLike);

            }
        }
        public DataTable AddToDataTable(List<ProductReview> review)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductId", typeof(int));
            table.Columns.Add("UserId", typeof(int));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("isLike", typeof(bool));
            foreach (var list in review)
            {
                table.Rows.Add(list.ProductId, list.UserId,list.Rating,list.Review, list.isLike);
            }
            return table;
        }
    }
}
