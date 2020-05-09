using MvcContrato;
using MvcEntidad;
using MvcNegocio;
using System.Web.Mvc;

namespace MvcTributaria.Controllers
{
    public class TerceroController : Controller
    {
        //Instancia de la Logica
        ILogicaTercero terceroLogica;

        //Constructor Controlador
        public TerceroController()
        {
            terceroLogica = new LogicaTercero();
        }

        // GET: Tercero
        public ActionResult Index()
        {
            var terceros = terceroLogica.ListarTercero();
            return View(terceros);//Se agrega a la vista la lista de Terceros
        }

        // GET: Tercero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tercero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tercero/Create
        [HttpPost]
        public ActionResult Create(Persona tercero)
        {
            try
            {
                // TODO: Add insert logic here

                terceroLogica.AgregarTercero(tercero);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tercero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tercero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tercero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tercero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
