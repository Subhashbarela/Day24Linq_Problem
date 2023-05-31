using System;
using System.Collections.Generic;
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
    }
}
