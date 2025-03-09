using System;
using Microsoft.EntityFrameworkCore;
using PageEF.Data;
using PageEF.Models;
namespace PageEF{

class Program{

    public static void Main (string[] args){

        using var ctx = new PageEFDataContext();
        
        // ctx.Users.Add(new User{
        //     Bio = "9x Microsoft MVP",
        //     Email = "andre@balta.io",
        //     Image = "https://balta.io",
        //     Name = "Andre Balta",
        //     PasswordHash = "1234",
        //     Slug = "andre-balta"
        // });
        // ctx.SaveChanges();

        var user = ctx.Users.FirstOrDefault();
        var post = new Post();
        post.Author = null;
        post.Title = "Meu artigo";
        post.Summary = "Neste artigo vamos conferir..";
        post.Body = "Meu artigo";
        post.Slug = "meu-artigo";
        post.CreateDate = DateTime.Now;
        post.Category = new Category{
            Name = "Test category",
            Slug = "test-slug"
                var user = ctx.Users.FirstOrDefault();
        var post = new Post();
        post.Author = null;
        post.Title = "Meu artigo";
        post.Summary = "Neste artigo vamos conferir..";
        post.Body = "Meu artigo";

        };
        ctx.Posts.Add(post);
        ctx.SaveChanges();
    }
}
}
