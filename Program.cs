using System;
using Microsoft.EntityFrameworkCore;
using PageEF.Data;
using PageEF.Models;
namespace PageEF{

class Program{

    public static void Main (string[] args){

        using var ctx = new PageEFDataContext();

           var user = new User();
           user.Name = "Carlos Barbosa";
           user.Slug = "carlosbarbosa";
           user.Email = "carlosbarbosa@balta.io";
           user.Bio = "nothing yet";
           user.Image = "https://balta.io";
           user.PasswordHash = "32165487";

           var category = new Category();
           category.Name = "Back-End";
           category.Slug = "backend";
           

            var post = new Post
            {
                Author = user,
                Category = category,
                Title = "starting EF Core",
                Summary = "carlosbarbosa",
                Body = "<p>Hello World</p>",
                Slug = "starting-ef-core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };

            //ctx.Users.Add(user);
            //ctx.Categories.Add(category);
            ctx.Posts.Add(post);
           ctx.SaveChanges();

        }    
    }
}

//var tag = new Tag {Name = "test", Slug = "test"};
                //ctx.Tags.Update(tag);
                //ctx.SaveChanges();

            //var tag = ctx.Tags.FirstOrDefault(x => x.Id == 3);
            //tag.Name = ".NET";
            //tag.Slug = "dotnet";
            //ctx.Tags.Update(tag);
            //ctx.SaveChanges();

            //var tag = ctx.Tags.FirstOrDefault(x => x.Id == 4);
            //ctx.Tags.Remove(tag);
            //ctx.SaveChanges();

            //var tag = ctx.Tags.ToList();
            //foreach (var item in tag){
                //Console.WriteLine(item.Name);
            //}