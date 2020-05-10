using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projetovendas.Models;

namespace projetovendas.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [HttpGet]
        public IActionResult Index(HomeModel formulaeio)
        {
            CarregarListaDados();
            return View();
        }
        public void CarregarListaDados()
        {
            HomeModel objHomeModel = new HomeModel();
            ViewBag.lista = objHomeModel.GetALL();
        }
    }
}