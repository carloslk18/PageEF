using System;
using Microsoft.EntityFrameworkCore;
using PageEF.Data;
using PageEF.Models;
namespace PageEF{

class Program{
    

    public static void Main (string[] args){

        using var ctx = new PageEFDataContext();
    }
}
}
