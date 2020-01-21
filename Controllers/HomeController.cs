using SiteEmpresarial.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteEmpresarial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuemSomos()
        {
            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Concluido = false;
            return View();
        }
       
        [HttpPost]
        public ActionResult Contato(Models.Contato contato)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ValidationException("O contato preceisa ser valido");
                }
                using( var db = new SiteEmpresarialDBContext())
                {
                    db.Contatos.Add(contato);
                    db.SaveChanges();
                }
                return View("ContatoSucesso");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

    }
}