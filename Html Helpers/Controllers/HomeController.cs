using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Html_Helpers.Models;

namespace Html_Helpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Persona()
        {
            Persona lista = new Persona();

            List<ModelCheckBox> listado = new List<ModelCheckBox>();
            listado.Add(new ModelCheckBox() { Id = 1, Hobbys = "Nadar", isChecked = false });
            listado.Add(new ModelCheckBox() { Id = 2, Hobbys = "Leer", isChecked = false });
            listado.Add(new ModelCheckBox() { Id = 3, Hobbys = "Escuchar Musica", isChecked = false });
            listado.Add(new ModelCheckBox() { Id = 4, Hobbys = "Correr en el parque", isChecked = false });
            lista.Hobby = listado;

            return View(lista);
        }
        [HttpPost]
        public ActionResult Persona(Persona obj)
        {
            if (ModelState.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                    foreach (var item in obj.Hobby)
                    {
                        if (item.isChecked)
                        {
                            sb.Append(item.Hobbys + ",");
                        }
                    }
                    TempData["hobbys"] = sb;

                    return RedirectToAction("Usuario", obj);
            }
            else
            {
                return View(obj);
            };
        }
        public ActionResult Usuario(Persona obj)
        {
            if (TempData["hobbys"] != null)
            {
                ViewBag.Listado = TempData["hobbys"].ToString();
            }
            return View(obj);
        }
    }
}