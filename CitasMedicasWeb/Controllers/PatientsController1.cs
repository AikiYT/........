using CitasMedicas.Applications.Contracts;
using CitasMedicas.Applications.Services.Configuration;
using CitasMedicasApp.Persistance.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitasMedicasWeb.Controllers
{
    public class PatientsController1 : Controller
    {
        private readonly IDoctorService patientsService;

        public PatientsController1(IDoctorService doctorService)
        {
            this.patientsService = doctorService;
        }
        // GET: PatientsController1
        public async Task<ActionResult> Index()
        {

            var result = await patientsService.GetAll();
            if (result.IsSuccess)
            {
                List<PatientsModel> doctorController1 = (List<PatientsModel>)Results.Empty;
                return View(doctorController1);
            }
            return View();
        }

        // GET: PatientsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientsController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PatientsController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientsController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
