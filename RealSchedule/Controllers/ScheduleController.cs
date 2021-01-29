using RealSchedule.Domain.Interfaces;
using RealSchedule.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealSchedule.Controllers
{
    public class SheduleController : Controller
    {
        private readonly IAgendaService agendaService;
        public SheduleController(IUsuarioService service, IAgendaService agendaService)
        {
            this.agendaService = agendaService;
        }

        public ActionResult Index()
        {
            return View();
        }

 
        [HttpPost]
        public ActionResult CreateSchedule(Agenda schedule)
        {
            try
            {
                return Json(agendaService.Insert(schedule), JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, ex = ex }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}