﻿using Domain.Entities;

namespace Domain.Contracts
{
    //public interface ICommentRepository
    //{
    //    Comment Find(int commentId);
    //    void AddComment(Comment comment);
    //    void AddComment(int postId, string commentName, string commentEmail, string commentTitle,
    //    string commentBody);
    //    void UpdateComment(Comment comment);
    //    void DeleteComment(Comment comment);
    //    void DeleteComment(int commendId);
    //    IList<Comment> GetAllComments();
    //    IList<Comment> GetCommentsForPost(int postId);
    //    IList<Comment> GetCommentsForPost(Post post);
    //}

    public interface ICommentRepository : IGenericRepository<Comment>
    {

    }
}
