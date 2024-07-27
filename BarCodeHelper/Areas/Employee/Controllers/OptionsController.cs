using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IActionResult OptionsPanel(BarCode barCode)
        {
            return View(barCode);
        }

        public IActionResult Delete(string? barCodeNumber)
        {
            var barCodeToBeDeleted = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCodeNumber);

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
