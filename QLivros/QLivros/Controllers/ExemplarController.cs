using QLivros.Models;
using QLivros.Models.BusinessController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLivros.Controllers
{
    public class ExemplarController : Controller
    {
        ExemplarBusinessController exemplarBC = new ExemplarBusinessController();
        ProprietarioBusinessController proprietarioBC = new ProprietarioBusinessController();


        public ActionResult Lista(string titulo)
        {
            var retornoLista = exemplarBC.FiltrarTitulo(titulo);
            return View(retornoLista);
        }

        public ActionResult InfoContato(long id)
        {
            var dadosContato = proprietarioBC.ObterContatos(id);
            return PartialView("DadosContato",dadosContato);
        }
    }
}