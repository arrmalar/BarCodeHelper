using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace CookSupp.Areas.Customer.Controllers
{
    [Area("Employee")]
    public class OptionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public OptionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public IActionResult NewBarCode(BarCode barCode)
        {
            // trzeba zapisaæ do bazy jako barCode który zosta³ zeskanowany ale jest nieprzypisany



            // tutaj trzeba zapisaæ barCode do bazy
            // po zapisie redirect do options

            return View();
        }

        public IActionResult Delete(BarCode barCode)
        {
            var barCodeToBeDeleted = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCode.BarCodeNumber);

            if (barCodeToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.BarCodeRepository.Remove(barCodeToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete successful" });
        }

        public IActionResult Move(BarCode barCode)
        {
            return View(barCode);
        }

        public IActionResult Logs(BarCode barCode)
        {
            return View(barCode);
        }

        public IActionResult Details(BarCode barCode)
        {
            return View(barCode);
        }
    }
}
