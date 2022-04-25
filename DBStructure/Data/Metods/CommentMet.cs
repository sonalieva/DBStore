using System;
using System.Collections.Generic;
using System.Text;
using DBStructure.Data.DAL;
using DBStructure.Data.Exceptions;
using DBStructure.Data.Models;
using DBStructure.Data.Metods;
using System.Linq;



namespace DBStructure.Data.Metods
{
    internal class CommentMet
    {

        StoreDbContext StoreDbContext = new StoreDbContext();
        CommentMet commentsMet = new CommentMet();
        UserMet userData = new UserMet();


        public void CheckAddComment(Comments comment)
        {
            if ((storeDbContext.User.Find(comment.UserId) != null) && (bravoStoreDbContext.Products.Find(comment.ProductId) != null))
            {
                commentsMet.AddComment(comment);
            }
            else
            {
                throw new NotFoundException("Bu id'li user veya product yoxdur!");
            }
        }
        public void CheckCommentUserId(int id)
        {
            var comments = StoreDbContext.Comments.Where(x => x.UserId == id).ToList();
            if (comments.Count > 0)
            {
                usersMet.GetCommentsByUserId(id);
            }
            else
            {
                throw new NotFoundException(" Userin commenti yoxdur!");
            }
        }
        public void CheckIdForComment(int id)
        {
            var comment = StoreDbContext.Comments.Find(id);

            if (comment == null)
            {
                throw new NotFoundException("Comment yoxdur!");
            }
            else
            {
                commentsMet.DeleteComment(comment);
            }
        }


        public void CheckCommentForProductId(int id)
        {
            var comments = StoreDbContext.Comments.Where(x => x.ProductId == id).ToList();
            if (comments.Count > 0)
            {
                commentsMet.GetCommentsByProductId(id);
            }
            else
            {
                throw new NotFoundException(" Productda comment yoxdur!");
            }
        }



        public void CheckDelete(int id)
        {
            var comment = StoreDbContext.Comments.Find(id);
            if (comment != null)
            {
                commentsMet.DeleteComment(comment);
            }
            else
            {
                throw new NotFoundException("Bele bir comment yoxdur!");
            }
        }

        public void CheckCommentWithDate(DateTime startDate, DateTime endDate)
        {
            var comments = StoreDbContext.Comments.Where(x => x.CreatedAt > startDate && x.CreatedAt < endDate).ToList();
            if (comments.Count > 0)
            {
                commentsMet.GetCommentsForDate(startDate, endDate);
            }
            else
            {
                throw new NotFoundException("Bu tarixde comment yoxdur!");
            }
        }
    }
}
