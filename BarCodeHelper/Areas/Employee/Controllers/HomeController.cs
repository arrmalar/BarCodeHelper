using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

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
            var barcode = "";
            return View("Index", barcode);
        }

        [HttpPost]
        public IActionResult Index(string barCodeNumber)
        {
            var barcodeFromDB = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCodeNumber);

            if (barcodeFromDB != null) {
                // wyœwietliæ dzia³ania
                // edycja przypisanego produktu
                // usuwanie barcode
                // zmiana lokalizacji
                // itd

                return View("OptionsPanel");
            }

            return View("NewBarCode", barCodeNumber);
        }

        public IActionResult NewBarcode(string barCodeNumber)
        {
            var barcodeFromDB = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCodeNumber);

            if (barcodeFromDB != null)
            {
                // wyœwietliæ dzia³ania
                // edycja przypisanego produktu
                // usuwanie barcode
                // zmiana lokalizacji
                // itd

                return View("OptionsPanel");
            }

            return View("NewBarCode");
        }
    }
}
