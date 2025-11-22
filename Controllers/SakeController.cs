using Microsoft.AspNetCore.Mvc;
using SAKEWeb.Models;

namespace SAKEWeb.Controllers
{
    public class SakeController : Controller
    {
        private static double totalBonusGlobal = 0;

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.TotalGlobal = totalBonusGlobal;
            return View();
        }

        [HttpPost]
        public IActionResult Index(SakeViewModel model)
        {
            double tunjanganDasar = 0;
            double bonusLembur = 0;

            // SWITCH-CASE
            switch (model.Posisi)
            {
                case 1: tunjanganDasar = 500000; break;
                case 2: tunjanganDasar = 350000; break;
                case 3: tunjanganDasar = 200000; break;
                default: tunjanganDasar = 50000; break;
            }

            // IF-ELSE-IF
            if (model.Lembur >= 40)
                bonusLembur = tunjanganDasar * 0.25;
            else if (model.Lembur >= 20)
                bonusLembur = tunjanganDasar * 0.15;
            else if (model.Lembur >= 1)
                bonusLembur = tunjanganDasar * 0.05;
            else
                bonusLembur = 0;

            double totalAkhir = tunjanganDasar + bonusLembur;

            // Update global
            totalBonusGlobal += totalAkhir;

            // Status kinerja
            string status = totalAkhir > 600000
                ? "Karyawan Kinerja Prima Bulan Ini!"
                : "Kinerja Stabil.";

            model.TunjanganDasar = tunjanganDasar;
            model.BonusLembur = bonusLembur;
            model.TotalBonusAkhir = totalAkhir;
            model.StatusKinerja = status;

            ViewBag.TotalGlobal = totalBonusGlobal;

            return View(model);
        }
    }
}
