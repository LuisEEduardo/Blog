using System;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class PostRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PostRepository(SqlConnection connection) : base(connection)
            => _connection = connection;


        public void UpdatePost(Post post)
        {
            var query = @"
                        UPDATE [Post]
                        SET Title = @title,
                            Summary = @summary,
                            Body = @body,
                            Slug = @slug,        
                            CreateDate = @createDate,        
                            LastUpdateDate = @date,
                            AuthorId = @authorId,
                            CategoryId = @categoryId
                        WHERE Id = @id";

            _connection.Execute(query, new
            {
                id = post.Id,
                summary = post.Summary, 
                body = post.Body,
                slug = post.Slug, 
                createDate = DateTime.Now,
                date = DateTime.Now,
                authorId = post.AuthorId,
                categoryId = post.CategoryId
            });

        }
    }
}