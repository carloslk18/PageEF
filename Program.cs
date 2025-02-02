using System;
using Microsoft.EntityFrameworkCore;
using PageEF.Data;
using PageEF.Models;
namespace PageEF{

class Program{

    public static void Main (string[] args){

        using (PageEFDataContext ctx = new PageEFDataContext()){

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
        }
        
    }
}
}