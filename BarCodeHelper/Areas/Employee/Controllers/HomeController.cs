using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookSupp.Areas.Customer.Controllers
{
    [Area("Employee")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var barCodeNumber = new BarCodeNumber();
            return View("Index", barCodeNumber);
        }

        [HttpPost]
        public IActionResult Index(BarCodeNumber barCodeNumber)
        {
            var barcodeFromDB = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCodeNumber.Number, includeProperties: "Product");

            if (barcodeFromDB != null)
            {
                return RedirectToAction("OptionsPanel", "Options", barcodeFromDB);
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "NewBarCode", new { barCodeNumber = barCodeNumber.Number });
            }

            return View(barCodeNumber);
        }
    }
}
