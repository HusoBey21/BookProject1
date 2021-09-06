using BookProject1.Business.Abstract;
using BookProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthorService _authorService;

        private readonly IBookService _bookService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger , IAuthorService authorService, IBookService bookService)
        {
            _logger = logger;
            _authorService = authorService;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            // _authorService.Add(new Entitys.Entity.Author() { FirstName = "İsmail", LastName = "Çamlıbel" });

            var author = _authorService.GetById(1);
            return View(author);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
