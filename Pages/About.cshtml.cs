using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace AspDotNetDemo.Pages
{
    public class AboutModel : PageModel
    {
        private List<Book> ListOfBooks;
        private readonly IConfiguration configuration;

        public AboutModel(IConfiguration configuration)
        {
            
            ListOfBooks = new List<Book>
            {
                new Book { Id=1,Title="C#",Auther="Mohamed HAmdy",Price=24},
                new Book { Id=2,Title="C++",Auther="Mohamed HAmdy",Price=40},
                new Book { Id=3,Title="Python",Auther="Ahmed HAmdy",Price=50},
            };


            this.configuration = configuration;


           // configuration["AboutPageTitle"] = "Value New";
        }
        public void OnGet()
        {
        }

        public string GetTitle()
        {
            return Properties.Resources.AboutPageTitle ;
        }
        public List<Book> GetBooks()
        {
            return ListOfBooks;
        }
        public string GetPageTitle()
        {
            return configuration["AboutPageTitle"];
        }
    }


    public class Book {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Price { get; set; }
    }
}
