using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using var context = new BlogDataContext();

                // var user = new User
                // {
                //     Name = "Bruno Gomes2",
                //     Slug = "brunogomes2",
                //     Email = "brunogomes@bruno.com",
                //     Bio = "Analista Senior",
                //     Image = "https://brunogomes.io",
                //     PasswordHash = "123456789"
                // };

                // context.Users.Add(user);
                // context.SaveChanges();

                //var user = context.Users.FirstOrDefault();
                //var category = context.Categories.FirstOrDefault();
                // var category = new Category { Name = "Front-End", Slug = "frontend" };

                // var post = new Post
                // {
                //     Author = user,
                //     Category = category,
                //     Body = "<p>Hello world</p>",
                //     Slug = "comecando-com-front",
                //     Summary = "Neste artigo vamos aprender EF core",
                //     Title = "Começando com EF Core",
                //     CreateDate = DateTime.Now,
                //     LastUpdateDate = DateTime.Now,
                // };

                // context.Posts.Add(post); // Não adicionei autor nem categoria
                // context.SaveChanges();

                // var posts = context
                //     .Posts
                //     .AsNoTracking()
                //     .Include(x => x.Author)
                //     .Include(x => x.Category)
                //     .OrderBy(x => x.LastUpdateDate)
                //     .ToList();

                // foreach (var post in posts)
                //     Console.WriteLine($"{post.Title} por {post.Author.Name} em {post.Category.Name}");

                // Console.ReadKey();

                // var post = context
                //     .Posts
                //     // .AsNoTracking() PRECISA DO TRACKING 
                //     .Include(x => x.Author)
                //     .Include(x => x.Category)
                //     .OrderBy(x => x.LastUpdateDate)
                //     .FirstOrDefault(); // Pegando o primeiro item

                // post.Author.Name = "Uncle Bob";

                // context.Posts.Update(post);
                // context.SaveChanges();


                // //Paginação
                // var Skip = 0;
                // var Take = 20;
                // var Posts = context
                //     .Posts
                //     .AsNoTracking()
                //     .Skip(Skip)
                //     .Take(Take)
                //     .ToArray();

                // foreach (var item in Posts)
                // {
                //     Console.WriteLine(item?.Title);
                // }

                //var teste = context.CategoryWithCounts.ToArray();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO>>>:{ex.Message}");
            }

        }
    }
}