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
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //string VerenigingNaam, string StraatNR, string postcode, string Locatie, string email, string telefoon, string Login, string Passwoord
        public ActionResult Index(Vereniging ver)
        {

            string address = ver.StraatNr + ";" + ver.Postcode + ";" + ver.Locatie;
            string DbName = "DB" + ver.VerenigingNaam;
            string DbPasswoord = "Db" + ver.Postcode + ver.Passwoord;
            DAManagement.NieuweOrga(ver.login, ver.Passwoord, DbName, DbPasswoord, ver.VerenigingNaam, address, ver.Email, ver.Telefoon);
            DAManagement.CreateDataBase(DbName);
            DAManagement.FillDataBase(DbName);
            return RedirectToAction("../Home");
        }
    }
}