using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Context;
using mvc.Models;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        private const string MENSAGEM_PRIVACY = "Nossos direitos";

        private readonly AgendaContext _context;
        public HomeController(AgendaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

            ViewBag.Mensagem = MENSAGEM_PRIVACY;
            ViewData["Transp"] = "Oláaaaaaaaaaaaa";
            return View();
        }

    }
}