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
                        AuthorId = @authorId,    
                        CategoryId = @categoryId,                                 
                        LastUpdateDate = @lastUpdateDate                                                
                        WHERE Id = @id";

            var rows = _connection.Execute(query, new
            {
                id = post.Id,
                title = post.Title,
                summary = post.Summary,
                body = post.Body,
                slug = post.Slug,
                lastUpdateDate = DateTime.Now,
                authorId = post.AuthorId,
                categoryId = post.CategoryId,
            });

            Console.WriteLine($"{rows} row affected");

        }
    }
}