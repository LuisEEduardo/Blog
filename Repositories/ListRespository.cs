using System.Collections.Generic;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class ListRepository
    {
        private readonly SqlConnection _connection;

        public ListRepository(SqlConnection connection)
            => _connection = connection;


        public int CountQtyPostByCategory(int categoryId)
        {
            var query = @"
                            SELECT COUNT(*)
                            FROM [Post] 
                            WHERE [CategoryId] = @id
                            GROUP BY [CategoryId]";

            var quantity = _connection.ExecuteScalar<int>(query, new
            {
                id = categoryId
            });

            return quantity;
        }


        public IEnumerable<string> SelectAllPostsEvenCategory(int categoryId)
        {
            var query = @"
                            SELECT [Title]
                            FROM [Post] 
                            WHERE [CategoryId] = @id
                            ";
            var postsName = _connection.Query<string>(query, new
            {
                id = categoryId
            });

            return postsName;
        }

        public IEnumerable<Tag> ListTagsWithQtyPosts()
        {
            var query = @"
            SELECT * 
            FROM [Tag] as t
                    INNER JOIN  
                [Post] as p
                ON t.Id = (SELECT TagId 
                            FROM [PostTag]) 
                        AND 
                    p.Id = (SELECT PostId 
                            FROM [PostTag])";
            var tags = _connection.Query<Tag, Post, Tag>(
                    query,
                    map: (tag, post) =>
                    {
                        tag.Posts.Add(post);
                        return tag;
                    },
                    splitOn: "Id,Id");                    
            return tags;
        }


    }
}