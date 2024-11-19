using CitasMedicas.Applications.Contracts;
using CitasMedicas.Applications.Services.Configuration;
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


        //public async Task<IActionResult> Index()
        //{
        //    var result = await doctorService.GetAll();
        //    if (result.IsSuccess)
        //    {
        //        List<DoctorController1> doctorController1 = (List<DoctorController1>)Results.Data;
        //             return View(doctorController1);
        //    }
        //   return View();
        //}

        public ActionResult Details(int id)
        {
            return View();
        }

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
