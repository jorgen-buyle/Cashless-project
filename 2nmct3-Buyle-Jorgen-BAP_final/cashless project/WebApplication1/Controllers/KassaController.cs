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
    public class KassaController : Controller
    {
        // GET: Kassa
        public ActionResult Index()
        {
            List<KassaModel> kas = DAKassas.GetAllKassa();
            ViewBag.kas = kas;
            return View();
        }
        [HttpGet]
        public ActionResult Info(int id) 
        {

            ViewBag.ver = DAVereniging.GetVerenigingen();
            ViewBag.kas = DAKassas.GetKassaById(id);
            return View();
        }
        [HttpPost]
        public ActionResult Info(int kasId, int verId)
        {
            DateTime today = DateTime.Today;

            string time = today.ToString("dd-MM-yyyy");
            DAKassas.UploadKassaToVereniging(kasId, verId,time, time);
            return Redirect("Index");
        }
        public ActionResult NewKassa() {
            
            return View();
        }
        [HttpPost]
        public ActionResult NewKassa(KassaModel kas) 
        {
            DAKassas.NewKassa(kas.RegisterName, kas.Device, kas.PurchesData, kas.ExpiresDate);
            return Redirect("Index");
        }
        public ActionResult Logboek(int Id){
            List<LogboekModel> error = new List<LogboekModel>();

            error = DAKassas.GetErrors(Id);
            return View(error);
        }
    }
}