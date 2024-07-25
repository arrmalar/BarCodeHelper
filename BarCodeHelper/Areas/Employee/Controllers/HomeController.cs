using BarCodeHelper.DataAccess.Repository.IRepository;
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
            var barcode = "";
            return View("Index", barcode);
        }

        [HttpPost]
        public IActionResult Index(string barCodeNumber)
        {
            var barcodeFromDB = _unitOfWork.BarCodeRepository.Get(b => b.BarCodeNumber == barCodeNumber);

            if (barcodeFromDB != null) {
                return View("../Options/OptionsPanel", barcodeFromDB);
            }

            return View("../Options/NewBarcode", barcodeFromDB);
        }
    }
}
