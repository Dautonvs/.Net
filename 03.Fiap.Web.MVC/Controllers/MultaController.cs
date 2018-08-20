using _03.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Fiap.Web.MVC.Controllers
{
    public class MultaController : Controller
    {

        [HttpGet] //Abre a página do Formulário              
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Recuper os dados e cadastra no BD
        public ActionResult Cadastrar(Multa multa)
        {

            //Enviar valores para a tela
            ViewBag.churros = multa.Placa;
            TempData["msg"] = "Daniel vive dando o anel!";
            return View(multa);
        }
    }
}