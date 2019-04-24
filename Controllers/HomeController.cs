using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agenda_Telefonica.Models;

namespace Agenda_Telefonica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Agenda");
        }

        [HttpPost]
        public IActionResult Agenda(Contato contato)
        {
            ContatoDao.IncluirContato(contato);
            return View("Agenda");
        }

        [HttpGet]
        public IActionResult ListaDeContatos()
        {
            return View(ContatoDao.ListaContatos());
        }
    }
}
