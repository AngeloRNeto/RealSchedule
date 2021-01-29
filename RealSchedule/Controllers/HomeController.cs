using RealSchedule.Domain.Interfaces;
using RealSchedule.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealSchedule.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioService usuarioService;
        private readonly IAgendaService agendaService;
        public HomeController(IUsuarioService service, IAgendaService agendaService)
        {
            this.usuarioService = service;
            this.agendaService = agendaService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Schedule()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveUser(Usuario usuario)
        {
            try
            {
                return Json(usuarioService.Insert(usuario), JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, ex = ex }, JsonRequestBehavior.AllowGet);
            }

        }

    }
}