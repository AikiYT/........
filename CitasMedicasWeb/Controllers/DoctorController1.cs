using CitasMedicas.Applications.Contracts;
using CitasMedicas.Applications.Services.Configuration;
using CitasMedicasApp.Persistance.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitasMedicasWeb.Controllers
{
    public class DoctorController1 : Controller
    {
        private readonly IDoctorService doctorService;

        public DoctorController1(IDoctorService doctorService)
        {
              this.doctorService = doctorService;
        }


        public async Task<IActionResult> Index()
        {
            var result = await doctorService.GetAll();
           if (result.IsSuccess)
           {
                List<DoctorModel> doctorController1 = (List<DoctorModel>)Results.Empty;
                    return View(doctorController1);
            }
          return View();
        }

        /*public async ActionResult Details(int id)
        {
            var result = doctorService.GetById(id);
            if (result.IsCompletedSuccessfully)
            {


                BusModel busModel = (BusModel)result.
                    return View(doctorService);
            }
            return View();
        }*/

        public ActionResult Create()
        {
            return View();
        }

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

        public ActionResult Edit(int id)
        {
            return View();
        }

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

    }
}
