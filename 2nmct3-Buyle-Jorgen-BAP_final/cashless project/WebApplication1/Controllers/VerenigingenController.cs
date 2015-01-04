using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.helper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class VerenigingenController : Controller
    {
        // GET: Verenigingen
        [HttpGet]
        public ActionResult Index()
        {
            
            List<Vereniging> ver  = new List<Vereniging>();
            ver = DAVereniging.GetVerenigingen();
            ViewBag.ver = ver;
            return View();
        }
        [HttpGet]
        public ActionResult Info(int Id)
        {
            Vereniging ver = new Vereniging();
            ver = DAVereniging.GetVerenigingenById(Id);
            List<KassaVerenigingModel> KVM = DAVereniging.GetKassasVoorVereniging(Id);
            ViewBag.kvm = KVM;
            ViewBag.ver = ver;
            return View();
        }
        [HttpGet]
        public ActionResult Bewerk(int Id) {
            Vereniging ver = new Vereniging();
            ver = DAVereniging.GetVerenigingenById(Id);
            ViewBag.ver = ver;
            return View(ver);
        }
        [HttpPost]
        public ActionResult Bewerk(Vereniging ver) {
            string address = ver.StraatNr + ";" + ver.Postcode + ";" + ver.Locatie;
            DAVereniging.UpdateVerenigingen(ver.login, ver.Passwoord, ver.Dbname, ver.DbPasswoord, ver.VerenigingNaam, address, ver.Email, ver.Telefoon, ver.Id);
            return RedirectToAction("../Home"); 
        }
        
        public ActionResult Verwijder(int id){
            DAVereniging.DeleteKassaUitVereniging(id);
            return RedirectToAction("../Home");
        }

    }
}